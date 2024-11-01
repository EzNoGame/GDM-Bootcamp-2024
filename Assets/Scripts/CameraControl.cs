using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;
    private Vector3 offsetNormalized;

    [SerializeField]
    private float ZoomSpeed;
    [SerializeField]
    private float ZoomMin, ZoomMax;


    [SerializeField]
    private float RotationSpeed;


    void Start()
    {
        offset = transform.position - player.transform.position; 
        offsetNormalized = offset.normalized;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;  
        
        transform.LookAt(player.transform);
    }

    void OnZoom(InputValue movementValue)
    {
        float zoom = movementValue.Get<float>();

        offset = offsetNormalized * Mathf.Clamp(offset.magnitude + ZoomSpeed * Mathf.Sign(zoom), ZoomMin, ZoomMax);
    }

    void OnRotation(InputValue movementValue)
    {
        float rotation = movementValue.Get<float>();

        offsetNormalized = Quaternion.Euler(0, RotationSpeed * Mathf.Sign(rotation), 0) * offsetNormalized;

        offset = offsetNormalized * offset.magnitude;
    }
}