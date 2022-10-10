using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShootLaser : MonoBehaviour{

    public Material material;
    public int NumberOfLasers;
    LaserBeam beam;
    LaserBeam beam2;
    string Name; //Name of the beam
    Vector3 pos; //Position of the second beam
    public GameObject completeLevelUICanvas;
    public Color Laser1Color;
    public Color Laser2Color;
    public static bool end1 = false;
    public static bool end2 = false;
    public static int nl;

    void Start() {
        pos = gameObject.transform.position;
        pos.y = pos.y - 0.01f;
        nl = NumberOfLasers;
    }

    // Update is called once per frame
    void Update() {
        Destroy(GameObject.Find("Laser Beam"));
        if (NumberOfLasers == 2) {
            Destroy(GameObject.Find("Laser Beam 2"));
        }

        Name = "Laser Beam";
        beam = new LaserBeam(gameObject.transform.position, gameObject.transform.right, material, Name, Laser1Color, false, false);

        if (NumberOfLasers == 2) {
            Name = "Laser Beam 2";
            beam2 = new LaserBeam(pos, gameObject.transform.right, material, Name, Laser2Color, false, false);
            // Debug.Log("Laser 2 is Active");
        }
        //Debug.Log("Beam endpoint: " + beam.endpoint);
        if (beam.endpoint1) {
            end1 = true;
            if (NumberOfLasers == 2) {
                if (beam2.endpoint2) {
                    end2 = true;
                    completeLevelUICanvas.SetActive(true);
                }
            }
            else {
                completeLevelUICanvas.SetActive(true);
            }
        }
        else if (beam.endpoint2) {
            end2 = true;
            if (NumberOfLasers == 2) {
                if (beam2.endpoint1) {
                    end1 = true;
                    completeLevelUICanvas.SetActive(true);
                }
            }
            else {
                completeLevelUICanvas.SetActive(true);
            }
        }
    }
}
