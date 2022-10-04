using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stars : MonoBehaviour
{
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public static int prevStars1 = 0;
    public static int prevStars2 = 0;
    public static int prevStars3 = 0;

    // Update is called once per frame
    void Update() {
        Debug.Log("Level Number: " + ButtonManager.levelNumber);
        Debug.Log("Got Star 1: " + GetScore.gotStar1);
        Debug.Log("Got Star 2: " + GetScore.gotStar2);
        Debug.Log("Got Star 3: " + GetScore.gotStar3);
        Debug.Log("Prev Stars 1: " + prevStars1);
        Debug.Log("Prev Stars 2: " + prevStars2);
        Debug.Log("Prev Stars 3: " + prevStars3);

        if (gameObject.name == "Level1Stars") {
            LoadStars(prevStars1);
        }
        if (gameObject.name == "Level2Stars") {
            LoadStars(prevStars2);
        }
        if (gameObject.name == "Level3Stars") {
            LoadStars(prevStars3);
        }

        if (ButtonManager.levelNumber == 1) {
            if (gameObject.name == "Level1Stars") {
                if (GetScore.gotStar1) {
                    star1.SetActive(true);
                    if (prevStars1 < 1) {
                        prevStars1 = 1;
                    }
                    GetScore.gotStar1 = false;
                }
                else if (GetScore.gotStar2) {
                    star2.SetActive(true);
                    if (prevStars1 < 2) {
                        prevStars1 = 2;
                    }
                    GetScore.gotStar2 = false;
                }
                else if (GetScore.gotStar3) {
                    star3.SetActive(true);
                    if (prevStars1 < 3) {
                        prevStars1 = 3;
                    }
                    GetScore.gotStar3 = false;
                }
                else {
                    //Do nothing
                }
            }
        }
        else if (ButtonManager.levelNumber == 2) {
            if (gameObject.name == "Level2Stars") {
                if (GetScore.gotStar1) {
                    star1.SetActive(true);
                    if (prevStars2 < 1) {
                        prevStars2 = 1;
                    }
                    GetScore.gotStar1 = false;
                }
                else if (GetScore.gotStar2) {
                    star2.SetActive(true);
                    if (prevStars2 < 2) {
                        prevStars2 = 2;
                    }
                    GetScore.gotStar2 = false;
                }
                else if (GetScore.gotStar3) {
                    star3.SetActive(true);
                    if (prevStars2 < 3) {
                        prevStars2 = 3;
                    }
                    GetScore.gotStar3 = false;
                }
                else {
                    //Do nothing
                }
            }
        }
        else if (ButtonManager.levelNumber == 3) {
            if (gameObject.name == "Level3Stars") {
                if (GetScore.gotStar1) {
                    star1.SetActive(true);
                    if (prevStars3 < 1) {
                        prevStars3 = 1;
                    }
                    GetScore.gotStar1 = false;
                }
                else if (GetScore.gotStar2) {
                    star2.SetActive(true);
                    if (prevStars3 < 2) {
                        prevStars3 = 2;
                    }
                    GetScore.gotStar2 = false;
                }
                else if (GetScore.gotStar3) {
                    star3.SetActive(true);
                    if (prevStars3 < 3) {
                        prevStars3 = 3;
                    }
                    GetScore.gotStar3 = false;
                }
                else {
                    //Do nothing
                }
            }
        }
    }

    void LoadStars(int prevStars) {
        if (prevStars == 1) {
            star1.SetActive(true);
        }
        else if (prevStars == 2) {
            star2.SetActive(true);
        }
        else if (prevStars == 3) {
            star3.SetActive(true);
        }
        else {
            //Do Nothing
        }
    }
}