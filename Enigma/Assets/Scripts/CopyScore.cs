using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CopyScore : MonoBehaviour
{
    GameObject temp; //Temp holder for Game Object
    GetScore value; //Score value for star
    private TMP_Text score; //Variable to write to the the score for each star
    public GameObject SetScore; //Variable to get the reference to the text object

    // Start is called before the first frame update
    void Start() {
        temp = GameObject.Find("Score");    //Get the Game Object that contains the score for each star
        value = temp.GetComponent<GetScore>();
        score = SetScore.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update() {
        if(gameObject.name == "Star1Score") {   //Set score for the first star
            score.text = value.Star1score.ToString();
        }
        else if (gameObject.name == "Star2Score") { //Set score for the second star
            score.text = value.Star2score.ToString();
        }
        else if (gameObject.name == "Star3Score") { //Set score for the third star
            score.text = value.Star3score.ToString();
        }
    }
}
