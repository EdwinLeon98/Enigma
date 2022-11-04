using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowBulb : MonoBehaviour
{
    public GameObject lightbulb1;
    public GameObject lightbulb2;
    public GameObject text;
    public GameObject text2;
    Material temp;
    Material temp2;
    int Time;
    int oldTime;
    int oldTime2;
    bool isCharging;
    bool isCharging2;
    bool finishedCharging;
    bool finishedCharging2;
    public static bool isCharged;
    public static bool isCharged2;

    void Start(){
        temp = lightbulb1.GetComponent<Renderer>().material;
        temp2 = lightbulb2.GetComponent<Renderer>().material;
        oldTime = 100;
        oldTime2 = 100;
        isCharging = false;
        isCharging2 = false;
        isCharged = false;
        isCharged2 = false;
        finishedCharging = false;
        finishedCharging2 = false;
        text.SetActive(false);
        text2.SetActive(false);
    }

    void Update(){
        Time = TimerCounter.mins * 60;
        Time += TimerCounter.secs * 10;
        Time += TimerCounter.timer;

        if (ShootLaser.end1 == true && !isCharging) {
            oldTime = Time;
            isCharging = true;
            text.SetActive(true);
        }
        else if (ShootLaser.end1 == false && isCharging) {
            isCharging = false;
            text.SetActive(false);
        }

        if (ShootLaser.end2 == true && !isCharging2) {
            oldTime2 = Time;
            isCharging2 = true;
            text2.SetActive(true);
        }
        else if (ShootLaser.end2 == false && isCharging2) {
            isCharging2 = false;
            text2.SetActive(false);
        }

        if (ShootLaser.nl == 1) {
            if (ShootLaser.end1 == true){
                Charging(Time, oldTime, temp, text);
                if (finishedCharging) {
                    isCharged = true;
                }
            }
            else {
                temp.color = Color.white;
                isCharged = false;
                finishedCharging = false;
            }
        }
        else if (ShootLaser.nl == 2) {
            if (ShootLaser.end1 == true) {
                Charging(Time, oldTime, temp, text);
                if (finishedCharging) {
                    isCharged = true;
                }
            }
            else {
                temp.color = Color.white;
                isCharged = false;
                finishedCharging = false;
            }

            if (ShootLaser.end2 == true) {
                Charging2(Time, oldTime2, temp2, text2);
                if (finishedCharging2) {
                    isCharged2 = true;
                }
            }
            else {
                temp2.color = Color.white;
                isCharged2 = false;
                finishedCharging2 = false;
            }
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
            bulb.color = new Color(1, 1, 0);
            text.SetActive(false);
            finishedCharging = true;
        }
    }

    void Charging2(int currentTime, int startTime, Material bulb, GameObject text) {
        if ((currentTime - startTime) <= 1) {
            bulb.color = new Color(1, 1, 0.6f);
            text.SetActive(true);
        }
        else if ((currentTime - startTime) <= 2) {
            bulb.color = new Color(1, 1, 0.3f);
        }
        else {
            bulb.color = new Color(1, 1, 0);
            text.SetActive(false);
            finishedCharging2 = true;
        }
    }
}
