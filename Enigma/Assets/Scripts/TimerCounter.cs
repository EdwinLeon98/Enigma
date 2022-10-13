using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerCounter : MonoBehaviour
{
    private TMP_Text displayTimer; 
    public GameObject Timer;
    public static int timer = 0;
    public static int mins = 0;
    public static int secs = 0;
 
    // Start is called before the first frame update
    public void Start()
    {
        displayTimer = Timer.GetComponent<TextMeshProUGUI>();
        StartCoroutine(time());
    }

    // Update is called once per frame
    public void Update()
    {
        if (timer < 10) {
            displayTimer.text = "Time: " + mins + ":" + secs + timer.ToString();
        }
        else {
            timer = 0;
            if(secs < 5) {
                secs += 1;
            }
            else {
                secs = 0;
                mins += 1;
            }
        }
    }

    IEnumerator time(){
        while (true)
        {
            timeCount();
            yield return new WaitForSeconds(1);
        }
    }  

    void timeCount(){
        if (!(GameObject.Find("LevelComplete")) && !(GameObject.Find("Tutorial Canvas"))) {
            timer += 1;
        }
    }

}
