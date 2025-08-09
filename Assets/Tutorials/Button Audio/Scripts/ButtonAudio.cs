using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAudio : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler
{
    public AudioClip hoverAudio, clickAudio;

    public void OnPointerDown(PointerEventData eventData)
    {
        AudioController.Instance.PlayAudioClip(clickAudio, 1, 1);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        AudioController.Instance.PlayAudioClip(hoverAudio, 0.7f, 1);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        AudioController.Instance.PlayAudioClip(clickAudio, 0.5f, 0.8f);
    }
}
