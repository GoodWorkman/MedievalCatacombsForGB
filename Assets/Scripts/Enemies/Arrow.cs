using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
   public float speed;
   private Rigidbody _rigidbody;
   
  
   private void Start()
   {
      _rigidbody = GetComponent<Rigidbody>();
   }

   private void FixedUpdate()
   {  
      _rigidbody.velocity = transform.forward * speed;
   }


   private void OnCollisionEnter(Collision collision)
   {
      Destroy(gameObject);
   }
}
