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

    public void PointEnter()
    {
        this.ChangeSpriteAsync();
    }

    private void Awake()
    {
        this.mImage = this.GetComponent<Image>();
    }

    private async void ChangeSpriteAsync()
    {
        this.mImage.sprite = this.mSpritePressed;

        await Task.Delay(500);

        this.mImage.sprite = this.mSpriteNormal;
    }
}
