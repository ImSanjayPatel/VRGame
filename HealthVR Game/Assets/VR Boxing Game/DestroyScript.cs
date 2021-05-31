using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "LeftHandBox")
        {
            Destroy(col.gameObject);
        }
        if (col.gameObject.name == "RightHandBox")
        {
            Destroy(col.gameObject);
        }
    }
}
