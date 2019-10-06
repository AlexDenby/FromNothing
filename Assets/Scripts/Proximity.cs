using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proximity : MonoBehaviour
{
    private Material _material;

    private void Start()
    {
        _material = GetComponent<MeshRenderer>().material;
    }

    private void Update()
    {
        var distance = Mathf.Abs(Camera.main.transform.position.z - transform.position.z);
        _material.SetFloat("_Distance", distance);
    }
}

