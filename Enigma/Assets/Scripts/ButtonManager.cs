using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Text.RegularExpressions;

public class ButtonManager : MonoBehaviour
{
    public static int levelNumber;
    
    void Start() {
        MovePrototype2.numberOfMoves = 0;
        TimerCounter.mins = 0;
        TimerCounter.secs = 0;
        TimerCounter.timer = 0;

        Debug.Log("Scene name: " + SceneManager.GetActiveScene().name);
        if (SceneManager.GetActiveScene().name == "Level1") {
            levelNumber = 1;
        }
        else if (SceneManager.GetActiveScene().name == "Level2") {
            levelNumber = 2;
        }
        else if (SceneManager.GetActiveScene().name == "Level3") {
            levelNumber = 3;
        }
        else if (SceneManager.GetActiveScene().name == "Level4") {
            levelNumber = 4;
        }
        else {
            levelNumber = 0;
        }
    }

    public void ButtonMoveScene(string level) {
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
        SceneManager.LoadScene(level);
    }
}
