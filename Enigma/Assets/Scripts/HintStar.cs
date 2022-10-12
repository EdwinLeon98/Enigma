using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintStar : MonoBehaviour
{
    bool Hints;
    public static bool[] gotHintStar = new bool[20];

    // Update is called once per frame
    void Update() {
        Hints = HintDisplay.usedHints;

        if (!Hints) {
            gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            gotHintStar[ButtonManager.levelNumber] = true;
        }
    }
}
