using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectMusicManager : MonoBehaviour
{
    public Text m_MusicIndexText = null;
    public Text m_DifficultyText = null;
    public Text m_RuntimeText = null;
    public Text m_ScoreText = null;
    public Text m_ModeText = null;

    private string m_Mode = string.Empty;
    private int m_MusicIndex = -1;
    private string m_Difficulty = string.Empty;
    private float m_Runtime = 0.0f;
    private int m_Score = 0;

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
        this.m_Score = 0;
    }

    private void Start()
    {
        this.m_Mode = PlayerPrefs.GetString("Mode");
        this.m_ModeText.text = this.m_Mode;
    }

    private void Update()
    {
        this.UpdateUI();
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
        }
        else
        {
            this.m_MusicIndexText.text = "?";
        }

        if(this.m_Difficulty.Length > 0)
        {
            this.m_DifficultyText.text = this.m_Difficulty;
        }
        else
        {
            this.m_DifficultyText.text = "?";
        }

        if(this.m_Runtime > 0.0f)
        {
            this.m_RuntimeText.text = this.m_Runtime.ToString();
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
}
