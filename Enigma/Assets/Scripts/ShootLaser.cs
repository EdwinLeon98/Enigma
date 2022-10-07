using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShootLaser : MonoBehaviour{

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
            if (NumberOfLasers == 2) {
                if (beam2.endpoint2) {
                    completeLevelUI.SetActive(true);
                }
            }
            else {
                completeLevelUI.SetActive(true);
            }
        }
        else if (beam.endpoint2) {
            if (NumberOfLasers == 2) {
                if (beam2.endpoint1) {
                    completeLevelUI.SetActive(true);
                }
            }
            else {
                completeLevelUI.SetActive(true);
            }
        }
    }
}
