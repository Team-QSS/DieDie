using UnityEngine;
using UnityEngine.UI;

namespace Scenes.MapSelect
{
    [ExecuteAlways]
    public class SliderMerger : MonoBehaviour
    {
        public Slider[] sliders;
        [Range(0f, 1f)] public float value;
        private void Update()
        {
            foreach (var slider in sliders) if (slider) slider.value = Mathf.Lerp(slider.minValue, slider.maxValue, value);
        }
    }
}
