using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallArrSpawn : MonoBehaviour
{
   public Transform muzzle;
   public GameObject arrowPrefab;
   public float delaySpawn = 1f;

   private void Start()
   {
      InvokeRepeating(nameof(CreateArrow),delaySpawn,delaySpawn);
   }

   private void CreateArrow()
   {
      Instantiate(arrowPrefab, muzzle.position, transform.rotation);
   }
}
