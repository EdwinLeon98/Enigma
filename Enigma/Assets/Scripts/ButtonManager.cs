using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Text.RegularExpressions;

public class ButtonManager : MonoBehaviour
{

    public void ButtonMoveScene(string level) {
        MovePrototype2.numberOfMoves = 0;
        TimerCounter.mins = 0;
        TimerCounter.secs = 0;
        TimerCounter.timer = 0;
        String temp = level;

        // Extract the level number from the level string.
        // The format of level variable is: "Level1", "Level2"
        Metrics.level = Regex.Match(temp, @"\d+").Value;
        // Debug.Log("Level: " + Metrics.level);

        // When a new level is selected turn off the gameEnded Flag.
        // This will enable sending the data to server once the selected level
        // has ended
        Metrics.gameEnded = false;

        if(Application.platform == RuntimePlatform.WebGLPlayer){
            Metrics.collectAnalytics = true;
        }
        else {
            // Debug.Log("Not a WebGL build");
            Metrics.collectAnalytics = false;
        }

        SceneManager.LoadScene(level);
    }
}
