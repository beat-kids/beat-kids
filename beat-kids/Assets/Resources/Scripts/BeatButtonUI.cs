using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class BeatButtonUI : MonoBehaviour
{
    public Sprite m_SpriteNormal = null;
    public Sprite m_SpritePressed = null;

    private Image m_Image = null;
    private BeatLaneUI m_Lane = null;

    public void PointEnter()
    {
        this.ChangeSpriteAsync();
        this.CheckNote();
    }

    private void Awake()
    {
        this.m_Image = this.GetComponent<Image>();
        this.m_Lane = this.transform.parent.GetComponent<BeatLaneUI>();
    }

    private async void ChangeSpriteAsync()
    {
        this.m_Image.sprite = this.m_SpritePressed;

        await Task.Delay(100);

        this.m_Image.sprite = this.m_SpriteNormal;
    }

    private void CheckNote()
    {
        float distance = this.m_Lane.GetDistanceToFirst();

        if(distance <= 25.0f)
        {
            this.m_Lane.PopNote();
        }
    }
}
