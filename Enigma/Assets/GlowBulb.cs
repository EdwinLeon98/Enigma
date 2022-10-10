using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowBulb : MonoBehaviour
{
    public GameObject lightbulb1;
    public GameObject lightbulb2;
    Material temp;
    Material temp2;

    void Start(){
        temp = lightbulb1.GetComponent<MeshRenderer>().material;
        temp2 = lightbulb2.GetComponent<MeshRenderer>().material;
    }
    void Update(){
        if (ShootLaser.nl==1) {
            if (ShootLaser.end1==true){
                temp.color = Color.yellow;
            }
            else {
                temp.color = Color.white;
            }
        }
        else if (ShootLaser.nl==2) {
            if (ShootLaser.end1 == true){
                temp.color = Color.yellow;
            }
            else {
                temp.color = Color.white;
            }

            if (ShootLaser.end2 == true){
                temp2.color = Color.yellow;
            }
            else {
                temp2.color = Color.white;
            }

        }
        
    }
}
