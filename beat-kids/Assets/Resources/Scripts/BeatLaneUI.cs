using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeatLaneUI : MonoBehaviour
{
    public float m_RotateAngle = 0.0f;
    public ParticleSystem effect = null;
    public GameManager m_GameManager = null;

    private Text m_FirstNoteData = null;
    private BeatButtonUI m_Button = null;
    private List<BeatNote> m_Notes = null;
    private BeatLaneUI[] m_Lanes = null;

    public void PushNote(BeatNote _bn, float _offset)
    {
        Vector3 positionOrigin = this.m_Button.transform.position;
        Vector3 offset = new Vector3(0.0f, -1.0f * _offset, 0.0f);
        Vector3 positionTarget = positionOrigin + Quaternion.AngleAxis(this.m_RotateAngle, Vector3.forward) * offset;
        _bn.transform.position = positionTarget;
        _bn.transform.SetParent(this.transform);
        _bn.m_Lane = this;
        _bn.m_GameManager = this.m_GameManager;

        this.m_Notes.Add(_bn);
    }

    public void PopFirstNotes()
    {
        if(this.m_Notes.Count > 0)
        {
            foreach(BeatLaneUI lane in this.m_Lanes)
            {
                BeatNote bn = lane.m_Notes[0];
                lane.m_Notes.Remove(bn);
                effect.Play();
                Destroy(bn.gameObject);
            }
        }
    }

    public void PopNote(BeatNote _bn)
    {
        if (this.m_Notes.Count > 0)
        {
            this.m_Notes.Remove(_bn);
            Destroy(_bn.gameObject);
        }
    }

    public float GetDistanceToFirst()
    {
        if(this.m_Notes.Count > 0)
        {
            return Vector3.Distance(this.m_Notes[0].transform.position, this.transform.position);
        }
        else
        {
            return float.MaxValue;
        }
    }

    private void Awake()
    {
        this.m_FirstNoteData = this.GetComponentInChildren<Text>();
        this.m_Button = this.GetComponentInChildren<BeatButtonUI>();
        this.m_Notes = new List<BeatNote>();
        this.m_Lanes = FindObjectsOfType<BeatLaneUI>();
    }

    private void Update()
    {
        if (this.m_Notes.Count > 0)
        {
            this.m_FirstNoteData.text = this.m_Notes[0].Data;
        }
        else
        {
            this.m_FirstNoteData.text = string.Empty;
        }

        Vector3 direction = Quaternion.AngleAxis(this.m_RotateAngle, Vector3.forward) * Vector3.up;
        foreach (BeatNote bn in this.m_Notes)
        {
            Vector3 positionOrigin = bn.transform.position;
            Vector3 positionTarget = bn.transform.position + direction * bn.Speed;
            Vector3 positionInter = Vector3.Lerp(positionOrigin, positionTarget, 0.5f * Time.deltaTime);
            bn.transform.position = positionInter;
        }
    }
}
