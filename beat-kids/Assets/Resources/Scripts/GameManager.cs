using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Object m_ObjectNote = null;
    public Text m_HPText = null;
    public Text m_ScoreText = null;
    public Text m_ComboText = null;
    public int m_Damage = 10;
    public BeatLaneUI[] m_Lanes = null;
    public GameObject m_MenuPanel = null;

    private GameObject m_Canvas = null;
    private System.Random m_Random = null;
    private int m_HPValue = 100;
    private int m_ScoreValue = 0;
    private int m_ComboValue = 0;
    private int m_CountDamage = 0;

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
        this.ClearCombo();

        this.m_CountDamage += 1;
        if (this.m_CountDamage == this.m_Lanes.Length)
        {
            this.m_CountDamage = 0;
            this.m_HPValue -= this.m_Damage;
            if (this.m_HPValue <= 0)
            {
                this.GameOver();
            }
            else
            {
                this.m_HPText.text = this.m_HPValue.ToString();
            }
        }
    }

    public void GetScore()
    {
        this.m_ScoreValue += 100;
        this.m_ScoreText.text = this.m_ScoreValue.ToString();
    }

    public void AddCombo()
    {
        this.m_ComboValue += 1;
        this.m_ComboText.text = this.m_ComboValue.ToString();
    }

    public void OpenMenu()
    {
        this.m_MenuPanel.SetActive(true);
        Time.timeScale = 0.0f;
    }

    public void CloseMenu()
    {
        this.m_MenuPanel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    private void Awake()
    {
        this.m_ObjectNote = Resources.Load("Prefab/Note");
        this.m_Canvas = GameObject.Find("Canvas");
        this.m_Random = new System.Random();
    }

    private void Start()
    {
        this.m_HPText.text = this.m_HPValue.ToString();
        this.m_ScoreText.text = this.m_ScoreValue.ToString();
        this.m_ComboText.text = this.m_ComboValue.ToString();
    }

    private void ClearCombo()
    {
        this.m_ComboValue = 0;
        this.m_ComboText.text = this.m_ComboValue.ToString();
    }
}
