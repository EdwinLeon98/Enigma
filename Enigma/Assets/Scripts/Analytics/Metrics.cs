using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Metrics : MonoBehaviour
{

    // This class is only used to store the metrics variables
    public static int moves = 0;
    public static bool gameEnded = false;
    public static string level;
    public static float float_minutes;
    public static bool collectAnalytics = false;
    public static int star_rating = 0;
    public static int score = 0;
    public static bool sent_data = false;
    public static int levelNum = 0;
    public static int numRetries = 1;
    public static int numHintsUsed = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void CalculateMinutes(int minutes, int seconds) {
        float_minutes = (float)minutes + (float)(seconds/60.0);
    }

    public static void UpdateMetrics() {
        gameEnded = true;
        moves = MovePrototype2.numberOfMoves;
        numHintsUsed = HintDisplay.numberOfClicks;
        CalculateMinutes(TimerCounter.mins, 10 * TimerCounter.secs + TimerCounter.timer);
        CalculateStarRating();
        // Debug.Log("Got moves: " + moves);
        // Debug.Log("Got level: " + level);
        // Debug.Log("Got level number: " + levelNum);
        // Debug.Log("Got time: " + float_minutes);
        // Debug.Log("Got score: " + score);
        // Debug.Log("Got star rating: " + star_rating);
        // Debug.Log("Got tries: " + numRetries);
        // Debug.Log("Hints used: " + numHintsUsed);
    }

    public static void CalculateStarRating() {
        // Debug.Log("Calculating rating for level: " + levelNum);
        if(levelNum > 0) {
            if (TimeStar.gotTimeStar[levelNum]) {
                star_rating += 1;
            }
            if (MoveStar.gotMoveStar[levelNum]) {
                star_rating += 1;
            }
            if (HintStar.gotHintStar[levelNum]) {
                star_rating += 1;
            }
        }
    }

    public static void ResetMetricsExceptRetry() {
        moves = 0;
        gameEnded = false;
        star_rating = 0;
        score = 0;
        float_minutes = 0;
        numHintsUsed = 0;
    }

    public static void ResetMetrics() {
        ResetMetricsExceptRetry();
        numRetries = 1;
    }

    public static void IncrementNumRetries() {
        numRetries += 1;
    }

    public void UpdateMetricsAndSend() {
        if(Metrics.collectAnalytics && !Metrics.gameEnded && Metrics.level != "StartScreen") {
            Metrics.UpdateMetrics();
            UpdateAnalytics updater = gameObject.AddComponent<UpdateAnalytics>() as UpdateAnalytics;
            updater.Send();
        }
    }
}
