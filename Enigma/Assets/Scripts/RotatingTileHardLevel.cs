using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingTileHardLevel : MonoBehaviour
{
    // Start is called before the first frame update

    void spin() {
        transform.Rotate(0,0,30*Time.deltaTime);
 }
 
 void Update() {
       spin();
 }

}
