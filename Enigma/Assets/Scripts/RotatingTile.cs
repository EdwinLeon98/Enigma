using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;


public class RotatingTile : MonoBehaviour
{
float rotSpeed = 40;


    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

       // transform.RotateAround(Vector3.up, -rotX);
       // transform.RotateAround(Vector3.right, rotY);

        transform.Rotate(Vector3.up, -rotX, Space.World);
        transform.Rotate(Vector3.right, rotY, Space.World);

    }


}
