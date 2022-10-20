using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class TutorialDisplay : MonoBehaviour
// {

//     public GameObject Intro;
//     public GameObject Working;
//     public GameObject Next;
//     public GameObject Close;
//     public PauseGame game;

//     // Start is called before the first frame update

//     using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

public class TutorialDisplay : MonoBehaviour
{

    public GameObject Intro;
    public GameObject Working;
    public GameObject Splitter;

    public GameObject Next;
    public GameObject Next1;
    public GameObject Close;
    
    public GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {
         
    	 Intro.SetActive(true);
    	 Next.SetActive(true);
        
    }

  
    public void hideIntro(){
    	Intro.SetActive(false);
    	Next.SetActive(false);

    }

    public void hideWorking(){

    	Working.SetActive(false);
    	Next1.SetActive(false);
    }
  
  public void hideSplitter(){
    	Splitter.SetActive(false);
    	Close.SetActive(false);
        Canvas.SetActive(false);

    }

}

