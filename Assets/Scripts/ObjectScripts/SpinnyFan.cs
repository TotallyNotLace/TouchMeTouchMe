using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnyFan : MonoBehaviour
{

    [SerializeField] private float _rotationSpeed = 300f;
    [SerializeField] private GameObject _fan;
    [SerializeField] private Vector3 _rotationAxis;
    void Update()
    {
        _fan.transform.Rotate(_rotationAxis, _rotationSpeed * Time.deltaTime);
    }
}
