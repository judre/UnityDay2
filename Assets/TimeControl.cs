using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class TimeControl : MonoBehaviour
{

    public Text timerText;
    private float timeLeft = 30F;
    private float startTime;
    private float addTime = 5F;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float t = timeLeft -= Time.deltaTime;

        string minutes = ((int)t / 60).ToString("00");
        string seconds = (t % 60).ToString("00");
        string milliseconds = ((int)(t * 100f) % 100).ToString("00");

        timerText.text = minutes + ":" + seconds + ":" + milliseconds;

        if (timeLeft <= 0)
        {
            timeLeft = 0;
            timerText.text = minutes + ":" + seconds;
            SceneManager.LoadScene("CarGame");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        timeLeft += 5F;
    }

}﻿

