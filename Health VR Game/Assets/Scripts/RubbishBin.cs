using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubbishBin : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Rubbish" )
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag != "Rubbish1")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag != "r1")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag != "r2")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag != "r3")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag != "r4")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag != "r5")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag != "r6")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag != "r7")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag != "r8")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag != "r9")
        {
            Destroy(collision.gameObject);
        }
    }
}
