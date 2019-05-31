using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Object m_ObjectNote = null;
    public Scrollbar m_HealthPoint = null;
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

    private void Awake()
    {
        this.m_ObjectNote = Resources.Load("Prefab/Note");
        this.m_Canvas = GameObject.Find("Canvas");
        this.m_Random = new System.Random();
    }
}
