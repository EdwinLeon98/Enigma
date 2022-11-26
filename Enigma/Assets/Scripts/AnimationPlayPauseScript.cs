using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayPauseScript : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetFloat("speed", 0.0f);
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetFloat("speed", 1.0f);
    }

}
