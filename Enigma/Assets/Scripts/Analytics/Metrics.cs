using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metrics : MonoBehaviour
{

    // This class is only used to store the metrics variables
    public static int moves = 0;
    public static bool gameEnded = false;
    public static string level;
    public static float float_minutes;
    public static bool collectAnalytics = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void CalculateMinutes(int minutes, int seconds) {
        Debug.Log("Got minutes: " + minutes.ToString() + " and seconds: " + seconds.ToString());
        float_minutes = (float)minutes + (float)(seconds/60.0);
    }
}
