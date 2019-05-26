using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Object mObjectNote = null;
    public Scrollbar mHP = null;
    public BeatLaneUI[] mLanes = null;

    private GameObject mCanvas = null;
    private System.Random mRandom = null;

    public void SpawnNotes()
    {
        foreach(BeatLaneUI bls in this.mLanes)
        {
            BeatNote bn = (Instantiate(this.mObjectNote, this.mCanvas.transform) as GameObject).GetComponent<BeatNote>();
            bn.Data = this.mRandom.Next(1, 10).ToString();
            bn.Speed = 45.0f;
            bls.PushNote(bn, 150.0f);
        }
    }

    private void Awake()
    {
        this.mObjectNote = Resources.Load("Prefab/Note");
        this.mCanvas = GameObject.Find("Canvas");
        this.mRandom = new System.Random();
    }
}
