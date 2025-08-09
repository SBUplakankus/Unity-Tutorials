using PrimeTween;
using UnityEngine;
using UnityEngine.UI;

public class FadeToBlack : MonoBehaviour
{
    private const float FadeDuration = 2.5f;
    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    public void FadeImage(float fadeValue)
    {
        Tween.Alpha(_image, fadeValue, FadeDuration);
    }

    public void HandleFadeOut()
    {
        FadeImage(0f);
    }
}
