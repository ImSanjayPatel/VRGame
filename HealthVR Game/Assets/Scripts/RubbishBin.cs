using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubbishBin : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Rubbish")
        {
            Destroy(collision.gameObject);
        }
    }
}
