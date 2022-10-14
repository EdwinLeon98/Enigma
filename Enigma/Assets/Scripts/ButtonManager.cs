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
        else if (SceneManager.GetActiveScene().name == "Level5") {
            levelNumber = 5;
        }
        else if (SceneManager.GetActiveScene().name == "Level6") {
            levelNumber = 6;
        }
        else if (SceneManager.GetActiveScene().name == "Level7") {
            levelNumber = 7;
        }
        else if (SceneManager.GetActiveScene().name == "Level8") {
            levelNumber = 8;
        }
        else if (SceneManager.GetActiveScene().name == "Level9") {
            levelNumber = 9;
        }
        else if (SceneManager.GetActiveScene().name == "Level10") {
            levelNumber = 10;
        }
        else if (SceneManager.GetActiveScene().name == "Level11") {
            levelNumber = 11;
        }
        else {
            levelNumber = 0;
        }
        Metrics.levelNum = levelNumber;
    }

    public void ButtonMoveScene(string level) {
        // Set the level name
        Metrics.level = level;

        // When a new level is selected turn off the gameEnded Flag.
        // This will enable sending the data to server once the selected level
        // has ended
        // Metrics.gameEnded = false;
        // Metrics.star_rating = 0;
        Metrics.ResetMetrics();

        if(Application.platform == RuntimePlatform.WebGLPlayer){
            Metrics.collectAnalytics = true;
        }
        else {
            Debug.Log("Not a WebGL build");
            Metrics.collectAnalytics = false;
        }

        PauseGame.unpause = true;
        SceneManager.LoadScene(level);
    }
}
