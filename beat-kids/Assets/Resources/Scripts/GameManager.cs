using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Object m_ObjectNote = null;
    public Text m_HPText = null;
    public float m_HPValue = float.NaN;
    public float m_Damage = float.NaN;
    public BeatLaneUI[] m_Lanes = null;

    private GameObject m_Canvas = null;
    private System.Random m_Random = null;

    public void SpawnNotes()
    {
        foreach(BeatLaneUI bls in this.m_Lanes)
        {
            BeatNote bn = (Instantiate(this.m_ObjectNote, this.m_Canvas.transform) as GameObject).GetComponent<BeatNote>();
            bn.Data = this.m_Random.Next(1, 10).ToString();
            bn.Speed = 45.0f;
            bls.PushNote(bn, 150.0f);
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Main");
    }

    public void LoseHP()
    {
        this.m_HPValue -= this.m_Damage;
        if(this.m_HPValue <= 0.0f)
        {
            this.GameOver();
        }
        else
        {
            this.m_HPText.text = this.m_HPValue.ToString("F0");
        }
    }

    private void Awake()
    {
        this.m_ObjectNote = Resources.Load("Prefab/Note");
        this.m_Canvas = GameObject.Find("Canvas");
        this.m_Random = new System.Random();
    }

    private void Start()
    {
        this.m_HPText.text = this.m_HPValue.ToString("F0");
    }
}
