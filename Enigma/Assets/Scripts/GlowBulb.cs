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
    bool charging;

    void Start(){
        temp = lightbulb1.GetComponent<MeshRenderer>().material;
        temp2 = lightbulb2.GetComponent<MeshRenderer>().material;
        charging = false;
    }

    void Update(){
        Time = TimerCounter.mins * 60;
        Time += TimerCounter.secs * 10;
        Time += TimerCounter.timer;

        if (ShootLaser.end1 == true && !charging) {
            oldTime = Time;
            charging = true;
        }
        else if (ShootLaser.end1 == false && charging) {
            charging = false;
        }

        if (ShootLaser.nl == 1) {
            if (ShootLaser.end1 == true){
                if ((Time - oldTime) <= 2) {
                    temp.color = new Color(255, 255, 125);
                }
                else {
                    temp.color = new Color(255, 255, 0);
                }
            }
            else {
                temp.color = Color.white;
            }
        }
        else if (ShootLaser.nl == 2) {
            if (ShootLaser.end1 == true) {
                temp.color = Color.yellow;
            }
            else {
                temp.color = Color.white;
            }

            if (ShootLaser.end2 == true) {
                temp2.color = Color.yellow;
            }
            else {
                temp2.color = Color.white;
            }

        }
        
    }
}
