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
           else if (SceneManager.GetActiveScene().name == "Blackhole_Level2") {
            levelNumber = 19;
        }
           else if (SceneManager.GetActiveScene().name == "Blackhole_Level3") {
            levelNumber = 20;
        }
           else if (SceneManager.GetActiveScene().name == "Blackhole_Level4") {
            levelNumber = 21;
        }
           else if (SceneManager.GetActiveScene().name == "Tracking_Level1") {
            levelNumber = 22;
        }
           else if (SceneManager.GetActiveScene().name == "Tracking_Level2") {
            levelNumber = 23;
        }
           else if (SceneManager.GetActiveScene().name == "Tracking_Level3") {
            levelNumber = 24;
        }
        else if (SceneManager.GetActiveScene().name == "Key&Door_Level1") {
            levelNumber = 25;
        }
                   else if (SceneManager.GetActiveScene().name == "Dark_Level1") {
            levelNumber = 26;
        }
                   else if (SceneManager.GetActiveScene().name == "Dark_Level2") {
            levelNumber = 27;
        }
                   else if (SceneManager.GetActiveScene().name == "Dark_Level3") {
            levelNumber = 28;
        }
                   else if (SceneManager.GetActiveScene().name == "Compatibility_Level1") {
            levelNumber = 29;
        }
                   else if (SceneManager.GetActiveScene().name == "Compatibility_Level2") {
            levelNumber = 30;
        }
                   else if (SceneManager.GetActiveScene().name == "Compatibility_Level3") {
            levelNumber = 31;
        }
                   else if (SceneManager.GetActiveScene().name == "Refraction_Level1") {
            levelNumber = 32;
        }
                   else if (SceneManager.GetActiveScene().name == "Refraction_Level2") {
            levelNumber = 33;
        }
                   else if (SceneManager.GetActiveScene().name == "Refraction_Level3") {
            levelNumber = 34;
        }
                   else if (SceneManager.GetActiveScene().name == "Oscillator_Level1") {
            levelNumber = 35;
        }
                   else if (SceneManager.GetActiveScene().name == "Oscillator_Level2") {
            levelNumber = 36;
        }
                   else if (SceneManager.GetActiveScene().name == "Oscillator_Level3") {
            levelNumber = 37;
        }
                   else if (SceneManager.GetActiveScene().name == "Stopper_Level1") {
            levelNumber = 38;
        }
                   else if (SceneManager.GetActiveScene().name == "Stopper_Level2") {
            levelNumber = 39;
        }
        else if (SceneManager.GetActiveScene().name == "Stopper_Level3") {
            levelNumber = 40;
        }
         else if (SceneManager.GetActiveScene().name == "Key&Door_Level2") {
            levelNumber = 41;
        }
                else if (SceneManager.GetActiveScene().name == "Key&Door_Level3") {
            levelNumber = 42;
        }
                else if (SceneManager.GetActiveScene().name == "Oscillator_Level4") {
            levelNumber = 43;
        }
        else if (SceneManager.GetActiveScene().name == "Compatibility_Level4") {
            levelNumber = 44;
        }
                else if (SceneManager.GetActiveScene().name == "Key&Door_Level4") {
            levelNumber = 45;
        }
        else if (SceneManager.GetActiveScene().name == "Stopper_Level4") {
            levelNumber = 46;
        }
               else if (SceneManager.GetActiveScene().name == "Refraction_Level4") {
            levelNumber = 47;
        }
         else if (SceneManager.GetActiveScene().name == "Dark_Level4") {
            levelNumber = 48;
        }
         else if (SceneManager.GetActiveScene().name == "Conveyor_Level1") {
            levelNumber = 49;
        }
         else if (SceneManager.GetActiveScene().name == "Conveyor_Level2") {
            levelNumber = 50;
        }
         else if (SceneManager.GetActiveScene().name == "Conveyor_Level3") {
            levelNumber = 51;
        }
         else if (SceneManager.GetActiveScene().name == "Conveyor_Level4") {
            levelNumber = 52;
        }    
         else if (SceneManager.GetActiveScene().name == "Portals_Level4") {
            levelNumber = 53;
        }
         else if (SceneManager.GetActiveScene().name == "Portals_Level5") {
            levelNumber = 54;
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
        Time.timeScale = 1;
        SceneManager.LoadScene(level);
    }

    public void quitGame() {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
