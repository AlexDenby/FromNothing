using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeGenCopy : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameObject CreateInstance(GameObject obj, Vector3 pos)
    {
        return Instantiate(obj, pos, Quaternion.identity);
    }
}