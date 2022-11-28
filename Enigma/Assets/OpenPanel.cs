using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenPanel : MonoBehaviour
{
    public GameObject panelObj;   
    //public static var panelObj;
    // Start is called before the first frame update
    void Start()
    {
    Debug.Log("entered here");
    }
    

    // Update is called once per frame
    void Update()
    {
//panelObj.onClick.Invoke(); 
panelObj.GetComponent<Button>().onClick.Invoke(); 

    }
}
