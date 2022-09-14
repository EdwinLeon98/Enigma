using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerCounter : MonoBehaviour
{
    private TMP_Text displayTimer; 
    public GameObject Timer;
    public int timer = 0;
 
    // Start is called before the first frame update
    void Start()
    {
        displayTimer= Timer.GetComponent<TextMeshProUGUI>();
        StartCoroutine(time());
    }

    // Update is called once per frame
    void Update()
    {
        displayTimer.text= timer.ToString();
        
    }

    IEnumerator time(){
     while (true)
     {
         timeCount();
         yield return new WaitForSeconds(1);
     }
    }  
    void timeCount(){
     timer += 1;
    }

}
