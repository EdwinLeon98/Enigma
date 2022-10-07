using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Text.RegularExpressions;

public class ButtonManager : MonoBehaviour
{
    public static int levelNumber;

    public void ButtonMoveScene(string level) {
        MovePrototype2.numberOfMoves = 0;
        TimerCounter.mins = 0;
        TimerCounter.secs = 0;
        TimerCounter.timer = 0;

        // Set the level name
        Metrics.level = level;
        // Debug.Log("Going to Level: " + Metrics.level);

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

        PauseGame.unpause = true;
        SetLevelNumber(level);
        SceneManager.LoadScene(level);
    }

    public void SetLevelNumber(string level) {
        if(level == "Level0") {
            levelNumber = 1;
        }
        else if(level == "Level1") {
            levelNumber = 2;
        }
        else if(level == "Level2") {
            levelNumber = 3;
        }
        else if (level == "Lahari") {
            levelNumber = 4;
        }
        else {
            //levelNumber = 0;
        }
    }
}
