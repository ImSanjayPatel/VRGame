using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGameObj : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        // Need the pedastoll to reappear 
        if (GameObject.Find ("Rubbish") == null)
        {
            //gameObject.SetActive(true);       // Right way
            //gameObject.SetActive(false);        // Working way
        }
        else
        {
            //gameObject.SetActive(false);
            //gameObject.SetActive(true);
        }
        
    }
}
