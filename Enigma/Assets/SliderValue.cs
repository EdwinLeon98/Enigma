using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderValue : MonoBehaviour
{
    public Slider slider;
    private TMP_Text sliderText;
    public GameObject setText;
    public int speed; 

    // Start is called before the first frame update
    void Start()
    {
        sliderText = setText.GetComponent<TextMeshProUGUI>();
        if (speed == 0) {
            slider.value = TileSpeed.tileSpeed;
        }
        else if (speed == 1) {
            slider.value = TileSpeed.rotationSpeed;
        }

    }

    void Update() {
        sliderText.text = slider.value.ToString();
    }
}
