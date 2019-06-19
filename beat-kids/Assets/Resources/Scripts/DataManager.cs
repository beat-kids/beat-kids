using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[Serializable]
public class NoteInfo
{
    public string Choice;

    public NoteInfo(string _Choice)
    {
        this.Choice = _Choice;
    }
}

[Serializable]
public class Problem
{
    public string Question;
    public List<NoteInfo> Choices = new List<NoteInfo>();
    public string Answer;
}

[Serializable]
public class StudyBook
{
    public string Name;
    public List<Problem> Problems = new List<Problem>();
}

public class DataManager : MonoBehaviour
{
    public TextAsset[] m_MathQuestions = null;
    public TextAsset[] m_EnglishQuestions = null;
    public AudioClip[] m_Clips = null;
    public TextAsset[] m_Syncs = null;
    public GameManager m_GameManager = null;
    public AudioSource m_Audio = null;

    private System.Random m_Random = new System.Random();
    private string m_Mode = string.Empty;
    private int m_MusicIndex = 0;
    private int m_Difficulty = 0;
    private StudyBook m_StudyBook = null;
    private List<float> m_SpawnTimes = new List<float>();
    private float m_Timer = 0.0f;
    private float m_ClipRuntime = 0.0f;

    public Problem NextProblem()
    {
        if((this.m_SpawnTimes.Count > 0) && (this.m_SpawnTimes[0] <= this.m_Timer))
        {
            this.m_SpawnTimes.RemoveAt(0);
            int index = this.m_Random.Next(this.m_StudyBook.Problems.Count);
            return this.m_StudyBook.Problems[index];
        }
        else
        {
            return null;
        }
    }

    private void Start()
    {
        this.Preprocess();
        this.LoadStudyBook();
        this.LoadSyncs();

        this.m_Audio.clip = this.m_Clips[this.m_MusicIndex];
        this.m_Audio.Play();
        this.m_ClipRuntime = this.m_Clips[this.m_MusicIndex].length;
    }

    private void Update()
    {
        this.m_Timer += Time.deltaTime;
        if(this.m_Timer >= this.m_ClipRuntime)
        {
            this.m_GameManager.OpenResultPanel();
        }
    }

    private void Preprocess()
    {
        this.m_Mode = PlayerPrefs.GetString("Mode", "수학");
        this.m_MusicIndex = PlayerPrefs.GetInt("MusicIndex", 0);
        string difficulty = PlayerPrefs.GetString("Difficulty", "쉬움");
        switch(difficulty)
        {
            case "쉬움":
                this.m_Difficulty = 0;
                break;

            case "보통":
                this.m_Difficulty = 1;
                break;

            case "어려움":
                this.m_Difficulty = 2;
                break;

            default:
                throw new System.Exception("invalid difficulty");
        }
    }

    private void LoadStudyBook()
    {
        string questions = string.Empty;
        switch(this.m_Mode)
        {
            case "수학":
                questions = this.m_MathQuestions[this.m_Difficulty].text;
                this.m_StudyBook = JsonUtility.FromJson<StudyBook>(questions);
                break;

            case "영어":
                questions = this.m_EnglishQuestions[this.m_Difficulty].text;
                this.m_StudyBook = JsonUtility.FromJson<StudyBook>(questions);
                break;

            default:
                throw new System.Exception("invalid mode");
        }
    }

    private void LoadSyncs()
    {
        List<string> syncs = new List<string>(this.m_Syncs[this.m_MusicIndex].text.Split('\n'));
        foreach(string s in syncs)
        {
            float timeToArrive = 6.5f;
            this.m_SpawnTimes.Add(float.Parse(s) - timeToArrive);
        }
    }
}
