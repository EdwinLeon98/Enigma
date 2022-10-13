using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialDisplay : MonoBehaviour
{

    public GameObject Intro;

    // Start is called before the first frame update
    void Start()
    {
    	// Intro.gameObject.setActive(false);
    	 Intro.SetActive(true);


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void hideIntro(){
    	Intro.SetActive(false);
    }
}
