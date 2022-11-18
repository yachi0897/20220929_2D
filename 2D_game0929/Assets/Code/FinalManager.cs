using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
namespace Fox
{
    /// <summary>
    /// 結束管理器
    /// </summary>
    public class FinalManager : MonoBehaviour
    {
        public static FinalManager instance;

        /// <summary>
        /// 結束畫布
        /// </summary>
        private CanvasGroup groupFinal;

        /// <summary>
        /// 結束標題
        /// </summary>
        private TextMeshProUGUI textTitle;
        /// <summary>
        /// 重新遊戲
        /// </summary>
        private Button btnReplay;
        
        private void Awake()
        {
            instance = this;

            groupFinal=GameObject.Find("結束畫布").GetComponent<CanvasGroup>();
            textTitle = GameObject.Find("結束標題").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("重新遊戲").GetComponent<Button>();
        }
        /// <summary>
        /// 遊戲結束
        /// </summary>
        /// <param name="遊戲標題"></param>
        
        public void GameOver (string title)
        {
            textTitle.text = title;
            StartCoroutine(FadeIn());
        }

        /// <summary>
        /// 淡入
        /// </summary>
        
        private IEnumerator FadeIn()
        {
            for (int i = 0; i < 10; i++)
            {
                groupFinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.02f);
            }
            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;
        }
    }
}

