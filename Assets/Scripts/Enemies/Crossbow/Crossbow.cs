using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : MonoBehaviour
{
    public Transform partToRotate;
    public Transform target;
    public Transform muzzle;
    public Transform arrowPrefab;
    
    
    private void Update()
    {
        partToRotate.LookAt(target);
       
    }

    private void CreateArrow()
    {
        
    }
}
