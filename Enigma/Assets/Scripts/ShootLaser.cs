using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ShootLaser : MonoBehaviour{

    public Material material;
    public int NumberOfLasers;
    LaserBeam beam;
    LaserBeam beam2;
    LaserBeam beam3;
    string Name; //Name of the beam
    Vector3 pos; //Position of the second beam
    public GameObject completeLevelUICanvas;
    public Color Laser1Color;
    public Color Laser2Color;
    public static bool end1 = false;
    public static bool end2 = false;
    public static int nl;
    public static bool activePL = false;
    public GameObject pl;
    public int order;

    void Start() {
        pos = gameObject.transform.position;
        pos.y = pos.y - 0.01f;
        nl = NumberOfLasers;
        order = 0;
    }
    // Update is called once per frame
    void FixedUpdate() {

        if (transform.parent.parent.name == "Laser"){
            Destroy(GameObject.Find("Laser Beam"));
        }

        if (transform.parent.parent.name == "PortalLaser"){
            Destroy(GameObject.Find("Portal Laser Beam"));
        }
        if (NumberOfLasers == 2) {
            Destroy(GameObject.Find("Laser Beam 2"));
        }

        if (!GameObject.Find("Sphere/PortalLaserSphere")){
             Destroy(GameObject.Find("Portal Laser Beam"));

        }

        if (activePL) {
            pl.SetActive(true);
        } 
        else {
            pl.SetActive(false);
        }

        if (transform.parent.parent.name == "Laser"){
            Name = "Laser Beam";
            end1 = false;
            order = 1;
            beam = new LaserBeam(gameObject.transform.position, gameObject.transform.right, 
                material, Name, Laser1Color, false, false, false, order);
        }
        else if (transform.parent.parent.name == "PortalLaser"){
            Name = "Portal Laser Beam";
            end1 = false;
            order = 2;
            beam3 = new LaserBeam(gameObject.transform.position, gameObject.transform.right, 
                material, Name, Laser1Color, false, false, true, order);
        }
        if (NumberOfLasers == 2) {
            Name = "Laser Beam 2";
            end2 = false;
            order = 0;
            beam2 = new LaserBeam(pos, gameObject.transform.right, material, Name, 
                Laser2Color, false, false, false, order);
        }

        if (transform.parent.parent.name == "Laser") {
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
            else if (NumberOfLasers == 2 && beam2.endpoint1) {
                end1 = true;
                if (NumberOfLasers == 2) {
                    if (beam.endpoint2) {
                        end2 = true;
                        completeLevelUICanvas.SetActive(true);
                    }
                }
                else {
                    completeLevelUICanvas.SetActive(true);
                }
            }
            else if (NumberOfLasers == 2 && beam2.endpoint2) {
                end2 = true;
                if (NumberOfLasers == 2) {
                    if (beam.endpoint1) {
                        end1 = true;
                        completeLevelUICanvas.SetActive(true);
                    }
                }
                else {
                    completeLevelUICanvas.SetActive(true);
                }
            }
        }
        else if (transform.parent.parent.name == "PortalLaser"){
            if (beam3.endpoint1) {
                end1 = true;
                completeLevelUICanvas.SetActive(true);
            }
        }
    }
}
