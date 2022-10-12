using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CopyScore : MonoBehaviour
{
    GameObject temp; //Temp holder for Game Object
    int minTime;
    int minMoves;
    private TMP_Text value; //Variable to write to the the score for each star
    public GameObject SetScore; //Variable to get the reference to the text object

    // Start is called before the first frame update
    void Start() {
        temp = GameObject.Find("Star1");    
        minTime = temp.GetComponent<TimeStar>().minTimeInSecs;

        temp = GameObject.Find("Star2");
        minMoves = temp.GetComponent<MoveStar>().minMoves;

        value = SetScore.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update() {

        if (gameObject.name == "Star1Score") {   //Set score for the first star
            value.text = "Under " + minTime.ToString() + " secs";
        }
        else if (gameObject.name == "Star2Score") { //Set score for the second star
            value.text = "Under " + minMoves.ToString() + " moves";
        }
    }
}
