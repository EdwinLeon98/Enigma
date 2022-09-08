using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTileCollision : MonoBehaviour
{
    public BoxCollider tileCollider;
    public BoxCollider tileBlockerCollider;

    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreCollision(tileCollider, tileBlockerCollider, true);
    }

}
