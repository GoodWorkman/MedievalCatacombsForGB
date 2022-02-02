using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _fillImage;

    private void Start()
    {
        FindObjectOfType<PlayerHealth>().takeDamage += UpdateImage;
    }

    private void UpdateImage(float value)
    {
        _fillImage.fillAmount = value;
    }

    private void OnDestroy()
    {
        FindObjectOfType<PlayerHealth>().takeDamage -= UpdateImage;
    }
}
