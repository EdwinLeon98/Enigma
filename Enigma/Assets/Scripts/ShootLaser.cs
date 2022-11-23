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
    public GameObject gameOverCanvas;
    public GameObject gameCanvas;
    public Color Laser1Color;
    public Color Laser2Color;
    public Color ChangeColor;
    public static Color newColor;
    public static bool end1 = false;
    public static bool end2 = false;
    public static bool overFlag = false;
    public static int nl;
    public static bool activePL = false;
    public GameObject pl;
    public int order;
    public static bool changeColor = false;
    public String anim1;
    public String anim2;

    void Start() {
        pos = gameObject.transform.position;
        pos.y = pos.y - 0.01f;
        nl = NumberOfLasers;
        order = 0;
        end1 = false;
        end2 = false;
        overFlag = false;
        newColor = ChangeColor;
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

        // Debug.Log("End: " + end1);
        if (transform.parent.parent.name == "Laser"){
            Name = "Laser Beam";
            end1 = false;
            overFlag = false;
            changeColor = false;
            order = 1;
            beam = new LaserBeam(gameObject.transform.position, gameObject.transform.right, 
                material, Name, Laser1Color, false, false, false, order,false,false);
        }
        else if (transform.parent.parent.name == "PortalLaser"){
            Name = "Portal Laser Beam";
            end1 = false;
            overFlag = false;
            order = 2;
            beam3 = new LaserBeam(gameObject.transform.position, gameObject.transform.right, 
                material, Name, Laser1Color, false, false, true, order,false,false);
        }
        if (NumberOfLasers == 2) {
            Name = "Laser Beam 2";
            end2 = false;
            overFlag = false;
            order = 0;
            beam2 = new LaserBeam(pos, gameObject.transform.right, material, Name, 
                Laser2Color, false, false, false, order,false,false);
        }

        if (transform.parent.parent.name == "Laser") {

            if(beam.anim){
                // Debug.Log("Anim");
                GameObject.Find("Cube (1)").SetActive(false);
                GameObject.Find("Cube_But").GetComponent<Animator>().Play(anim1);
                GameObject.Find("Door").GetComponent<Animator>().Play(anim2);
            }

            if(beam.over){
                overFlag = true;
                gameCanvas.SetActive(false);
                gameOverCanvas.SetActive(true);
                
            }
            if(beam2!=null){
                    if(beam2.over){
                        overFlag = true;
                        gameCanvas.SetActive(false);
                        gameOverCanvas.SetActive(true);
                    }
                }
            if (beam.endpoint1) {
                end1 = true;
                if (NumberOfLasers == 2) {
                    if (beam2.endpoint2) {
                        end2 = true;
                        if (GlowBulb.isCharged && GlowBulb.isCharged2) {
                            completeLevelUICanvas.SetActive(true);
                        }
                        if (ColorChangeBulb.isCharged && ColorChangeBulb.isCharged2) {
                            completeLevelUICanvas.SetActive(true);
                        }
                    }
                }
                else {
                    // console.log(beam.overFlag);
                    // Debug.Log("Over: " + beam.overFlag);
                    if (GlowBulb.isCharged) {
                        completeLevelUICanvas.SetActive(true);
                    }

                    if (ColorChangeBulb.isCharged) { 
                        completeLevelUICanvas.SetActive(true);
                    }
                }
            }
            else if (beam.endpoint2) {
                end2 = true;
                if (NumberOfLasers == 2) {
                    if (beam2.endpoint1) {
                        end1 = true;
                        if (GlowBulb.isCharged && GlowBulb.isCharged2) {
                            completeLevelUICanvas.SetActive(true);
                        }

                        if (ColorChangeBulb.isCharged && ColorChangeBulb.isCharged2) {
                            completeLevelUICanvas.SetActive(true);
                        }
                    }
                }
                else {
                    if (GlowBulb.isCharged) {
                        completeLevelUICanvas.SetActive(true);
                    }

                    if (ColorChangeBulb.isCharged) {
                        completeLevelUICanvas.SetActive(true);
                    }
                }
            }
            else if (NumberOfLasers == 2 && beam2.endpoint1) {
                end1 = true;
                if (NumberOfLasers == 2) {
                    if (beam.endpoint2) {
                        end2 = true;
                        if (GlowBulb.isCharged && GlowBulb.isCharged2) {
                            completeLevelUICanvas.SetActive(true);
                        }

                        if (ColorChangeBulb.isCharged && ColorChangeBulb.isCharged2) {
                            completeLevelUICanvas.SetActive(true);
                        }
                    }
                }
                else {
                    if (GlowBulb.isCharged) {
                        completeLevelUICanvas.SetActive(true);
                    }

                    if (ColorChangeBulb.isCharged) {
                        completeLevelUICanvas.SetActive(true);
                    }
                }
            }
            else if (NumberOfLasers == 2 && beam2.endpoint2) {
                end2 = true;
                if (NumberOfLasers == 2) {
                    if (beam.endpoint1) {
                        end1 = true;
                        if (GlowBulb.isCharged && GlowBulb.isCharged2) {
                            completeLevelUICanvas.SetActive(true);
                        }

                        if (ColorChangeBulb.isCharged && ColorChangeBulb.isCharged2) {
                            completeLevelUICanvas.SetActive(true);
                        }
                    }
                }
                else {
                    if (GlowBulb.isCharged) {
                        completeLevelUICanvas.SetActive(true);
                    }

                    if (ColorChangeBulb.isCharged) {
                        completeLevelUICanvas.SetActive(true);
                    }
                }
            }
        }
        else if (transform.parent.parent.name == "PortalLaser"){
             Debug.Log("Animportal"+beam3.anim);
            if(beam3.anim){
                Debug.Log("Anim");
                GameObject.Find("Cube (1)").SetActive(false);
                GameObject.Find("Cube_But").GetComponent<Animator>().Play(anim1);
                GameObject.Find("Door").GetComponent<Animator>().Play(anim2);
            }
            if (beam3.over){
                // Debug.Log(beam2);
                overFlag = true;
                gameCanvas.SetActive(false);
                gameOverCanvas.SetActive(true);
            }

            if (beam3.endpoint1) {
                end1 = true;
                if (GlowBulb.isCharged) {
                    completeLevelUICanvas.SetActive(true);
                }
            }
        }
        
    }
}
