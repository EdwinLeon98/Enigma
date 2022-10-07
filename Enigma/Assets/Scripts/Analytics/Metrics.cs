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
    public static int star_rating;
    public static int score;
    public static bool sent_data = false;

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
        CalculateMinutes(TimerCounter.mins, 10 * TimerCounter.secs + TimerCounter.timer);
        score = RatingSystem.score;
        star_rating = GetScore.star_rating;
        // Debug.Log("Got moves: " + moves);
        // Debug.Log("Got level: " + level);
        // Debug.Log("Got time: " + float_minutes);
        // Debug.Log("Got score: " + score);
        // Debug.Log("Got star rating: " + star_rating);
    }

    public void UpdateMetricsAndSend() {
        if(Metrics.collectAnalytics && !Metrics.gameEnded && Metrics.level != "StartScreen") {
            // Debug.Log("Game has not ended");
            Metrics.UpdateMetrics();
            UpdateAnalytics updater = gameObject.AddComponent<UpdateAnalytics>() as UpdateAnalytics;
            updater.Send();
        }
    }
}
