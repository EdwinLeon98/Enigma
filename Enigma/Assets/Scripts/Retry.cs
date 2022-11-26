using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{

    // Update is called once per frame
    public void RetryLevel(string levelName)
    {
         SceneManager.LoadScene(levelName);
         MovePrototype2.numberOfMoves=0;
         TimerCounter.mins=0;
         TimerCounter.secs=0;
         TimerCounter.timer=0;
         PauseGame.unpause=true;
         Metrics.IncrementNumRetries();
         Metrics.ResetMetricsExceptRetry();
    }
}
