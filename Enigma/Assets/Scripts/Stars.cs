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
        if (gameObject.name == "Basic_Level1Stars") {
            int x = 1;
            activateStars(x);
        }

        if (gameObject.name == "Basic_Level2Stars") {
            int x = 2;
            activateStars(x);
        }

        if (gameObject.name == "Basic_Level3Stars") {
            int x = 3;
            activateStars(x);
        }

        if (gameObject.name == "Rotation_Level1Stars") {
            int x = 4;
            activateStars(x);
        }

        if (gameObject.name == "Rotation_Level2Stars") {
            int x = 5;
            activateStars(x);
        }

        if (gameObject.name == "Rotation_Level3Stars") {
            int x = 6;
            activateStars(x);
        }

        if (gameObject.name == "Basic_Level4Stars") {
            int x = 7;
            activateStars(x);
        }

        if (gameObject.name == "Splitter_Level1Stars") {
            int x = 8;
            activateStars(x);
        }

        if (gameObject.name == "Splitter_Level6Stars") {
            int x = 9;
            activateStars(x);
        }

        if (gameObject.name == "Splitter_Level2Stars") {
            int x = 10;
            activateStars(x);
        }

        if (gameObject.name == "Splitter_Level3Stars") {
            int x = 11;
            activateStars(x);
        }

        if (gameObject.name == "Splitter_Level4Stars") {
            int x = 12;
            activateStars(x);
        }

        if (gameObject.name == "Splitter_Level7Stars") {
            int x = 13;
            activateStars(x);
        }

        if (gameObject.name == "Splitter_Level5Stars") {
            int x = 14;
            activateStars(x);
        }

        if (gameObject.name == "Portals_Level1Stars") {
            int x = 15;
            activateStars(x);
        }
        if (gameObject.name == "Portals_Level2Stars") {
            int x = 16;
            activateStars(x);
        }
        if (gameObject.name == "Portals_Level3Stars") {
            int x = 17;
            activateStars(x);
        }
        if (gameObject.name == "Blackhole_Level1Stars") {
            int x = 18;
            activateStars(x);
        }
             if (gameObject.name == "Blackhole_Level2Stars") {
            int x = 19;
            activateStars(x);
        }
        if (gameObject.name == "Blackhole_Level3Stars") {
            int x = 20;
            activateStars(x);
        }
         if (gameObject.name == "Blackhole_Level4Stars") {
            int x = 21;
            activateStars(x);
        }
        if (gameObject.name == "Tracking_Level1Stars") {
            int x = 22;
            activateStars(x);
        }
        if (gameObject.name == "Tracking_Level2Stars") {
            int x = 23;
            activateStars(x);
        }
        if (gameObject.name == "Tracking_Level3Stars") {
            int x = 24;
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
