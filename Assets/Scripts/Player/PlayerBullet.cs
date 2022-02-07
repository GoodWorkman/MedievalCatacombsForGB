using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody _rigidbody;

    private void Start()
    {
       _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //transform.localPosition += transform.forward * speed * Time.deltaTime;
        _rigidbody.velocity = Vector3.forward * speed;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody)
        {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);

    }
}
