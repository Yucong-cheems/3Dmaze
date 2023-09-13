using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public Text timerText; // 在Unity编辑器中，将倒计时要显示的Text组件拖入这里
    public float startTime; // 在Unity编辑器中，你可以设置这个倒计时的开始时间（秒）

    private float timeRemaining;
    private bool timerActive;

    public GameObject panel;

    void Start()
    {
        timeRemaining = startTime;
        timerActive = true;
        UpdateTimerText();
    }

    void Update()
    {
        if (timerActive)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimerText();
            }
            else
            {
                timerActive = false;
                GameOver();
            }
        }
    }

    void UpdateTimerText()
    {
        int minutes = (int)(timeRemaining / 60);
        int seconds = (int)(timeRemaining % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void GameOver()
    {
        panel.SetActive(true);
    }
}
