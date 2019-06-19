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
    }

    public void SelectDifficulty(string _level)
    {
        this.m_Difficulty = _level;
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
    } 
}
