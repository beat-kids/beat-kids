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

    private GameManager m_GameManager = null;
    private NoteManager m_NoteManager = null;
    private float m_Size = float.NaN;
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
        this.m_GameManager = this.m_Lane.m_GameManager;
        this.m_NoteManager = this.m_GameManager.m_NoteManager;
    }

    private void Start()
    {
        RectTransform rectTransform = this.GetComponent<RectTransform>();
        this.m_Size = rectTransform.rect.width;
        if (float.IsNaN(BeatNote.g_DistanceLimitToCenter))
        {
            BeatNote.g_DistanceLimitToCenter = (Mathf.Abs(rectTransform.position.x) + Mathf.Abs(rectTransform.position.y)) - (this.m_Size / 2.0f);
        }
    }

    private async void ChangeSpriteAsync()
    {
        this.m_Image.sprite = this.m_SpritePressed;

        await Task.Delay(150);

        this.m_Image.sprite = this.m_SpriteNormal;
    }

    private void CheckNote()
    {
        float distance = this.m_Lane.GetDistanceToFirst();

        if(distance <= (this.m_Size / 2.0f))
        {
            BeatNote bn = this.m_Lane.GetFirstNote();
            this.m_NoteManager.PopFront(bn.Data);
        }
    }
}
