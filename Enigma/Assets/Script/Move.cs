using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider))]
public class Move : MonoBehaviour
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
        Vector3 ScreenPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,CameraZDistance);
        Vector3 NewWorldPosition = mainCamera.ScreenToWorldPoint(ScreenPosition);
        transform.position = NewWorldPosition;
    }
}