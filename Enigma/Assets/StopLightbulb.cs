using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopLightbulb : MonoBehaviour
{
    public GameObject Lightbulb;
    public GameObject ChargeText;
    Animator tempAnimator;
    Animator tempAnimator2;

    // Start is called before the first frame update
    void Start()
    {
        tempAnimator = Lightbulb.GetComponent<Animator>();
        tempAnimator2 = ChargeText.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Endpoint") {
            tempAnimator.speed = 0;
            tempAnimator2.speed = 0;
        }
    }
}
