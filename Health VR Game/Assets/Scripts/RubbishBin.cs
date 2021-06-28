using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using UnityEngine.SceneManagement;

public class RubbishBin : MonoBehaviour
{
    private int RubbishCount = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Rubbish" )
        {
            RubbishCount = RubbishCount + 1;
        }
        if (collision.gameObject.tag == "Rubbish1")
        {
            RubbishCount = RubbishCount + 1;
        }
        if (collision.gameObject.tag == "r1")
        {
            RubbishCount = RubbishCount + 1;
        }
        if (collision.gameObject.tag == "r2")
        {
            RubbishCount = RubbishCount + 1;
        }
        if (collision.gameObject.tag == "r3")
        {
            RubbishCount = RubbishCount + 1;
        }
        if (collision.gameObject.tag == "r4")
        {
            RubbishCount = RubbishCount + 1;
        }
        if (collision.gameObject.tag == "r5")
        {
            RubbishCount = RubbishCount + 1;
        }
        if (collision.gameObject.tag == "r6")
        {
            RubbishCount = RubbishCount + 1;
        }
        if (collision.gameObject.tag == "r7")
        {
            RubbishCount = RubbishCount + 1;
        }
        if (collision.gameObject.tag == "r8")
        {
            RubbishCount = RubbishCount + 1;
        }
        if (collision.gameObject.tag == "r9")
        {
            RubbishCount = RubbishCount + 1;
        }
    }

    void Update()
    {


        if (RubbishCount == 1 && LaundryBasket.LaundryCount == 1)
        {
            Debug.Log("Everything is away");
            SceneManager.LoadScene("Lunch2");
        }
    }
}
