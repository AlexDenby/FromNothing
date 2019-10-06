using UnityEngine;
using System.Collections;

 public class KillTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "P0")
        {
            Destroy(col.gameObject);
        }
    }
}

