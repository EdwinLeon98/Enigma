using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeam{

    Vector3 pos, dir;
    GameObject laserObj;
    LineRenderer laser;
    List<Vector3> laserIndices = new List<Vector3>();
    Dictionary<string, float> refractiveMaterials = new Dictionary<string, float> {
        {"Air", 1.0f},
        {"Glass", 1.5f}
    };
    public bool endpoint1;
    public bool endpoint2;
    Vector3 newpos;

    public LaserBeam(Vector3 pos, Vector3 dir, Material material, string name, Color color, bool endpoint1, bool endpoint2) {
        this.laser = new LineRenderer();
        this.laserObj = new GameObject();
        this.laserObj.name = name;
        this.pos = pos;
        this.dir = dir;
        this.endpoint1 = endpoint1;
        this.endpoint2 = endpoint2;

        this.laser = this.laserObj.AddComponent(typeof(LineRenderer)) as LineRenderer;
        this.laser.startWidth = 0.08f;
        this.laser.endWidth = 0.08f;
        this.laser.material = material;
        // Debug.Log("Color:" + color);
        this.laser.startColor = color;
        this.laser.endColor = color;

        CastRay(this.pos, this.dir, this.laser);
    }

    void CastRay(Vector3 pos, Vector3 dir, LineRenderer laser) {
        laserIndices.Add(pos);

        Ray ray = new Ray(pos,dir);
        RaycastHit hit;
        int layerMask = 321;
        //if(laserObj.name == "Laser Beam 2") {
        //    Debug.Log("layermask");
        //    layerMask = 320;
        //}

        if (Physics.Raycast(ray, out hit, 100, layerMask)){
            CheckHit(hit,dir,laser);
        }
        else{
            laserIndices.Add(ray.GetPoint(30));
            UpdateLaser();
        }

        CheckEndpoint(hit, dir, laser);
    }

    void UpdateLaser() {
        int count = 0;
        laser.positionCount = laserIndices.Count;
        foreach(Vector3 idx in laserIndices){
            laser.SetPosition(count, idx);
            count++;
        }
    }

    Vector3 Split(Vector3 norm, Vector3 incident) {
        norm.Normalize();
        Vector3 refractedVector;

        refractedVector.y = incident.y;
        refractedVector.x = 0.707f * (incident.x);
        refractedVector.z = incident.z;
        return refractedVector;
    }

    void CheckHit(RaycastHit hitInfo, Vector3 direction, LineRenderer laser) {
        //Debug.Log("Hit tag: " + hitInfo.collider.gameObject.tag);
        //Debug.Log("Hit layer: " + hitInfo.collider.gameObject.layer);
        if (hitInfo.collider.gameObject.tag == "Vertical" || hitInfo.collider.gameObject.tag == "Horizontal" || hitInfo.collider.gameObject.tag == "Mirror") {
            Vector3 pos = hitInfo.point;
            Vector3 dir = Vector3.Reflect(direction, hitInfo.normal);
            CastRay(pos, dir, laser);
        }
        else if (hitInfo.collider.gameObject.tag == "Splitter") {
            if (laserObj.name == "Laser Beam 2") {
                Vector3 pos = hitInfo.point;
                Vector3 dir = direction;
                //newpos = Split(direction, -hitInfo.normal);
                //if (newpos.z >= 0) {
                //    newpos.x = direction.x;
                //}
                //else {
                //    newpos.x = -1;
                //}
                //Vector3 dir = newpos;
                //Debug.Log("Pos: " + newpos);
                //Debug.Log("Split Return: " + Split(direction, -hitInfo.normal));
                CastRay(pos, dir, laser);
                UpdateLaser();
            }
            else {
                Vector3 pos = hitInfo.point;
                Vector3 dir = Vector3.Reflect(direction, hitInfo.normal);
                CastRay(pos, dir, laser);
            }
        }
        else {
            laserIndices.Add(hitInfo.point);
            UpdateLaser();
        }
    }

    void CheckEndpoint(RaycastHit hitInfo, Vector3 direction, LineRenderer laser) {
        if (hitInfo.collider.gameObject.name == "Endpoint1") {
            endpoint1 = true;
            // Debug.Log("Endpoint set to true: " + hitInfo.collider.gameObject.name);
        }
        else if (hitInfo.collider.gameObject.name == "Endpoint2") {
            endpoint2 = true;
        }
    }
}
