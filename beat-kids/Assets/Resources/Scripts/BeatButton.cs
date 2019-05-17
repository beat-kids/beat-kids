using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class BeatButton : MonoBehaviour
{
    public Sprite mSpriteNormal = null;
    public Sprite mSpritePressed = null;
    public UnityEvent mFunction = null;

    private SpriteRenderer mSpriteRenderer = null;

    public void PointEnter()
    {
        this.mFunction.Invoke();

        this.ChangeSpriteAsync();
    }

    private void Awake()
    {
        this.mSpriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    private async void ChangeSpriteAsync()
    {
        this.mSpriteRenderer.sprite = this.mSpritePressed;

        await Task.Delay(500);

        this.mSpriteRenderer.sprite = this.mSpriteNormal;
    }
}
