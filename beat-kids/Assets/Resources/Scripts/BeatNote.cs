using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeatNote : MonoBehaviour
{
    public BeatLaneUI mLane = null;

    private Text mDisplay = null;

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
        this.mDisplay = this.GetComponentInChildren<Text>();
    }

    private void Update()
    {
        this.mDisplay.text = this.Data;

        Vector3 position = this.transform.position;
        if((Mathf.Abs(position.x - 0.0f) <= 50.0f) && (Mathf.Abs(position.y - 0.0f) <= 50.0f))
        {
            this.mLane.PopNote(this);
        }
    }
}
