using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MapSelect
{
    public class TimeLimitProcessor : MonoBehaviour
    {
        [Header("Data")]
        public float timeLimitSecond;

        [Header("Objects")]
        public SliderMerger slider;
        public TextMeshProUGUI timeText;
        
        private void Start()
        {
            StartCoroutine(TimeUpdateFlow(timeLimitSecond));
        }

        private IEnumerator TimeUpdateFlow(float time)
        {
            var elapsedTime = time;
            while (elapsedTime > 0)
            {
                elapsedTime -= Time.deltaTime;
                slider.value = elapsedTime / time;
                timeText.text = $"{Mathf.Ceil(slider.value * time)}";
                yield return null;
            }
            // 선택되지 않았다면 현재 커서에 위치한 맵 선택
            if (!MapSelector.IsSelected) MapSelector.Instance.Select();
            // 추후 서버로 선택한 맵 전송하는 코드 제작 (현재는 다음 씬 바로 시작하기)
            Debug.Log($"Selected Map : {MapSelector.SelectedMapData.id}");
            SceneManager.LoadScene("PlayerDummyTest");
        }
    }
}
