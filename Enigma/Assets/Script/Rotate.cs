using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Camera mainCamera;
    private float CameraZDistance;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        CameraZDistance = mainCamera.WorldToScreenPoint(transform.position).z;
    }


    void OnMouseDrag()
    {
        Vector3 delta = new Vector3(Input.mousePosition.x, Input.mousePosition.y, CameraZDistance) - transform.position;
        delta.Normalize();

        float rot_z = Mathf.Atan2(delta.y, delta.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
    }
}
