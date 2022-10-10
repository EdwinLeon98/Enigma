using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatingSystem : MonoBehaviour
{
    float floatScore = 0.0f;    //Score with decimals
    public float minMoves = 0.0f;   //Minimum number of moves
    public float minTime = 0.0f;    //Minimum time in seconds
    public static int score = 0;    //Score in whole number
    float Time;     //Time in seconds
    float Moves;    //Number of moves

    // Update is called once per frame
    void Update() {
        //Getting time in seconds
        Time = TimerCounter.mins * 60;
        Time += TimerCounter.secs * 10; 
        Time += TimerCounter.timer;
        //Getting the number of moves
        Moves = MovePrototype2.numberOfMoves;

        //Score equation
        floatScore = ((minTime / Time) * (minMoves / Moves)) * 100;
        score = (int) floatScore; //Set score to a whole number
    }
}
