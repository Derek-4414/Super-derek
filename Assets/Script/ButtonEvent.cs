using UnityEngine;
using System.Collections;

public class ButtonEvent : MonoBehaviour
{
    public GameObject tipsPanel; // 玩法介绍界面
    private CanvasGroup tipsCanvasGroup;

    private void Start()
    {
        tipsCanvasGroup = tipsPanel.GetComponent<CanvasGroup>();
        tipsPanel.SetActive(false);
    }

    // 玩法介绍按钮
    public void OnTipButtonClick()
    {
        tipsPanel.SetActive(true);
        StartCoroutine(FadeIn(tipsCanvasGroup, 0.5f)); // 0.5秒淡入
    }

    public void OnCloseButtonClick()
    {
        StartCoroutine(FadeOut(tipsCanvasGroup, 0.5f)); // 0.5秒淡出
    }

    // 动画
    IEnumerator FadeIn(CanvasGroup canvasGroup, float duration)
    {
        float time = 0;
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;

        while (time < duration)
        {
            time += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(0, 1, time / duration);
            yield return null;
        }

        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }

    // 淡出动画
    IEnumerator FadeOut(CanvasGroup canvasGroup, float duration)
    {
        float time = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;

        while (time < duration)
        {
            time += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(1, 0, time / duration);
            yield return null;
        }

        canvasGroup.alpha = 0;
        tipsPanel.SetActive(false); 
    }
}
