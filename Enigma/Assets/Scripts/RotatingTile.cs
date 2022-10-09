using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingTile : MonoBehaviour
{
    private Camera mainCamera;
    private float CameraZDistance;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        CameraZDistance = mainCamera.WorldToScreenPoint(transform.position).z;
    }

    // Update is called once per frame
    //count = 0;
    //while(count < 3)
    //{
    void OnMouseDrag()
    {
        //Debug.Log("Hello");

        Vector3 delta = new Vector3(Input.mousePosition.x, Input.mousePosition.y, CameraZDistance) - transform.position;
        delta.Normalize();

        
        float rot_y = Mathf.Atan2(delta.x, delta.z) * Mathf.Rad2Deg;
        
        
        transform.rotation = Quaternion.Euler(0f, rot_y - 10, 0f);
        
    }
    //count = count + 1;
    //}
}
