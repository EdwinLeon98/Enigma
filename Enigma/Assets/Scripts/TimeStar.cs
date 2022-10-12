using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeStar : MonoBehaviour
{
    float Time;
    public int minTimeInSecs;
    public static bool[] gotTimeStar = new bool[10];

    // Update is called once per frame
    void Update() {
        Time = TimerCounter.mins * 60;
        Time += TimerCounter.secs * 10;
        Time += TimerCounter.timer;

        if (Time < minTimeInSecs) {
            gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            gotTimeStar[ButtonManager.levelNumber] = true;
        }
    }
}
