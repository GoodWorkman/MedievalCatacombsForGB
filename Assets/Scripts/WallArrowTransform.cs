using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;

public class WallArrowTransform : MonoBehaviour
{
    [SerializeField] private float _damage = 1;
    public float speed = 4f;
    public float timeDelay = 3f;
    private void Start()
    {
        InvokeRepeating(nameof(DestroyArrow), timeDelay, timeDelay);
    }

    private void Update()
    {
        //transform.Translate(Vector3.forward *Time.deltaTime*speed);
        transform.localPosition += transform.forward * Time.deltaTime * speed;

    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision with " + collision.gameObject.name);

        
        //PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
        //collision.rigidbody == null;
        if (collision.rigidbody)//!= null)
        {
            print("1");
            PlayerHealth playerHealth = collision.rigidbody.GetComponent<PlayerHealth>();
            if (playerHealth)
            {
                print("2");
                playerHealth.TakeDamage(_damage);
            }
        }
        
        Destroy(gameObject);
    }


    private void DestroyArrow()
    {
        Destroy(gameObject);
    }
}
