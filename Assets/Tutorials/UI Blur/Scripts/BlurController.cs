using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace Tutorials.UI_Blur.Scripts
{
    public class BlurController : MonoBehaviour
    {
        private Volume _blurVolume;
        private bool _blurActive;

        private void Start()
        {
            _blurVolume = GetComponent<Volume>();
            _blurActive = false;
            _blurVolume.weight = 0;
        }

        public void ToggleBlur()
        {
            _blurActive = !_blurActive;
            _blurVolume.weight = _blurActive ? 1 : 0;
        }
        
    }
}
