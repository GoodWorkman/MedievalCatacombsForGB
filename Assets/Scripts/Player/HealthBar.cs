using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _fillImage;

    private void OnEnable()
    {
        FindObjectOfType<PlayerHealth>().takeDamage += UpdateImage;
    }

    private void UpdateImage(float value)
    {
        _fillImage.fillAmount = value;
    }

    private void OnDisable()
    {
        FindObjectOfType<PlayerHealth>().takeDamage -= UpdateImage;
    }
}
