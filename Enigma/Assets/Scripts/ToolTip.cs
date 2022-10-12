using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[ExecuteInEditMode()] 
public class ToolTip : MonoBehaviour
{
    public TextMeshProUGUI headerField;
    public TextMeshProUGUI contentField;
    public LayoutElement layoutElement;
    public int chracaterWrapLimit;
    // public RectTransform rectTransform;

    // private void Awake(){
    //     rectTransform = GetComponent<RectTransform>();
    // }

    public void SetText(string content,string header=""){
        if (string.IsNullOrEmpty(header)){
            headerField.gameObject.SetActive(false);
        }
        else{
            headerField.gameObject.SetActive(true);
            headerField.text = header;
        }
        contentField.text = content;    
        // int headerLength = headerField.text.Length;
        // int contentLength = contentField.text.Length;

        // layoutElement.enabled = (headerLength > chracaterWrapLimit || contentLength > chracaterWrapLimit) ? true : false;
    }

    // Update is called once per frame
    void Update()
    {
        // if(Application.isEditor){
        //     int headerLength = headerField.text.Length;
        // int contentLength = contentField.text.Length;

        // layoutElement.enabled = (headerLength > chracaterWrapLimit || contentLength > chracaterWrapLimit) ? true : false;
        // }
        
            int headerLength = headerField.text.Length;
        int contentLength = contentField.text.Length;

        layoutElement.enabled = (headerLength > chracaterWrapLimit || contentLength > chracaterWrapLimit) ? true : false;
        // Vector2 position = Input.mousePosition;

        // float pivotX = position.x / Screen.width;
        // float pivotY = position.y / Screen.height;

        // rectTransform.pivot = new Vector2(pivotX,pivotY);

        // transform.position = position;
        
    }
}
