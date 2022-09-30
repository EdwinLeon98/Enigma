using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Camera mainCamera;
    private float CameraZDistance;
    public Vector2 turn;

    // Start is called before the first frame update
    void Start()
    {
        // mainCamera = Camera.main;
        // CameraZDistance = mainCamera.WorldToScreenPoint(transform.position).z;
        Cursor.lockState = CursorLockMode.Locked;
    }


    void OnMouseDrag()
    {
        // Vector3 delta = new Vector3(Input.mousePosition.x, Input.mousePosition.y, CameraZDistance) - transform.position;
        // delta.Normalize();

        // float rot_z = Mathf.Atan2(delta.x, delta.y) * Mathf.Rad2Deg;
        // transform.rotation = Quaternion.Euler(0f, rot_z, 0f);

        turn.x += Input.GetAxis("Mouse X");
        turn.y += Input.GetAxis("Mouse Y");
        float angle = Mathf.Atan2 (turn.x, -turn.y) * Mathf.Rad2Deg;
        transform.localRotation = Quaternion.Euler(0, -turn.y, 0);
    }
}