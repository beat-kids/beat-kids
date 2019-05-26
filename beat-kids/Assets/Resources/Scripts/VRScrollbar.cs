﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class VRScrollbar : MonoBehaviour
{
    public Scrollbar mScrollbar = null;
    public UnityEvent mEvent = null;

    private bool mIsGazed = false;

    public void PointEnter()
    {
        this.TimeToActAsync();
    }

    public void PointExit()
    {
        this.mScrollbar.size = 0;
        this.mIsGazed = false;
    }

    private async void TimeToActAsync()
    {
        this.mIsGazed = true;

        for(float value = 0.0f; value < 1.0f; value += 0.05f)
        {
            if (this.mIsGazed == false)
            {
                this.mScrollbar.size = 0.0f;
                return;
            }
            else
            {
                this.mScrollbar.size = value;
                await Task.Delay((int)(Time.fixedDeltaTime * 1000));
            }
        }

        this.mScrollbar.size = 1.0f;

        if (this.mEvent != null)
        {
            this.mEvent.Invoke();
        }
    }
}
