using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public GameObject completeLevelUI;
    public GameObject gameCanvas;

    // Start is called before the first frame update
    void Start(){
        StartCoroutine(showScreen());
    }

    IEnumerator showScreen() {
        yield return new WaitForSecondsRealtime(1);
        completeLevelUI.SetActive(true);
        gameCanvas.SetActive(false);
    }
}
