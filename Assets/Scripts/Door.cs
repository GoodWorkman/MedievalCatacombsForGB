﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Vector3 _closeRotation;
    [SerializeField] private Vector3 _openRotation;
    [SerializeField] private float _speedRotation;
    private Vector3 _targetRotation;
    public void OpenCloseDoor(bool opened)
    {
        _targetRotation = opened ? _openRotation : _closeRotation;
        if(_isRun) return;
        StartCoroutine(SetPosition());
    }

    private bool _isRun;
    private IEnumerator SetPosition()
    {
        _isRun = true;
        for (float i = 0; i < 1; i+=Time.deltaTime * _speedRotation)
        {
            transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(_targetRotation), i);
            yield return null;
        }
        transform.localRotation = Quaternion.Euler(_targetRotation);
        _isRun = false;
    }
}
