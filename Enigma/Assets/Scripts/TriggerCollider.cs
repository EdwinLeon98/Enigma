using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollider : MonoBehaviour
{
    public GameObject BulbTrigger;
    public GameObject BulbTrigger2;
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
        if (other.tag == "Horizontal") {
            BulbTrigger.SetActive(true);
            BulbTrigger2.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other) {
        if (other.tag == "Horizontal") {
            BulbTrigger.SetActive(false);
            BulbTrigger2.SetActive(false);
            tempAnimator.speed = 1;
            tempAnimator2.speed = 1;
        }
    }
}
