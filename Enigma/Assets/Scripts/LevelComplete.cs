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
        //yield return new WaitForSecondsRealtime(1);
        Metrics metrics_instance = gameObject.AddComponent<Metrics>() as Metrics;
        gameCanvas.SetActive(false);
        if (GameObject.Find("TooltipCanvas")) {
            GameObject.Find("TooltipCanvas").SetActive(false);
        }
        completeLevelUI.SetActive(true);
        yield return new WaitForSecondsRealtime(1);
        metrics_instance.UpdateMetricsAndSend();
    }
}
