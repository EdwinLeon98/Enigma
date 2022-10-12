using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StarList : MonoBehaviour
{
    float Time;
    public int maxTime;
    public int maxMoves;
    private TMP_Text value; //Variable to write to the the score for each star
    public GameObject SetList; //Variable to get the reference to the text object

    // Start is called before the first frame update
    void Start() {
        value = SetList.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update() {
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
}
