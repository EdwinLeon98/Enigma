using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShootLaser : MonoBehaviour{

    public static bool end1 = false;
    public static bool end2 = false;
    public Material material;
    public int NumberOfLasers;
    LaserBeam beam;
    LaserBeam beam2;
    string name; //Name of the beam
    Vector3 pos; //Position of the second beam
    public GameObject completeLevelUI;
    public Color Laser1Color;
    public Color Laser2Color;
    void Start() {
        pos = gameObject.transform.position;
        pos.y = pos.y - 0.01f;
    }

    // Update is called once per frame
    void Update() {
        // end1=false;
        // end2=false;
        Destroy(GameObject.Find("Laser Beam"));
        if (NumberOfLasers == 2) {
            Destroy(GameObject.Find("Laser Beam 2"));
        }

        name = "Laser Beam";
        beam = new LaserBeam(gameObject.transform.position, gameObject.transform.right, material, name, Laser1Color, false, false);

        if (NumberOfLasers == 2) {
            name = "Laser Beam 2";
            beam2 = new LaserBeam(pos, gameObject.transform.right, material, name, Laser2Color, false, false);
            // Debug.Log("Laser 2 is Active");
        }
        //Debug.Log("Beam endpoint: " + beam.endpoint);
       
        if (beam.endpoint1) {
            end1=true;
            // GetComponent<MeshRenderer>().material.color = Color.yellow;
            if (NumberOfLasers == 2) {
                if (beam2.endpoint2) {
                    completeLevelUI.SetActive(true);
                    UpdateMetrics();
                }
            }
            else {
                completeLevelUI.SetActive(true);
                UpdateMetrics();
            }
        }
        else if (beam.endpoint2) {
            end2=true;
            // GetComponent<MeshRenderer>().material.color = Color.yellow;
            if (NumberOfLasers == 2) {
                if (beam2.endpoint1) {
                    completeLevelUI.SetActive(true);
                    UpdateMetrics();
                }
            }
            else {
                completeLevelUI.SetActive(true);
                UpdateMetrics();
            }
        }
    }

    void UpdateMetrics() {
        if(Metrics.collectAnalytics && !Metrics.gameEnded && !String.IsNullOrEmpty(Metrics.level)) {
            Metrics.moves = MovePrototype2.numberOfMoves;
            Metrics.gameEnded = true;
            Metrics.CalculateMinutes(TimerCounter.mins, 10 * TimerCounter.secs + TimerCounter.timer);
            UpdateAnalytics updater = gameObject.AddComponent<UpdateAnalytics>() as UpdateAnalytics;
            updater.Send();
        }
    }
}
