using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveStar : MonoBehaviour
{
    int Moves;
    public int minMoves;
    public static bool[] gotMoveStar = new bool[50];

    // Update is called once per frame
    void Update() {
        Moves = MovePrototype2.numberOfMoves;

        if (Moves < minMoves) {
            gameObject.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            gotMoveStar[ButtonManager.levelNumber] = true;
        }
    }
}
