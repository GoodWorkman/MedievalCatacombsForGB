using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
   public LayerMask layers;
   public float radiusExplosion = 3f;
   public float explosionForce = 1200f;
   public GameObject explosionEffect;

   private bool explose = false;

   public void Explose()
   {
      Collider[] colliders = Physics.OverlapSphere(transform.position, radiusExplosion, layers);
      for (int i = 0; i < colliders.Length; i++)
      {
         if (colliders[i].gameObject != gameObject && colliders[i].gameObject.GetComponent<Rigidbody>() != null)
         {
            explose = true;
            colliders[i].gameObject.GetComponent<Rigidbody>()
               .AddExplosionForce(explosionForce, transform.position, radiusExplosion*3);
         }
      }
      if (explose)
      {
         Instantiate(explosionEffect, transform.position, Quaternion.identity);
         Destroy(gameObject);
      }
   }

   private void OnDrawGizmos()
   {
      Gizmos.DrawWireSphere(transform.position, radiusExplosion);
   }
}
