using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hands : MonoBehaviour
{
    public LayerMask Layer;
    private Vector3 PreviousPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit Hit;

        if(Physics.Raycast(transform.position, transform.forward, out Hit, 1, Layer))
        {
            if(Vector3.Angle(transform.position-PreviousPos, Hit.transform.up) >0)
            {
                Destroy(Hit.transform.gameObject);
            }
        }

        PreviousPos = transform.position;
    }
}
