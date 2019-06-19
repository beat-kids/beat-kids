using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class SelectMusicManager : MonoBehaviour
{
    public Text m_MusicIndexText = null;
    public Text m_DifficultyText = null;
    public Text m_RuntimeText = null;
    public Text m_ScoreText = null;
    public Text m_ModeText = null;
    public ButtonClick[] m_ItemButton = null;
    public Text[] m_ItemButtonText = null;
    public Text[] m_ItemNameText = null;
    public AudioClip[] m_Clips = null;

    private string m_Mode = string.Empty;
    private int m_MusicIndex = -1;
    private string m_Difficulty = string.Empty;
    private float m_Runtime = 0.0f;
    private int m_Score = 0;
    private int[] m_ItemIndex = null;

    public void CallSelectModeScene()
    {
        SceneManager.LoadScene("SelectMode");
    }

    public void CallGameScene()
    {
        if(this.m_MusicIndex == -1)
        {
            return;
        }
        if(this.m_Difficulty.Length == 0)
        {
            return;
        }

        SceneManager.LoadScene("Game");
    }

    public void SelectMusic(int _index)
    {
        this.m_MusicIndex = _index;
        this.m_Difficulty = string.Empty;
        this.m_Runtime = 0.0f;
        this.m_Score = -1;
    }

    public void SelectDifficulty(string _level)
    {
        this.m_Difficulty = _level;
        this.m_Runtime = 0.0f;
        this.m_Score = -1;
    }

    public void MusicScrollUp()
    {
        if (this.m_ItemIndex[0] > 0)
        {
            for (int i = 0; i < this.m_ItemIndex.Length; ++i)
            {
                this.m_ItemIndex[i] -= 1;
                this.m_ItemButton[i].m_Event.RemoveAllListeners();
                int val = this.m_ItemIndex[i];
                this.m_ItemButton[i].m_Event.AddListener(() => this.SelectMusic(val));
            }
        }
    }

    public void MusicScrollDown()
    {
        if (this.m_ItemIndex[this.m_ItemIndex.Length - 1] < (this.m_Clips.Length - 1))
        {
            for (int i = 0; i < this.m_ItemIndex.Length; ++i)
            {
                this.m_ItemIndex[i] += 1;
                this.m_ItemButton[i].m_Event.RemoveAllListeners();
                int val = this.m_ItemIndex[i];
                this.m_ItemButton[i].m_Event.AddListener(() => this.SelectMusic(val));
            }
        }
    }

    private void Start()
    {
        this.m_Mode = PlayerPrefs.GetString("Mode");
        this.m_ModeText.text = this.m_Mode;
        this.m_ItemIndex = new int[this.m_ItemButton.Length];
        for(int i = 0; i < this.m_ItemIndex.Length; ++i)
        {
            this.m_ItemIndex[i] = i;
            if (this.m_ItemButton[i].m_Event == null)
            {
                this.m_ItemButton[i].m_Event = new UnityEvent();
            }
            this.m_ItemButton[i].m_Event.RemoveAllListeners();
            int val = this.m_ItemIndex[i];
            this.m_ItemButton[i].m_Event.AddListener(() => this.SelectMusic(val));
        }
    }

    private void Update()
    {
        this.UpdateUI();
        this.UpdateMusic();
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("MusicIndex", this.m_MusicIndex);
        PlayerPrefs.SetString("Difficulty", this.m_Difficulty);
    }

    private void UpdateUI()
    {
        if (this.m_MusicIndex != -1)
        {
            this.m_MusicIndexText.text = (this.m_MusicIndex + 1).ToString() + "번";
            this.m_Runtime = this.m_Clips[this.m_MusicIndex].length;
        }
        else
        {
            this.m_MusicIndexText.text = "?";
            this.m_Runtime = 0.0f;
        }

        if(this.m_Difficulty.Length > 0)
        {
            this.m_DifficultyText.text = this.m_Difficulty;
            string key = this.m_Mode + "." + this.m_MusicIndex.ToString() + "." + this.m_Difficulty;
            this.m_Score = PlayerPrefs.GetInt(key, -1);
        }
        else
        {
            this.m_DifficultyText.text = "?";
        }

        if(this.m_Runtime > 0.0f)
        {
            int minutes = (int)this.m_Runtime / 60;
            int seconds = (int)this.m_Runtime % 60;
            this.m_RuntimeText.text = minutes.ToString() + "분" + seconds.ToString() + "초";
        }
        else
        {
            this.m_RuntimeText.text = "?";
        }

        if(this.m_Score > -1)
        {
            this.m_ScoreText.text = this.m_Score.ToString();
        }
        else
        {
            this.m_ScoreText.text = "?";
        }
    }

    private void UpdateMusic()
    {
        for (int i = 0; i < this.m_ItemButtonText.Length; ++i)
        {
            this.m_ItemButtonText[i].text = (this.m_ItemIndex[i] + 1).ToString();
            this.m_ItemNameText[i].text = this.m_Clips[this.m_ItemIndex[i]].name;
        }
    }
}
