using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(moveSpeed > 1)
        {
            moveSpeed = moveSpeed - 0.0001f;
        }



        /*
        if (moveSpeed >  1.0f)
       {
           moveSpeed = moveSpeed - 0.0001f;
       }

         //Moves Forward and back along z axis                           //Up/Down
        transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
        
        //Moves Left and right along x Axis                               //Left/Right
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);


            while (moveSpeed < 5)
        {
            //Moves Forward and back along z axis                           //Up/Down
            transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);

            //Moves Left and right along x Axis                               //Left/Right
            transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);

            moveSpeed = moveSpeed + 0.0001;

            if(moveSpeed == 5)
            {
                while(moveSpeed > 1)
                {

                }

            }
        }
        
        */




    }
}
