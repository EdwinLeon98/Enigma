using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CopyTime : MonoBehaviour
{
    private TMP_Text time;
    public GameObject EndTimer;

    // Start is called before the first frame update
    void Start()
    {
        time = EndTimer.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        time.text = "Time: " + TimerCounter.mins + ":" + TimerCounter.secs + TimerCounter.timer;
    }
}
