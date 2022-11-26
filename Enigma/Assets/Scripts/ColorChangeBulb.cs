using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeBulb : MonoBehaviour
{
    public GameObject lightbulb1;
    public GameObject text;
    Material temp;
    int Time;
    int oldTime;
    bool isCharging;
    bool finishedCharging;
    public static bool isColorCharged;

    void Start(){
        temp = lightbulb1.GetComponent<Renderer>().material;
        oldTime = 100;
        isCharging = false;
        isColorCharged = false;
        finishedCharging = false;
        text.SetActive(false);
    }

    void Update(){
        Time = TimerCounter.mins * 60;
        Time += TimerCounter.secs * 10;
        Time += TimerCounter.timer;

        if (ShootLaser.end1 == true && !isCharging && ShootLaser.changeColor == true) {
            oldTime = Time;
            isCharging = true;
            text.SetActive(true);
        }
        else if (ShootLaser.end1 == true && !isCharging && ShootLaser.changeColor == false) {
            isCharging = false;
            text.SetActive(false);
        }
        else if (ShootLaser.end1 == true && isCharging && ShootLaser.changeColor == false) {
            isCharging = false;
            text.SetActive(false);
        }
        else if (ShootLaser.end1 == false && isCharging && ShootLaser.changeColor == true) {
            isCharging = false;
            text.SetActive(false);
        }
        else if (ShootLaser.end1 == false && isCharging && ShootLaser.changeColor == false) {
            isCharging = false;
            text.SetActive(false);
        }

        if (ShootLaser.end1 == true && ShootLaser.changeColor == true){
            Charging(Time, oldTime, temp, text);
            if (finishedCharging) {
                isColorCharged = true;
                //Debug.Log("Finished charging");
            }
        }
        else {
            temp.color = Color.white;
            isColorCharged = false;
            finishedCharging = false;
        }
    }

    void Charging(int currentTime, int startTime, Material bulb, GameObject text) {
        if ((currentTime - startTime) <= 1) {
            bulb.color = new Color(1, 1, 0.6f);
            text.SetActive(true);
        }
        else if ((currentTime - startTime) <= 2) {
            bulb.color = new Color(1, 1, 0.3f);
        }
        else {
            //Debug.Log("hi");
            bulb.color = new Color(1, 1, 0);
            text.SetActive(false);
            finishedCharging = true;
        }
    }
}
