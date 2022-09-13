using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaser : MonoBehaviour{
    
    public Material material;
    LaserBeam beam;
    GameObject currentBeam;
    public GameObject completeLevelUI;
    public int Endpoints = 1;

    // Update is called once per frame
    void Update() { 
        Destroy(GameObject.Find("Laser Beam"));
        beam = new LaserBeam(gameObject.transform.position, gameObject.transform.right, material);

        //Debug.Log("Beam endpoint: " + beam.endpoint);

        if (beam.endpoint == Endpoints) {
            //Debug.Log("Game End");
            completeLevelUI.SetActive(true);
        }
    }
}
