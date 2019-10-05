using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour {

    void OnCollisionEnter()
    {
        Debug.log(Collided);
    }
    void OnCollisionEnter(Collision obj)
    {
        If(obj.gameobject.name==myObject);
        {
            Debug.log(Collided with+obj);
        }
    }
}