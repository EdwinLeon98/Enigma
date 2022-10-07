using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintDisplay : MonoBehaviour
{
    public GameObject hintTile1;
    public GameObject hintTile2;
    public GameObject hintTile3;

    // Update is called once per frame
    public void displayHintTile() {
        // Debug.Log("Parent Position: " + parent.transform.position);
        hintTile1.SetActive(true);
        hintTile2.SetActive(true);
        hintTile3.SetActive(true);
        
    }
}
