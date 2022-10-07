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
    
public void Start()
{
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
        if(hintTile1!=null)
        hintTile1.SetActive(!hintTile1.activeInHierarchy);
        if(hintTile2!=null)
        hintTile2.SetActive(!hintTile2.activeInHierarchy);
        if(hintTile3!=null)
        hintTile3.SetActive(!hintTile3.activeInHierarchy);
        if(hintTile4!=null)        
        hintTile4.SetActive(!hintTile4.activeInHierarchy);
        if(hintTile5!=null)        
        hintTile5.SetActive(!hintTile5.activeInHierarchy);
        
    }
}
