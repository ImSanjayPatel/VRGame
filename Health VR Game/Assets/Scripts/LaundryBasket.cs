using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaundryBasket : MonoBehaviour
{
    public static int LaundryCount = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Clothes")
        {
            LaundryCount = LaundryCount + 1;
        }
        if (collision.gameObject.tag == "c1")
        {
            LaundryCount = LaundryCount + 1;
        }
        if (collision.gameObject.tag == "c2")
        {
            LaundryCount = LaundryCount + 1;
        }
        if (collision.gameObject.tag == "c3")
        {
            LaundryCount = LaundryCount + 1;
        }
    }

    void Update()
    {
        if (LaundryCount == 4)
        {
            Debug.Log("Laundry is away");
        }
    }

}
