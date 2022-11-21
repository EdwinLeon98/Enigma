using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserMovement : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 initialPos;
    private Vector3 screenInitialPos;
    private Vector3 ScreenPosition;
    private float speed = 50;
    //private float rotateSpeed = 100;
    private bool newDrag = true;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start() {
        mainCamera = Camera.main;
        initialPos = transform.position;
        screenInitialPos = mainCamera.WorldToScreenPoint(transform.position);
        rb.constraints = RigidbodyConstraints.FreezeAll;
        //speed = TileSpeed.tileSpeed;
    }

    void OnMouseDrag() {
        if (gameObject.tag == "HorLaser") {
            if (Input.GetMouseButton(0)) {
                rb.constraints &= ~RigidbodyConstraints.FreezePositionX;
                ScreenPosition = new Vector3(Input.mousePosition.x, screenInitialPos.y, screenInitialPos.z);//Coordinates of the object in screen space
            }
        }
        else if (gameObject.tag == "VerLaser") {
            if (Input.GetMouseButton(0)) {
                rb.constraints &= ~RigidbodyConstraints.FreezePositionZ;
                ScreenPosition = new Vector3(screenInitialPos.x, Input.mousePosition.y, screenInitialPos.z); //Coordinates of the object in screen space
            }
        }
        else {
            ScreenPosition = screenInitialPos;
        }

        Vector3 NewWorldPosition = mainCamera.ScreenToWorldPoint(ScreenPosition);   //screen coordinates of the mouse on the screen, but in world coordinates
        rb.velocity = (NewWorldPosition - transform.position) * speed * Time.deltaTime; //Set the velocity of the tile

        if (!(GameObject.Find("LevelComplete") || GameObject.Find("Settings"))) {
            if (newDrag) {
                MovePrototype2.numberOfMoves += 1;
                newDrag = false;
            }
        }
    }

    void Update() {
        //speed = TileSpeed.tileSpeed;

        if (Input.GetMouseButtonUp(0)) {
            rb.velocity = new Vector3(0, 0, 0); //Set velocity to 0 when the left mouse button is released 
            rb.constraints = RigidbodyConstraints.FreezeAll;
            newDrag = true;
        }
    }

    public void AdjustSpeed(float newSpeed) {
        speed = newSpeed;
    }
}
