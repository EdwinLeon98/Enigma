using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayTrigger : MonoBehaviour
{
	// public Transform Spawnpoint;
	public GameObject gameOver;
	public GameObject gameCanvasScr;

	void Start()
    {
    	    	    Debug.Log("Hiii");

        gameOver.SetActive(false);
        gameCanvasScr.SetActive(true);
        
    }

    // Start is called before the first frame update
    void OnTriggerEnter(Collider o)
    {
    	    Debug.Log("Is this even being triggered?");
    	// if(other.tag.Equals("Laser"))
           gameOver.SetActive(true);
           gameCanvasScr.SetActive(true);
  }

   void OnTriggerExit(Collider other)
    {
    	Debug.Log("Prasad");
        gameOver.SetActive(false);
        gameCanvasScr.SetActive(true);
    }
    
}
