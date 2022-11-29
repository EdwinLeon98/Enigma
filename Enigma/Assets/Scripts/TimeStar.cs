using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeStar : MonoBehaviour
{
    float Time;
    public int minTimeInSecs;
    public static bool[] gotTimeStar = new bool[60];

    // Update is called once per frame
    void Update() {
        Time = TimerCounter.mins * 60;
        Time += TimerCounter.secs * 10;
        Time += TimerCounter.timer;

        if (Time < minTimeInSecs) {
            gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            if (!((SceneManager.GetActiveScene().name == "Tracking_Level1") || (SceneManager.GetActiveScene().name == "Tracking_Level2")
                || (SceneManager.GetActiveScene().name == "Tracking_Level3") || (SceneManager.GetActiveScene().name == "Tracking_Level4") 
                || (SceneManager.GetActiveScene().name == "Conveyor_Level1") || (SceneManager.GetActiveScene().name == "Conveyor_Level2") 
                || (SceneManager.GetActiveScene().name == "Conveyor_Level3") || (SceneManager.GetActiveScene().name == "Conveyor_Level4"))) {
                gotTimeStar[ButtonManager.levelNumber] = true;
            }
            else {
                if (gameObject.name == "Star1") {
                    gotTimeStar[ButtonManager.levelNumber] = true;
                }
                else if (gameObject.name == "Star2") {
                    MoveStar.gotMoveStar[ButtonManager.levelNumber] = true;
                }
                else if (gameObject.name == "Star3") {
                    HintStar.gotHintStar[ButtonManager.levelNumber] = true;
                }
            }
        }
    }
}
