using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CopyScore : MonoBehaviour
{
    GameObject temp;
    GetScore value;
    private TMP_Text score;
    public GameObject SetScore;

    // Start is called before the first frame update
    void Start()
    {
        temp = GameObject.Find("Score");
        value = temp.GetComponent<GetScore>();
        score = SetScore.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.name == "Star1Score") { 
            score.text = value.Star1score.ToString();
        }
        else if (gameObject.name == "Star2Score") {
            score.text = value.Star2score.ToString();
        }
        else if (gameObject.name == "Star3Score") {;
            score.text = value.Star3score.ToString();
        }
    }
}
