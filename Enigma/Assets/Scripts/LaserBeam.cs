using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeam{
    
    Vector3 pos, dir;
    GameObject laserObj;
    GameObject laser2Obj;
    LineRenderer laser;
    LineRenderer laser2;
    List<Vector3> laserIndices = new List<Vector3>();
    List<Vector3> laserIndices2 = new List<Vector3>();
    Dictionary<string,float> refractiveMaterials = new Dictionary<string,float>
    {
        {"Air",1.0f},
        {"Glass",1.5f}
    };

    public LaserBeam(Vector3 pos, Vector3 dir, Material material){
        this.laser = new LineRenderer();
        this.laserObj = new GameObject();
        this.laserObj.name = "Laser Beam";
        this.pos = pos;
        this.dir = dir;

        this.laser = this.laserObj.AddComponent(typeof(LineRenderer)) as LineRenderer;
        this.laser.startWidth = 0.08f;
        this.laser.endWidth = 0.08f;
        this.laser.material = material;
        this.laser.startColor = Color.red;
        this.laser.endColor = Color.red;

        CastRay(this.pos, this.dir, this.laser);


        this.laser2 = new LineRenderer();
        this.laser2Obj = new GameObject();
        this.laser2Obj.name = "Laser2 Beam";
        
        this.laser2 = this.laser2Obj.AddComponent(typeof(LineRenderer)) as LineRenderer;
        this.laser2.startWidth = 0.08f;
        this.laser2.endWidth = 0.08f;
        this.laser2.material = material;
        this.laser2.startColor = Color.green;
        this.laser2.endColor = Color.green;

        CastRay2(this.pos, this.dir, this.laser2);
    }

    void CastRay2(Vector3 pos, Vector3 dir, LineRenderer laser2){
        laserIndices2.Add(pos);
        Ray ray = new Ray(pos,dir);
        RaycastHit hit;
        int layerMask = 1 << 7;
    
        if (Physics.Raycast(ray, out hit, 30, ~layerMask)){
            CheckHit2(hit,dir,laser2);
        }
        else{
            laserIndices2.Add(ray.GetPoint(30));
            UpdateLaser2();
        }          
    }

    void CastRay(Vector3 pos, Vector3 dir, LineRenderer laser){
        laserIndices.Add(pos);
        Ray ray = new Ray(pos,dir);
        RaycastHit hit;
        int layerMask = 1 << 7;
    
        if (Physics.Raycast(ray, out hit, 100, ~layerMask)){
            CheckHit(hit,dir,laser);
        }
        else{
            laserIndices.Add(ray.GetPoint(30));
            UpdateLaser();
        }
    }

    void UpdateLaser(){
        int count = 0;
        Debug.Log("Update Laser 1   " + laserIndices.Count);
        laser.positionCount = laserIndices.Count;  
        foreach(Vector3 idx in laserIndices){
            laser.SetPosition(count, idx);
            count++;
        }
    }

    void UpdateLaser2(){
        int count = 0;
        Debug.Log("Update Laser 2   " + laserIndices.Count);
        laser2.positionCount = 200;
        foreach(Vector3 idx in laserIndices2){
            laser2.SetPosition(count, idx);
            count++;
        }
    }


    // sends a laser on X component
    Vector3 Split(Vector3 norm, Vector3 incident){
        norm.Normalize();
        incident.Normalize();
        Vector3 refractedVector;
        refractedVector.y = incident.y;
        refractedVector.x = 0.707f*(incident.x);
        refractedVector.z = incident.z;
        return refractedVector;
    }

    // send laser on Z component
    Vector3 Split2(Vector3 norm, Vector3 incident){
        norm.Normalize();
        incident.Normalize();
        Vector3 refractedVector;
        refractedVector.y = incident.y;
        refractedVector.x = incident.x;
        refractedVector.z = 0.707f*incident.z;
        return refractedVector;
    }

    void CheckHit(RaycastHit hitInfo, Vector3 direction, LineRenderer laser){
        Debug.Log("Hit tag: " + hitInfo.collider.gameObject.tag);
        Debug.Log("Hit layer: " + hitInfo.collider.gameObject.layer);

        if (hitInfo.collider.gameObject.tag == "Vertical" || hitInfo.collider.gameObject.tag == "Horizontal" || hitInfo.collider.gameObject.tag == "Mirror" || hitInfo.collider.gameObject.tag == "Splitter"){
            Vector3 pos = hitInfo.point;
            Vector3 dir = Vector3.Reflect(direction,hitInfo.normal);
            CastRay(pos,dir,laser);
        } else if (hitInfo.collider.gameObject.tag == "Splitter"){
            // TO DO: refactor to send laser on X component
            Vector3 pos = hitInfo.point;
            Vector3 dir = Split(direction,-hitInfo.normal);
            CastRay(pos,dir,laser);
        }
        else{
            laserIndices.Add(hitInfo.point);
            UpdateLaser();
        }
    }

    void CheckHit2(RaycastHit hitInfo, Vector3 direction, LineRenderer laser){
        Debug.Log("Hit tag: " + hitInfo.collider.gameObject.tag);
        Debug.Log("Hit layer: " + hitInfo.collider.gameObject.layer);

        // TO DO: update tag for tiles, as tiles increase in number this condition will be hard to maintain
        if (hitInfo.collider.gameObject.tag == "Vertical" || hitInfo.collider.gameObject.tag == "Horizontal" || hitInfo.collider.gameObject.tag == "Mirror"){
            Vector3 pos = hitInfo.point;
            Vector3 dir = Vector3.Reflect(direction,hitInfo.normal);
            CastRay2(pos,dir,laser);

        } else if (hitInfo.collider.gameObject.tag == "Splitter"){
            Vector3 pos = hitInfo.point;
            Vector3 dir = Split2(direction,-hitInfo.normal);
            CastRay2(pos,dir,laser);
        }
        else{
            laserIndices2.Add(hitInfo.point);
            UpdateLaser2();
        }
    }

}

