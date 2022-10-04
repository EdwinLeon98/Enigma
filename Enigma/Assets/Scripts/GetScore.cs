using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetScore : MonoBehaviour
{
    private TMP_Text score;
    public GameObject FinalScore;
    public int Star1score;
    public int Star2score;
    public int Star3score;
    GameObject star1;
    GameObject star2;
    GameObject star3;
    Image star1Image;
    Image star2Image;
    Image star3Image;
    Color tempColor;
    public static bool gotStar1 = false;
    public static bool gotStar2 = false;
    public static bool gotStar3 = false;

    // Start is called before the first frame update
    void Start()
    {
        star1 = GameObject.Find("Star1");
        star2 = GameObject.Find("Star2");
        star3 = GameObject.Find("Star3");
        star1Image = star1.GetComponent<Image>();
        star2Image = star2.GetComponent<Image>();
        star3Image = star3.GetComponent<Image>();
        score = FinalScore.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + RatingSystem.score;
        if(RatingSystem.score >= Star3score) {
            ChangeColor(star3Image);
            ChangeColor(star2Image);
            ChangeColor(star1Image);
            gotStar3 = true;
        }
        else if(RatingSystem.score < Star3score && RatingSystem.score >= Star2score) {
            ChangeColor(star2Image);
            ChangeColor(star1Image);
            gotStar2 = true;
        }
        else if(RatingSystem.score < Star2score && RatingSystem.score >= Star1score) {
            ChangeColor(star1Image);
            gotStar1 = true;
        }
        else {
            //Do Nothing;
        }
    }

    void ChangeColor(Image image) {
        tempColor = image.color;
        tempColor = Color.white;
        image.color = tempColor;
    }
}
