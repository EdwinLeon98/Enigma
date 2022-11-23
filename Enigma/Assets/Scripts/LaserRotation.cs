using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserRotation : MonoBehaviour
{
    private int speed = 300;
    public Vector3 coords;
    private bool newRotation = true;
    public static Vector3 oldRotation;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        coords = new Vector3(0, Input.GetAxis("Mouse X"), 0);

        if (Input.GetMouseButtonDown(1)) {
            oldRotation.x = transform.rotation.eulerAngles.x;
            oldRotation.y = transform.rotation.eulerAngles.y;
            oldRotation.z = transform.rotation.eulerAngles.z;
        }

        if (Input.GetMouseButton(1)) {
            transform.Rotate(coords * Time.deltaTime * speed);

            if (newRotation) {
                if (!(oldRotation.y == transform.rotation.eulerAngles.y)) { 
                    MovePrototype2.numberOfMoves += 1;
                    newRotation = false;
                }
            }
        }

        if (Input.GetMouseButtonUp(1)) {
            newRotation = true;
        }
    }
}
