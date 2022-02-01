﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 10;
    private float _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    
    public delegate void DefoultFloat(float value);

    public event DefoultFloat takeDamage;
    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        takeDamage?.Invoke(_currentHealth/_maxHealth);
    }
}

