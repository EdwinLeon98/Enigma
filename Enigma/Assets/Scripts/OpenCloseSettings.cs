using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCloseSettings : MonoBehaviour
{
    public GameObject settings;

    // Start is called before the first frame update
    void Start() {
        //gameObject.GetComponent<Button>().onClick.AddListener(closeSettings);
    }

    public void openSettings() {
        settings.SetActive(true);
        Time.timeScale = 0;
    }

    public void closeSettings() {
        if (settings.activeInHierarchy == true) {
            settings.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
