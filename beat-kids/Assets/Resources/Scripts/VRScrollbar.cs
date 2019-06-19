using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class VRScrollbar : MonoBehaviour
{
    public Scrollbar m_Scrollbar = null;
    public UnityEvent m_Event = null;

    private bool m_IsGazed = false;

    public void PointEnter()
    {
        this.TimeToActAsync();
    }

    public void PointExit()
    {
        this.m_Scrollbar.size = 0;
        this.m_IsGazed = false;
    }

    private async void TimeToActAsync()
    {
        this.m_IsGazed = true;

        for(float value = 0.0f; value < 1.0f; value += 0.05f)
        {
            if (this.m_IsGazed == false)
            {
                this.m_Scrollbar.size = 0.0f;
                return;
            }
            else
            {
                this.m_Scrollbar.size = value;
                await Task.Delay((int)(Time.fixedDeltaTime * 1000));
            }
        }

        this.m_Scrollbar.size = 1.0f;

        if (this.m_Event != null)
        {
            this.m_Event.Invoke();
        }
    }
}
