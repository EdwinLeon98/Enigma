using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;


public class RotatingTile : MonoBehaviour
{
    /*private Camera mainCamera;
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
        
    }*/

 


/*public bool facedUp, locked;
public static bool coroutineAllowed;

private Card firstinpair, secondinpair;
private string firstinpairname, secondinpairname;

public static Queue <Card> sequence;
public static int pairsfound;

public static GameObject winText;

private void Start()
{
    facedUp = false;
    locked = false;
    coroutineAllowed = true;
    sequence = new Queue<Card>();
    pairsfound = 0;

    if (winText == null)
    {
        winText = GameObject.Find("WinText");
        winText.SetActive(false);
    }

}

private void onMouseDown (){
    if (!locked && coroutineAllowed)
    {
            StartCoroutine(RotateCard);
    }
}


public IEnumerator RotateCard ()
{
    coroutineAllowed = false;

    if (!facedUp)
    {
        sequence.Enqueue(this);

        for (float i=0f; i<=90f;i+=10)
        {
                transform.rotation = Quaternion.Euler(0f,i,0f);
                yield return new WaitForSeconds(0f);
        }
    }

    else if (facedUp)
    {
        for (float i =90f;i>=0f;i-=10)
        {
            transform.rotation = Quaternion.Euler(0f,i,0f);
            yield return new WaitForSeconds(0f);
            sequence.Clear();
        }
    }

    coroutineAllowed = true;
    facedUp = !facedUp;

    if(sequence.Count == 2)
    {
            CheckResults();
    }
}

    private void CheckResults(){
        firstinpair = sequence.Dequeue();
        secondinpair = sequence.Dequeue();

        firstinpairname = firstinpair.name.Substring(0,firstinpair.name.Length - 1);
        secondinpairname = secondinpair.name.Substring(0,secondinpair.name.Length - 1);

        if (firstinpairname == secondinpairname)
        {
            firstinpair.locked = true;
            secondinpair.locked = true;
            pairsfound +=1;
        }

        else{
            firstinpair.StartCoroutine("RotateBack");
            secondinpair.StartCoroutine("RotateBack");
        }

        if (pairsfound == 3){
            winText.SetActive(true);
        }


    }

    public IEnumerator RotateBack(){

        coroutineAllowed = false;
        yield return new WaitForSeconds(0.2f);
        for (float i =90f;i>=0f;i-=10)
        {
            transform.rotation = Quaternion.Euler(0f,i,0f);
            yield return new WaitForSeconds(0f);
            sequence.Clear();
        }
        facedUp = false;
        coroutineAllowed = true;
    }
     
    //count = count + 1;
    //}*/



     /* void spin() {
        transform.Rotate(0,0,30*Time.deltaTime);
 }
 
 void Update() {
       spin();
 }*/




 /*private float SceneWidth;
 private Vector3 PressPoint;
 private Quaternion StartRotation;

 void Start()
 {
    SceneWidth = Screen.width;
 }

 void Update()
 {
    if (Input.GetMouseButtonDown(0)){

        PressPoint = Input.mousePosition;
        StartRotation = transform.rotation;

    }

    else if (Input.GetMouseButton(0)){
        float CurrentDistanceBetweenMousePositions = (Input.mousePosition - PressPoint).x;
        transform.rotation = StartRotation *  Quaternion.Euler(Vector3.forward * (CurrentDistanceBetweenMousePositions/SceneWidth)*360);
    }
 }*/



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
