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

        if (SceneManager.GetActiveScene().name == "Basic_Level1") {
            levelNumber = 1;
        }
        else if (SceneManager.GetActiveScene().name == "Basic_Level2") {
            levelNumber = 2;
        }
        else if (SceneManager.GetActiveScene().name == "Basic_Level3") {
            levelNumber = 3;
        }
        else if (SceneManager.GetActiveScene().name == "Rotation_Level1") {
            levelNumber = 4;
        }
        else if (SceneManager.GetActiveScene().name == "Rotation_Level2") {
            levelNumber = 5;
        }
        else if (SceneManager.GetActiveScene().name == "Rotation_Level3") {
            levelNumber = 6;
        }
        else if (SceneManager.GetActiveScene().name == "Basic_Level4") {
            levelNumber = 7;
        }
        else if (SceneManager.GetActiveScene().name == "Splitter_Level1") {
            levelNumber = 8;
        }
        else if (SceneManager.GetActiveScene().name == "Splitter_Level6") {
            levelNumber = 9;
        }
        else if (SceneManager.GetActiveScene().name == "Splitter_Level2") {
            levelNumber = 10;
        }
        else if (SceneManager.GetActiveScene().name == "Splitter_Level3") {
            levelNumber = 11;
        }
        else if (SceneManager.GetActiveScene().name == "Splitter_Level4") {
            levelNumber = 12;
        }
        else if (SceneManager.GetActiveScene().name == "Splitter_Level7") {
            levelNumber = 13;
        }
        else if (SceneManager.GetActiveScene().name == "Splitter_Level5") {
            levelNumber = 14;
        }
        else if (SceneManager.GetActiveScene().name == "Portals_Level1") {
            levelNumber = 15;
        }
        else if (SceneManager.GetActiveScene().name == "Portals_Level2") {
            levelNumber = 16;
        }
        else if (SceneManager.GetActiveScene().name == "Portals_Level3") {
            levelNumber = 17;
        }
        else if (SceneManager.GetActiveScene().name == "Blackhole_Level1") {
            levelNumber = 18;
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
        Metrics.ResetMetrics();

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
