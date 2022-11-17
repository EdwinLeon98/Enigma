using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayTrigger : MonoBehaviour
{
	public GameObject gameOver;
	public GameObject gameCanvasScr;

	void Start()
    {

        gameOver.SetActive(false);
        gameCanvasScr.SetActive(true);
        
    }

    void OnTriggerEnter(Collider other)
    {
    	  
           gameOver.SetActive(true);
           gameCanvasScr.SetActive(true);
  }

   void OnTriggerExit(Collider other)
    {
        gameOver.SetActive(false);
        gameCanvasScr.SetActive(true);
    }
    
}
