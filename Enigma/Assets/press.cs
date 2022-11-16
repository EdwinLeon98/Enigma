using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class press : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        // anim.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Bhaven");
        // if (other.gameObject.tag == "Player")
        // {
        //     de
        // }
    }
    

}
