using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaveUIManager : MonoBehaviour
{
    public TextMeshProUGUI waveTitleText;
    public TextMeshProUGUI countdownText;
    public TextMeshProUGUI waveCompleteText;

    public float fadeDuration = 1f;
    void Start()
    {
        waveTitleText.gameObject.SetActive(false);
        countdownText.gameObject.SetActive(false);
        waveCompleteText.gameObject.SetActive(false);
    }

    public IEnumerator ShowWaveStart(string waveName)
    {
        waveTitleText.text = waveName;
        yield return StartCoroutine(FadeText(waveTitleText, true));
        yield return new WaitForSeconds(1f);
        yield return StartCoroutine(FadeText(waveTitleText, false));

        countdownText.gameObject.SetActive(true);
        for (int i = 3; i >= 1; i--)
        {
            countdownText.text = i.ToString();
            yield return new WaitForSeconds(0.8f);
        }
        countdownText.text = "GO!";
        yield return new WaitForSeconds(1f);
        countdownText.gameObject.SetActive(false);
    }

    public IEnumerator ShowWaveComplete()
    {
        waveCompleteText.gameObject.SetActive(true);
        yield return StartCoroutine(FadeText(waveCompleteText, true));
        yield return new WaitForSeconds(1.5f);
        yield return StartCoroutine(FadeText(waveCompleteText, false));
        waveCompleteText.gameObject.SetActive(false);
    }
    private IEnumerator FadeText(TextMeshProUGUI text, bool fadeIn)
    {
        text.gameObject.SetActive(true);
        Color color = text.color;
        float targetAlpha = fadeIn ? 1f : 0f;
        float startAlpha = fadeIn ? 0f : 1f;

        float time = 0f;
        while (time < fadeDuration)
        {
            float alpha = Mathf.Lerp(startAlpha, targetAlpha, time / fadeDuration);
            text.alpha = alpha;
            time += Time.deltaTime;
            yield return null;
        }
        
        text.color = new Color(color.r, color.g, color.b, targetAlpha);
        if (!fadeIn)
            text.gameObject.SetActive(false);
    }
}
