using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBeam{

    Vector3 pos, dir;
    GameObject laserObj;
    GameObject portalObj;

    LineRenderer laser;
    List<Vector3> laserIndices = new List<Vector3>();
    Dictionary<string, float> refractiveMaterials = new Dictionary<string, float> {
        {"Air", 1.0f},
        {"Glass", 1.75f}
    };
    public bool endpoint1;
    public bool endpoint2;
    public bool over;
    Vector3 newpos;
    public bool isPL;
    public int order;
    // Animator anim;

    public LaserBeam(Vector3 pos, Vector3 dir, Material material, string name, 
        Color color, bool endpoint1, bool endpoint2, bool isPL, int order,bool over) {
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
        this.laser.startColor = color;
        this.laser.endColor = color;
        this.laser.sortingOrder = order;
        this.isPL = isPL;
        this.over = over;
        // anim = this.laserObj.AddComponent(typeof(Animator)) as Animator;
        // anim = this.laserObj.GetComponent<Animator>();

        CastRay(this.pos, this.dir, this.laser);
    }

    void CastRay(Vector3 pos, Vector3 dir, LineRenderer laser) {
        laserIndices.Add(pos);

        Ray ray = new Ray(pos,dir);
        RaycastHit hit;
        int layerMask = 321;

        if (Physics.Raycast(ray, out hit, 100, layerMask)){
            CheckHit(hit,dir,laser);
        }
        else{
            laserIndices.Add(ray.GetPoint(30));
            UpdateLaser();
        }

        CheckEndpoint(hit, dir, laser);
        CheckGameOver(hit, dir, laser);
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

    Vector3 Refract(float mu_1, float mu_2, Vector3 norm, Vector3 incident){
        incident.Normalize();
        Vector3 refractedVector = (mu_1/mu_2 * Vector3.Cross(norm, Vector3.Cross(-norm, incident)) - norm * Mathf.Sqrt(1- Vector3.Dot(Vector3.Cross(norm, incident) * (mu_1/mu_2 * mu_1/mu_2), Vector3.Cross(norm, incident)))).normalized;
        return refractedVector;
    }

    void CheckHit(RaycastHit hitInfo, Vector3 direction, LineRenderer laser) {
        if (hitInfo.collider.gameObject.tag == "Vertical" || hitInfo.collider.gameObject.tag == "Horizontal"
            || hitInfo.collider.gameObject.tag == "Mirror" || hitInfo.collider.gameObject.tag == "Rotate") {
            Vector3 pos = hitInfo.point;
            Vector3 dir = Vector3.Reflect(direction, hitInfo.normal);
            CastRay(pos, dir, laser);
        }
        else if (hitInfo.collider.gameObject.tag == "Splitter") {
            if (laserObj.name == "Laser Beam 2") {
                Vector3 pos = hitInfo.point;
                Vector3 dir = direction;
                CastRay(pos, dir, laser);
                UpdateLaser();
            }
            else {
                Vector3 pos = hitInfo.point;
                Vector3 dir = Vector3.Reflect(direction, hitInfo.normal);
                CastRay(pos, dir, laser);
            }
        }
        else if (hitInfo.collider.gameObject.tag == "Refractor") {
            Debug.Log("Hit");
            Vector3 pos = hitInfo.point;
            laserIndices.Add(pos);
            
            // point not on box collider
            Vector3 newPos = new Vector3(
                Mathf.Abs(direction.x)/(direction.x+0.00001f) * 0.001f + pos.x,
                Mathf.Abs(direction.y)/(direction.y+0.00001f) * 0.001f + pos.y,
                Mathf.Abs(direction.z)/(direction.z+0.00001f) * 0.001f + pos.z
                );
            
            float mu_1 = refractiveMaterials["Air"];
            float mu_2 = refractiveMaterials["Glass"];


            Vector3 norm = hitInfo.normal;
            Vector3 incident = direction;

            Vector3 refractedVector = Refract(mu_1, mu_2, norm, incident);
            CastRay(newPos, refractedVector, laser);
        }
        else if (hitInfo.collider.gameObject.tag == "PortalIn"){
            laserIndices.Add(hitInfo.point);
            UpdateLaser();
            ShootLaser.activePL = true;
        }
        else if (hitInfo.collider.gameObject.tag == "ColorChanger") {
            ShootLaser.changeColor = true;
            laser.startColor = ShootLaser.newColor;
            laser.endColor = ShootLaser.newColor;
            Vector3 pos = hitInfo.point;
            Vector3 dir = direction;
            CastRay(pos, dir, laser);
            UpdateLaser();
        }
        else if(hitInfo.collider.gameObject.tag == "Key"){
            


            GameObject key = hitInfo.collider.gameObject;
            key.SetActive(false);
            Debug.Log(GameObject.Find("Cube_But"));
            GameObject.Find("Cube_But").GetComponent<Animator>().Play("Button_Press");
            GameObject.Find("Bulb").SetActive(true);
            // Debug.Log(key);
            // Animator anim = key.GetComponent<Animator>();
            // anim.Play("Button_Press");
            GameObject.Find("Try").GetComponent<Animator>().Play("tryyy");
            // GameObject.Find("Bulb").GetComponent<Animator>().Play("bulb_coming");
            // UpdateLaser();
            // Debug.Log(anim);

            // CastRay(pos, dir, laser);
        }
        else {
            laserIndices.Add(hitInfo.point);
            UpdateLaser();
            if(!isPL){
                ShootLaser.activePL = false;
            }
        }
    }

    // If laser hits the destination
    void CheckEndpoint(RaycastHit hitInfo, Vector3 direction, LineRenderer laser) {
        if (hitInfo.collider.gameObject.name == "Endpoint1") {
            endpoint1 = true;
        }
        else if (hitInfo.collider.gameObject.name == "Endpoint2") {
            endpoint2 = true;
        }
    }
    void CheckGameOver(RaycastHit hitInfo, Vector3 direction, LineRenderer laser){
        if(hitInfo.collider.gameObject.tag == "GameOver"){
            over = true;
        }
    }

}
