using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeatNote : MonoBehaviour
{
    static public float g_DistanceLimitToCenter = float.NaN;

    public BeatLaneUI m_Lane = null;
    public GameManager m_GameManager = null;

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
        if ((Mathf.Abs(position.x - 0.0f) <= g_DistanceLimitToCenter) &&
            (Mathf.Abs(position.y - 0.0f) <= g_DistanceLimitToCenter))
        {
            this.m_Lane.PopNote(this);
            this.m_GameManager.LoseHP();
        }
    }
}
