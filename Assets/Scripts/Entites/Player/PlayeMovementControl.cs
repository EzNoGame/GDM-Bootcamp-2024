using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementController : MonoBehaviour
{
   private Rigidbody rb; 

   private float movementX;
   private float movementY;

   public float speed = 0; 

   void Start()
   {
      rb = GetComponent<Rigidbody>();
   }
 
   void OnMove(InputValue movementValue)
   {
      Vector2 movementVector = movementValue.Get<Vector2>().normalized;

      movementX = movementVector.x; 
      movementY = movementVector.y; 
   }

   private void FixedUpdate() 
   {
      Vector3 movement = movementY * transform.forward + movementX * transform.right;
      rb.AddForce(movement * speed); 
   }
}