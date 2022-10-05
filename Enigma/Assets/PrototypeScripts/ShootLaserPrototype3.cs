using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaserPrototype3 : MonoBehaviour
{
    public Material material;
    LaserBeamPrototype3 beam;

    // Update is called once per frame
    void Update()
    {
        if (beam != null)
        {
            Destroy(beam.laserObj);
        }
        beam = new LaserBeamPrototype3(gameObject.transform.position,gameObject.transform.right,material);
    }
}
