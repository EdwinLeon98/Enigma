using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public static int openPanel=1;
    
    public Button basicButton;
    public Button rotationButton;
    public Button splitterButton;
    public Button portalsButton;
    public Button deathStarButton;    
    public Button trackingButton;
    public Button compatibilityButton;
    public Button keyDoorButton;
    public Button oscillatorButton;
    public Button stopperButton;
    public Button refractionButton;
    public Button darkButton;
    public Button conveyorButton;
    
    
//    public static GameObject openObj;
 // Start is called before the first frame update
    void Start()
    {
        panelOnStart(openPanel);
        Debug.Log("Start is called");
//        openObj= basic;
//        openObj.SetActive(true);
        //basic.SetActive(true);
//        rotation.SetActive(false);
//        splitter.SetActive(false);
//        portals.SetActive(false);
//        deathStar.SetActive(false);
//        tracking.SetActive(false);
//        compatibility.SetActive(false);
//        keyDoor.SetActive(false);
//        oscillator.SetActive(false);
//        stopper.SetActive(false);
//        refraction.SetActive(false);
//        dark.SetActive(false);
//        conveyor.SetActive(false);
        
    }
    
    void panelOnStart(int openPanel) 
    {
//        Debug.Log("Open panel: " , openPanel);
      if(openPanel==1)
      {
            basic.SetActive(true);
            Debug.Log("Clicking button");
            ColorBlock cb= basicButton.GetComponent<Button>().colors;
            cb.selectedColor=Color.cyan;
            basicButton.GetComponent<Button>().colors= cb;
            basicButton.GetComponent<Button>().onClick.Invoke();
            Debug.Log("Clicked button");
            }
      else if(openPanel==2)
            rotation.SetActive(true);
      else if(openPanel==3)
            splitter.SetActive(true);
      else if(openPanel==4)
            portals.SetActive(true);            
      else if(openPanel==5)
            deathStar.SetActive(true);            
      else if(openPanel==6)
            tracking.SetActive(true);            
      else if(openPanel==7)
            compatibility.SetActive(true);            
      else if(openPanel==8)
            keyDoor.SetActive(true);            
      else if(openPanel==9)
            oscillator.SetActive(true);            
      else if(openPanel==10)
            stopper.SetActive(true);            
      else if(openPanel==11)
            refraction.SetActive(true);            
      else if(openPanel==12)
            dark.SetActive(true);            
      else if(openPanel==13)
            conveyor.SetActive(true);            
        
            
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
            else
                openPanel=1;
            if(!GameObject.ReferenceEquals( selectedObj, rotation))
            rotation.SetActive(false);
            else   
                openPanel=2;
            if(!GameObject.ReferenceEquals( selectedObj, splitter))
            splitter.SetActive(false);
            else
                openPanel=3;
            if(!GameObject.ReferenceEquals( selectedObj, portals))
            portals.SetActive(false);
            else
                openPanel=4;
            if(!GameObject.ReferenceEquals( selectedObj, deathStar))
            deathStar.SetActive(false);
            else
                openPanel=5;
            if(!GameObject.ReferenceEquals( selectedObj, tracking))
            tracking.SetActive(false);
            else
                openPanel=6;
            if(!GameObject.ReferenceEquals( selectedObj, compatibility))
            compatibility.SetActive(false);
            else
                openPanel=7;
            if(!GameObject.ReferenceEquals( selectedObj, keyDoor))
            keyDoor.SetActive(false);
            else
                openPanel=8;
            if(!GameObject.ReferenceEquals( selectedObj, oscillator))
            oscillator.SetActive(false);
            else
                openPanel=9;
            if(!GameObject.ReferenceEquals( selectedObj, stopper))
            stopper.SetActive(false);
            else
                openPanel=10;
            if(!GameObject.ReferenceEquals( selectedObj, refraction))
            refraction.SetActive(false);
            else
                openPanel=11;
            if(!GameObject.ReferenceEquals( selectedObj, dark))
            dark.SetActive(false);
            else
                openPanel=12;
            if(!GameObject.ReferenceEquals( selectedObj, conveyor))
            conveyor.SetActive(false);
            else
                openPanel=13;
    }
}
