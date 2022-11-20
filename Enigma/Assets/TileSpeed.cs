using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpeed : MonoBehaviour
{
    public static float tileSpeed = 250;
    public static float rotationSpeed = 100;

    public void AdjustTileSpeed(float newSpeed) {
        tileSpeed = newSpeed;
    }

    public void AdjustRotationSpeed(float newSpeed) {
        rotationSpeed = newSpeed;
    }
}
