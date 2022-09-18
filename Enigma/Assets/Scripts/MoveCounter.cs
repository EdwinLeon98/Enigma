using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class MoveCounter : MonoBehaviour
{
    private TMP_Text displayText; 
    public GameObject displayMoves;  
    
    // Start is called before the first frame update
    void Start()
    {
          displayText = displayMoves.GetComponent<TextMeshProUGUI>();
    }   

    // Update is called once per frame
    void Update()
    {
        //if (!GameObject.Find("LevelComplete")) {
            displayText.text = "Moves: " + MovePrototype2.numberOfMoves.ToString();
        //}
        Debug.Log("# of Moves: " + MovePrototype2.numberOfMoves);
    }
}

