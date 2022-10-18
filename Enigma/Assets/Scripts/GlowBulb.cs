using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowBulb : MonoBehaviour
{
    public GameObject lightbulb1;
    public GameObject lightbulb2;
    Material temp;
    Material temp2;
    int Time;
    int oldTime;
    int oldTime2;
    bool isCharging;
    bool isCharging2;

    void Start(){
        temp = lightbulb1.GetComponent<Renderer>().material;
        temp2 = lightbulb2.GetComponent<Renderer>().material;
        isCharging = false;
    }

    void Update(){
        Time = TimerCounter.mins * 60;
        Time += TimerCounter.secs * 10;
        Time += TimerCounter.timer;

        if (ShootLaser.end1 == true && !isCharging) {
            oldTime = Time;
            isCharging = true;
        }
        else if (ShootLaser.end1 == false && isCharging) {
            isCharging = false;
        }

        if (ShootLaser.end2 == true && !isCharging2) {
            oldTime2 = Time;
            isCharging2 = true;
        }
        else if (ShootLaser.end2 == false && isCharging2) {
            isCharging2 = false;
        }

        if (ShootLaser.nl == 1) {
            if (ShootLaser.end1 == true){
                Charging(Time, oldTime, temp2);
            }
            else {
                temp.color = Color.white;
            }
        }
        else if (ShootLaser.nl == 2) {
            if (ShootLaser.end1 == true) {
                Charging(Time, oldTime, temp);
            }
            else {
                temp.color = Color.white;
            }

            if (ShootLaser.end2 == true) {
                Charging(Time, oldTime2, temp2);
            }
            else {
                temp2.color = Color.white;
            }

        }
        
    }

    void Charging(int currentTime, int startTime, Material bulb) {
        if ((currentTime - startTime) <= 1) {
            bulb.color = new Color(1, 1, 0.6f);
        }
        else if ((currentTime - startTime) <= 2) {
            bulb.color = new Color(1, 1, 0.3f);
        }
        else {
            bulb.color = new Color(1, 1, 0);
        }
    }
}
