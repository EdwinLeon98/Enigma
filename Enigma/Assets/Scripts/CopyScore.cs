using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CopyScore : MonoBehaviour
{
    GameObject temp; //Temp holder for Game Object
    int minTime;
    int minMoves;
    int Time1;
    int Time2;
    int Time3;
    private TMP_Text value; //Variable to write to the the score for each star
    public GameObject SetScore; //Variable to get the reference to the text object

    // Start is called before the first frame update
    void Start() {
        if (!((SceneManager.GetActiveScene().name == "Tracking_Level1") || (SceneManager.GetActiveScene().name == "Tracking_Level2") 
            || (SceneManager.GetActiveScene().name == "Tracking_Level3") || (SceneManager.GetActiveScene().name == "Conveyor_Level1")
            || (SceneManager.GetActiveScene().name == "Conveyor_Level2") || (SceneManager.GetActiveScene().name == "Conveyor_Level3"))) { 
            temp = GameObject.Find("Star1");
            minTime = temp.GetComponent<TimeStar>().minTimeInSecs;

            temp = GameObject.Find("Star2");
            minMoves = temp.GetComponent<MoveStar>().minMoves;
        }
        else {
            temp = GameObject.Find("Star1");
            Time1 = temp.GetComponent<TimeStar>().minTimeInSecs;

            temp = GameObject.Find("Star2");
            Time2 = temp.GetComponent<TimeStar>().minTimeInSecs;

            temp = GameObject.Find("Star3");
            Time3 = temp.GetComponent<TimeStar>().minTimeInSecs;
        }

        value = SetScore.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update() {
        if (!((SceneManager.GetActiveScene().name == "Tracking_Level1") || (SceneManager.GetActiveScene().name == "Tracking_Level2")
            || (SceneManager.GetActiveScene().name == "Tracking_Level3") || (SceneManager.GetActiveScene().name == "Conveyor_Level1")
            || (SceneManager.GetActiveScene().name == "Conveyor_Level2") || (SceneManager.GetActiveScene().name == "Conveyor_Level3"))) {
            if (gameObject.name == "Star1Score") {   //Set score for the first star
                value.text = "Under " + minTime.ToString() + " secs";
            }
            else if (gameObject.name == "Star2Score") { //Set score for the second star
                value.text = "Under " + minMoves.ToString() + " moves";
            }
        }
        else {
            if (gameObject.name == "Star1Score") {   //Set score for the first star
                value.text = "Under " + Time1.ToString() + " secs";
            }
            else if (gameObject.name == "Star2Score") { //Set score for the second star
                value.text = "Under " + Time2.ToString() + " secs";
            }
            else if (gameObject.name == "Star3Score") { //Set score for the third star
                value.text = "Under " + Time3.ToString() + " secs";
            }
        }
    }
}
