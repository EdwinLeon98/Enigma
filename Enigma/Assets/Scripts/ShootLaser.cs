using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaser : MonoBehaviour{
    
    public Material material;
    EdwinLaser beam;
    EdwinLaser beam2;
    string name;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos = gameObject.transform.position;
        pos.y = pos.y - 0.01f;
    }

    // Update is called once per frame
    void Update(){ 
        Destroy(GameObject.Find("Laser Beam"));
        Destroy(GameObject.Find("Laser Beam 2"));
        Debug.Log(gameObject.transform.position);
        name = "Laser Beam";
        beam = new EdwinLaser(gameObject.transform.position, gameObject.transform.right, material, name, Color.red);
        name = "Laser Beam 2";
        beam2 = new EdwinLaser(pos, gameObject.transform.right, material, name, Color.green);
    }
}
