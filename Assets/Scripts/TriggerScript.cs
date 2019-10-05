using UnityEngine;
using System.Collections;

public class TriggerScript : MonoBehaviour {

    void OnTriggerEnter()
    {
        Debug.log(Triggered);
    }
    void OnTriggerEnter(Collider obj)
    {
        If(obj.gameobject.name==myObject);
        {
            Debug.log(Triggered by+obj);
        }
    }
}