using UnityEngine;
using System.Collections;

 public class KillTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "NPC")
        {
            Destroy(col.gameObject);
            GameObject.Find("Player").GetComponent<PlayerController>().enabled = false;
        }
        
    }
}

