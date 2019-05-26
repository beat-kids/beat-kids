using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeatLaneUI : MonoBehaviour
{
    public float mRotateAngle = 0.0f;

    private Text mFirstNoteData = null;
    private BeatButtonUI mButton = null;
    private List<BeatNote> mNotes = null;

    public void PushNote(BeatNote _bn, float _offset)
    {
        Vector3 positionOrigin = this.mButton.transform.position;
        Vector3 offset = new Vector3(0.0f, -1.0f * _offset, 0.0f);
        Vector3 positionTarget = positionOrigin + Quaternion.AngleAxis(this.mRotateAngle, Vector3.forward) * offset;
        _bn.transform.position = positionTarget;
        _bn.mLane = this;

        this.mNotes.Add(_bn);
    }

    public void PopNote()
    {
        if(this.mNotes.Count > 0)
        {
            BeatNote bn = this.mNotes[0];
            this.mNotes.Remove(bn);
            Destroy(bn.gameObject);
        }
    }

    public void PopNote(BeatNote _bn)
    {
        if (this.mNotes.Count > 0)
        {
            this.mNotes.Remove(_bn);
            Destroy(_bn.gameObject);
        }
    }

    public float GetDistanceToFirst()
    {
        if(this.mNotes.Count > 0)
        {
            return Vector3.Distance(this.mNotes[0].transform.position, this.transform.position);
        }
        else
        {
            return float.MaxValue;
        }
    }

    private void Awake()
    {
        this.mFirstNoteData = this.GetComponentInChildren<Text>();
        this.mButton = this.GetComponentInChildren<BeatButtonUI>();
        this.mNotes = new List<BeatNote>();
    }

    private void Update()
    {
        if (this.mNotes.Count > 0)
        {
            this.mFirstNoteData.text = this.mNotes[0].Data;
        }
        else
        {
            this.mFirstNoteData.text = string.Empty;
        }

        Vector3 direction = Quaternion.AngleAxis(this.mRotateAngle, Vector3.forward) * Vector3.up;
        foreach (BeatNote bn in this.mNotes)
        {
            Vector3 positionOrigin = bn.transform.position;
            Vector3 positionTarget = bn.transform.position + direction * bn.Speed;
            Vector3 positionInter = Vector3.Lerp(positionOrigin, positionTarget, 0.5f * Time.deltaTime);
            bn.transform.position = positionInter;
        }
    }
}
