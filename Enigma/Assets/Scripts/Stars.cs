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
            int x = 1;
            activateStars(x);
        }

        if (gameObject.name == "Level2Stars") {
            int x = 2;
            activateStars(x);
        }

        if (gameObject.name == "Level3Stars") {
            int x = 3;
            activateStars(x);
        }

        if (gameObject.name == "Level4Stars") {
            int x = 4;
            activateStars(x);
        }

        if (gameObject.name == "Level5Stars") {
            int x = 5;
            activateStars(x);
        }

        if (gameObject.name == "Level6Stars") {
            int x = 6;
            activateStars(x);
        }

        if (gameObject.name == "Level7Stars") {
            int x = 7;
            activateStars(x);
        }

        if (gameObject.name == "Level8Stars") {
            int x = 8;
            activateStars(x);
        }

        if (gameObject.name == "Level9Stars") {
            int x = 9;
            activateStars(x);
        }

        if (gameObject.name == "Level10Stars") {
            int x = 10;
            activateStars(x);
        }
    }

    void activateStars(int levelNum) {
        if (TimeStar.gotTimeStar[levelNum]) {
            star1.SetActive(true);
        }
        if (MoveStar.gotMoveStar[levelNum]) {
            star2.SetActive(true);
        }
        if (HintStar.gotHintStar[levelNum]) {
            star3.SetActive(true);
        }
    }
}
