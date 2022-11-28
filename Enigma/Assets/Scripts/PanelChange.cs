using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChange : MonoBehaviour
{
    
    public GameObject basic;
    public GameObject rotation;
    public GameObject splitter;
    public GameObject portals;
    public GameObject deathStar;    
    public GameObject tracking;
    public GameObject compatibility;
    public GameObject keyDoor;
    public GameObject oscillator;
    public GameObject stopper;
    public GameObject refraction;
    public GameObject dark;
    public GameObject conveyor;
//    public static GameObject openObj;
 // Start is called before the first frame update
    void Start()
    {
    
        Debug.Log("Start is called");
//        openObj= basic;
//        openObj.SetActive(true);
        //basic.SetActive(true);
        rotation.SetActive(false);
        splitter.SetActive(false);
        portals.SetActive(false);
        deathStar.SetActive(false);
        tracking.SetActive(false);
        compatibility.SetActive(false);
        keyDoor.SetActive(false);
        oscillator.SetActive(false);
        stopper.SetActive(false);
        refraction.SetActive(false);
        dark.SetActive(false);
        conveyor.SetActive(false);
        
    }
    
    void Update()
    {

//        openObj.SetActive(true);
    }


    public void panelChangeFunction(GameObject selectedObj)
    {
//            openObj= selectedObj;
            selectedObj.SetActive(true);
            if(!GameObject.ReferenceEquals( selectedObj, basic))
            basic.SetActive(false);
            if(!GameObject.ReferenceEquals( selectedObj, rotation))
            rotation.SetActive(false);
            if(!GameObject.ReferenceEquals( selectedObj, splitter))
            splitter.SetActive(false);
            if(!GameObject.ReferenceEquals( selectedObj, portals))
            portals.SetActive(false);
            if(!GameObject.ReferenceEquals( selectedObj, deathStar))
            deathStar.SetActive(false);
            if(!GameObject.ReferenceEquals( selectedObj, tracking))
            tracking.SetActive(false);
            if(!GameObject.ReferenceEquals( selectedObj, compatibility))
            compatibility.SetActive(false);
            if(!GameObject.ReferenceEquals( selectedObj, keyDoor))
            keyDoor.SetActive(false);
            if(!GameObject.ReferenceEquals( selectedObj, oscillator))
            oscillator.SetActive(false);
            if(!GameObject.ReferenceEquals( selectedObj, stopper))
            stopper.SetActive(false);
            if(!GameObject.ReferenceEquals( selectedObj, refraction))
            refraction.SetActive(false);
            if(!GameObject.ReferenceEquals( selectedObj, dark))
            dark.SetActive(false);
            if(!GameObject.ReferenceEquals( selectedObj, conveyor))
            conveyor.SetActive(false);
    }
}
