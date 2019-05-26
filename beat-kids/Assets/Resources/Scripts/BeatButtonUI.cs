using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class BeatButtonUI : MonoBehaviour
{
    public Sprite mSpriteNormal = null;
    public Sprite mSpritePressed = null;

    private Image mImage = null;
    private BeatLaneUI mLane = null;

    public void PointEnter()
    {
        this.ChangeSpriteAsync();
        this.CheckNote();
    }

    private void Awake()
    {
        this.mImage = this.GetComponent<Image>();
        this.mLane = this.transform.parent.GetComponent<BeatLaneUI>();
    }

    private async void ChangeSpriteAsync()
    {
        this.mImage.sprite = this.mSpritePressed;

        await Task.Delay(100);

        this.mImage.sprite = this.mSpriteNormal;
    }

    private void CheckNote()
    {
        float distance = this.mLane.GetDistanceToFirst();

        if(distance <= 25.0f)
        {
            this.mLane.PopNote();
        }
    }
}
