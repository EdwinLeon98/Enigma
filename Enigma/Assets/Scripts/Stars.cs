using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stars : MonoBehaviour
{
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    // Update is called once per frame
    void Update() {
        if (gameObject.name == "Level1Stars") {
            if (TimeStar.gotTimeStar[1]) {
                star1.SetActive(true);
            }
            if (MoveStar.gotMoveStar[1]) {
                star2.SetActive(true);
            }
            if (HintStar.gotHintStar[1]) {
                star3.SetActive(true);
            }
        }

        if (gameObject.name == "Level2Stars") {
            if (TimeStar.gotTimeStar[2]) {
                star1.SetActive(true);
            }
            if (MoveStar.gotMoveStar[2]) {
                star2.SetActive(true);
            }
            if (HintStar.gotHintStar[2]) {
                star3.SetActive(true);
            }
        }

        if (gameObject.name == "Level3Stars") {
            if (TimeStar.gotTimeStar[3]) {
                star1.SetActive(true);
            }
            if (MoveStar.gotMoveStar[3]) {
                star2.SetActive(true);
            }
            if (HintStar.gotHintStar[3]) {
                star3.SetActive(true);
            }
        }

        if (gameObject.name == "Level4Stars") {
            if (TimeStar.gotTimeStar[4]) {
                star1.SetActive(true);
            }
            if (MoveStar.gotMoveStar[4]) {
                star2.SetActive(true);
            }
            if (HintStar.gotHintStar[4]) {
                star3.SetActive(true);
            }
        }
    }
}
