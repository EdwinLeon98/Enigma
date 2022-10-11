using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintStar : MonoBehaviour
{
    bool Hints;

    // Update is called once per frame
    void Update() {
        Hints = HintDisplay.usedHints;

        if (!Hints) {
            gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
}
