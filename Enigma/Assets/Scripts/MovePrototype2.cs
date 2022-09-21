using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePrototype2 : MonoBehaviour
{
    private Camera mainCamera;
    private Vector3 initialPos;
    private Vector3 screenInitialPos;
    private Vector3 ScreenPosition;
    private float speed = 1000;
    public static int numberOfMoves = 0;
    private bool newDrag = true;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start() {
        mainCamera = Camera.main;
        initialPos = transform.position;
        //Debug.Log("Initial Pos: " + initialPos);
        screenInitialPos = mainCamera.WorldToScreenPoint(transform.position);
        //Debug.Log("Screen Pos: " + screenInitialPos); 
    }

    void OnMouseDrag() {
        if (gameObject.tag == "Horizontal") {
            ScreenPosition = new Vector3(Input.mousePosition.x, screenInitialPos.y, screenInitialPos.z);//Coordinates of the object in screen space
        }
        else if(gameObject.tag == "Vertical") {
            ScreenPosition = new Vector3(screenInitialPos.x, Input.mousePosition.y, screenInitialPos.z); //Coordinates of the object in screen space
        }
        else {
            ScreenPosition = screenInitialPos;
        }

        Vector3 NewWorldPosition = mainCamera.ScreenToWorldPoint(ScreenPosition);   //screen coordinates of the mouse on the screen, but in world coordinates
        rb.velocity = (NewWorldPosition - transform.position) * speed * Time.deltaTime; //Set the velocity of the tile
        //Debug.Log("ScreenPosition: " + ScreenPosition);
        //Debug.Log("Transform Position: " + transform.position);
        //Debug.Log("Position: " + NewWorldPosition);
        if (!GameObject.Find("LevelComplete")) {
            if (newDrag) {
                numberOfMoves += 1;
                newDrag = false;
            }
        }
    }

    void Update() {
        if (Input.GetMouseButtonUp(0)) {
            rb.velocity = new Vector3(0, 0, 0); //Set velocity to 0 when the left mouse button is released
            //Debug.Log("Left click");
            
            newDrag = true;
        }
    }

}
