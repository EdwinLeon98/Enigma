using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintDisplay : MonoBehaviour
{
    public GameObject hintTile1;
    public GameObject hintTile2;
    public GameObject hintTile3;
    public GameObject hintTile4;
    public GameObject hintTile5;
    public static int numberOfClicks;
    public static bool usedHints;
    
    public void Start() {
        numberOfClicks=0;
        usedHints = false;
        if(hintTile1!=null)
            hintTile1.SetActive(false);
        if(hintTile2!=null)
            hintTile2.SetActive(false);
        if(hintTile3!=null)
            hintTile3.SetActive(false);
        if(hintTile4!=null)
            hintTile4.SetActive(false);
        if(hintTile5!=null)
            hintTile5.SetActive(false);
    }
    
    public void displayHintTile() {
        numberOfClicks++;
        usedHints = true;
        if(hintTile1!=null && numberOfClicks==1)
            hintTile1.SetActive(true);
        if(hintTile2!=null && numberOfClicks==2)
            hintTile2.SetActive(true);
        if(hintTile3!=null && numberOfClicks==3)
            hintTile3.SetActive(true);
        if(hintTile4!=null && numberOfClicks==4)        
            hintTile4.SetActive(true);
        if(hintTile5!=null && numberOfClicks==5)        
            hintTile5.SetActive(true);
    }
}
