using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpControl : MonoBehaviour
{
    private Rigidbody rb; 

    [SerializeField]
    private float jumpForce;

    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnJump()
    {
        if(!isGrounded) return;

        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    void FixedUpdate()
    {
        GroundCheck();
    }

    private void GroundCheck()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, 1.1f);
    }
}
