using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeatNote : MonoBehaviour
{
    public BeatLaneUI m_Lane = null;

    private Text m_Display = null;

    public string Data
    {
        get;
        set;
    }

    public float Speed
    {
        get;
        set;
    }

    private void Awake()
    {
        this.m_Display = this.GetComponentInChildren<Text>();
    }

    private void Update()
    {
        this.m_Display.text = this.Data;

        Vector3 position = this.transform.position;
        if((Mathf.Abs(position.x - 0.0f) <= 50.0f) && (Mathf.Abs(position.y - 0.0f) <= 50.0f))
        {
            this.m_Lane.PopNote(this);
        }
    }
}
