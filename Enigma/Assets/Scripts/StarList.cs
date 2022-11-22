using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class StarList : MonoBehaviour
{
    float Time;
    public int maxTime;
    public int maxMoves;
    public int Time1;
    public int Time2;
    public int Time3;
    private TMP_Text value; //Variable to write to the the score for each star
    public GameObject SetList; //Variable to get the reference to the text object

    // Start is called before the first frame update
    void Start() {
        value = SetList.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update() {
        if (!((SceneManager.GetActiveScene().name == "Tracking_Level1") || (SceneManager.GetActiveScene().name == "Tracking_Level2") 
            || (SceneManager.GetActiveScene().name == "Tracking_Level3") || (SceneManager.GetActiveScene().name == "Conveyor_Level1")
            || (SceneManager.GetActiveScene().name == "Conveyor_Level2") || (SceneManager.GetActiveScene().name == "Conveyor_Level3"))) {
            if (gameObject.name == "StarImage1Text") {
                Time = TimerCounter.mins * 60;
                Time += TimerCounter.secs * 10;
                Time += TimerCounter.timer;

                value.text = "Complete the level under " + maxTime + " seconds";
                if (Time >= maxTime) {
                    gameObject.GetComponentInParent<Image>().color = new Color32(106, 106, 106, 160);
                }
            }
            else if (gameObject.name == "StarImage2Text") {
                value.text = "Complete the level under " + maxMoves + " moves";
                if (MovePrototype2.numberOfMoves >= maxMoves) {
                    gameObject.GetComponentInParent<Image>().color = new Color32(106, 106, 106, 160);
                }
            }
            else if (gameObject.name == "StarImage3Text") {
                if (HintDisplay.usedHints) {
                    gameObject.GetComponentInParent<Image>().color = new Color32(106, 106, 106, 160);
                }
            }
        }
        else {
            Time = TimerCounter.mins * 60;
            Time += TimerCounter.secs * 10;
            Time += TimerCounter.timer;

            if (gameObject.name == "StarImage1Text") {
                value.text = "Complete the level under " + Time1 + " seconds";
                if (Time >= Time1) {
                    gameObject.GetComponentInParent<Image>().color = new Color32(106, 106, 106, 160);
                }
            }
            else if (gameObject.name == "StarImage2Text") {
                value.text = "Complete the level under " + Time2 + " seconds";
                if (Time >= Time2) {
                    gameObject.GetComponentInParent<Image>().color = new Color32(106, 106, 106, 160);
                }
            }
            else if (gameObject.name == "StarImage3Text") {
                value.text = "Complete the level under " + Time3 + " seconds";
                if (Time >= Time3) {
                    gameObject.GetComponentInParent<Image>().color = new Color32(106, 106, 106, 160);
                }
            }
        }
    }
}
