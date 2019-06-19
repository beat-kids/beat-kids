using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteManager : MonoBehaviour
{
    public Object m_NoteObject = null;
    public GameManager m_GameManager = null;
    public DataManager m_DataManager = null;
    public Text m_Question = null;
    public BeatLaneUI[] m_Lanes = null;

    private Queue<Problem> m_Problems = null;
    private GameObject m_Canvas = null;

    public void PopFront(string _data)
    {
        if(this.m_Problems.Count > 0)
        {
            if (_data == this.m_Problems.Peek().Answer)
            {
                this.m_GameManager.GetScore();
                this.m_GameManager.AddCombo();
            }
            else
            {
                this.m_GameManager.LoseHP();
            }

            this.m_Lanes[0].PopFirstNotes();
            this.m_Problems.Dequeue();
        }
    }

    private void Awake()
    {
        this.m_Canvas = GameObject.Find("Canvas");
    }

    private void Start()
    {
        this.m_Question.text = string.Empty;
        this.m_Problems = new Queue<Problem>();
    }

    private void Update()
    {
        this.UpdateProblem();
        this.UpdateQuestion();
    }

    private void UpdateProblem()
    {
        Problem p = this.m_DataManager.NextProblem();
        if(p != null)
        {
            this.m_Problems.Enqueue(p);
            for(int i = 0; i < 3; ++i)
            {
                BeatNote bn = (Instantiate(this.m_NoteObject, this.m_Canvas.transform) as GameObject).GetComponent<BeatNote>();
                bn.Data = p.Choices[i].Choice;
                bn.Speed = 45.0f;
                bn.Answer = p.Answer;
                bn.m_NoteManager = this;
                this.m_Lanes[i].PushNote(bn, 150.0f);
            }
        }
    }

    private void UpdateQuestion()
    {
        if(this.m_Problems.Count > 0)
        {
            this.m_Question.text = this.m_Problems.Peek().Question;
        }
        else
        {
            this.m_Question.text = string.Empty;
        }
    }
}
