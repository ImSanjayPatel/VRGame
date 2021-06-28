using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public float speeddecrease = 0.01f;
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * speed; // Possibily minipulate the speed 

        speed = speed - speeddecrease;



        //Debug.Log(speed);
    }
}
