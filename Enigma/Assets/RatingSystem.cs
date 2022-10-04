using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatingSystem : MonoBehaviour
{
    float floatScore = 0.0f;
    public float minMoves = 0.0f;
    public float minTime = 0.0f; //Minimum time in seconds
    public static int score = 0;
    float Time;
    float Moves;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time = TimerCounter.mins * 60;
        Time += TimerCounter.secs * 10;
        Time += TimerCounter.timer;
        Moves = MovePrototype2.numberOfMoves;
        //Debug.Log("Time in Seconds: " + Time);

        floatScore = ((minTime / Time) * (minMoves / Moves)) * 100;
        //Debug.Log("Float Score: " + floatScore);
        score = (int) floatScore;
        //Debug.Log("Score: " + score);
    }
}
