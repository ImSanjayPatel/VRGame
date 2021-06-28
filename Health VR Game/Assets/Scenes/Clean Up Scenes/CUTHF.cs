﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class CUTHF : MonoBehaviour
{
    private float speed = 3.5F;     // Speed of the movement 
    public XRNode inputSource;
    public float gravity = -9.81f;
    public LayerMask groundLayer;
    private float fallingSpeed;
    private XRRig rig;
    public float addtionalHeight = 0.2f;
    private Vector2 inputAxis;
    private CharacterController character;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        rig = GetComponent<XRRig>();
    }

    // Update is called once per frame
    void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
    }

    private void FixedUpdate() // Everytime unity updates the physics 
    {
        CapsuleFollowHeadset();

        Quaternion headYaw = Quaternion.Euler(0, rig.cameraGameObject.transform.eulerAngles.y, 0);
        Vector3 direction = headYaw * new Vector3(inputAxis.x, 0, inputAxis.y); //  Move in the direction the player is facing 

        character.Move(direction * Time.fixedDeltaTime * speed);
        

        if(speed < 2)
        {
            speed = speed;
        }
        else
        {
            speed = speed - 0.00015f;
        }

        Debug.Log(speed);

        //gravity

        /*
      
         bool isGrounded = CheckIfGrounded();

        if (isGrounded)
            fallingSpeed = 0;
        else
            fallingSpeed += gravity + Time.fixedDeltaTime;

        character.Move(Vector3.up * fallingSpeed * Time.fixedDeltaTime);

        */
         
    }

    void CapsuleFollowHeadset()
    {
        character.height = rig.cameraInRigSpaceHeight + addtionalHeight;
        Vector3 capsuleCenter = transform.InverseTransformPoint(rig.cameraGameObject.transform.position);
        character.center = new Vector3(capsuleCenter.x, character.height / 2 + character.skinWidth, capsuleCenter.z);
    }

    bool CheckIfGrounded()
    {
        // check if on ground or not 
        Vector3 rayStart = transform.TransformPoint(character.center);
        float rayLength = character.center.y + 0.01f;
        bool hasHit = Physics.SphereCast(rayStart, character.radius, Vector3.down, out RaycastHit hitInfo, rayLength, groundLayer);
        return hasHit;

    }
}