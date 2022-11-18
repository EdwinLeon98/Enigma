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
    public float MoveSpeed = 250;
    public float RotatingSpeed = 100;
    private float speed = 250;
    private float rotateSpeed = 100;
    public static int numberOfMoves = 0;
    private bool newDrag = true;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start() {
        mainCamera = Camera.main;
        initialPos = transform.position;
        screenInitialPos = mainCamera.WorldToScreenPoint(transform.position);
        rb.constraints = RigidbodyConstraints.FreezeAll;
        speed = MoveSpeed;
        rotateSpeed = RotatingSpeed;
    }

    void OnMouseDrag() {
        if (gameObject.tag == "Horizontal" || gameObject.tag == "HorizontalRefractor") {
            rb.constraints &= ~RigidbodyConstraints.FreezePositionX;
            ScreenPosition = new Vector3(Input.mousePosition.x, screenInitialPos.y, screenInitialPos.z);//Coordinates of the object in screen space
        }
        else if(gameObject.tag == "Vertical" || gameObject.tag == "PortalIn" || gameObject.tag == "PortalOut" || gameObject.tag == "VerticalRefractor") {
            rb.constraints &= ~RigidbodyConstraints.FreezePositionZ;
            ScreenPosition = new Vector3(screenInitialPos.x, Input.mousePosition.y, screenInitialPos.z); //Coordinates of the object in screen space
        }
        else if (gameObject.tag == "Rotate"){
            rb.constraints &= ~RigidbodyConstraints.FreezeRotationY;
            float rotX = Input.GetAxis("Mouse X") * rotateSpeed;
            rb.AddTorque(transform.up * rotX);
        }
        else {
            ScreenPosition = screenInitialPos;
        }

        Vector3 NewWorldPosition = mainCamera.ScreenToWorldPoint(ScreenPosition);   //screen coordinates of the mouse on the screen, but in world coordinates
        rb.velocity = (NewWorldPosition - transform.position) * speed * Time.deltaTime; //Set the velocity of the tile

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
            rb.constraints = RigidbodyConstraints.FreezeAll;
            newDrag = true;
        }
        rb.angularVelocity = new Vector3(0, 0, 0);
    }

}
