using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileText : MonoBehaviour
{
    public GameObject child;
    public GameObject parent;
    Vector3 initialPos;

    // Start is called before the first frame update
    void Start() {
        //Debug.Log("Child: " + child);
        // Debug.Log("Parent Position: " + parent.transform.position);
        initialPos = parent.transform.position;
    }

    // Update is called once per frame
    void LateUpdate() {
        // Debug.Log("Parent Position: " + parent.transform.position);

        if (initialPos != parent.transform.position && Input.GetMouseButtonUp(0)) {
            child.SetActive(false);
        }
    }
}
