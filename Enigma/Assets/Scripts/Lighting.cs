using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class Lighting : MonoBehaviour {
 
 
// public GameObject FlashLight;
     
//    void Start()
// {
//     Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
// }
 // Update is called once per frame
 public void LateUpdate()
 {
     moveFlashlight();
     

 }
 void moveFlashlight()
 {
     Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
     transform.position= new Vector3(mousePosition.x, 1, mousePosition.z+1.5f);
 }

    
 }