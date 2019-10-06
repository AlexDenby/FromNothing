using UnityEngine;
using System.Collections;

 public class KillTrigger : MonoBehaviour
{
    public GameObject myPrefab;
    // Instantiate at position (0, 0, 0) and zero rotation.
    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.name == "Player")
        {
            //For stopping the same object
            //GetComponent<PlayerController>().enabled = false;
            //Pass through (destroy right now) object
            //Destroy(col.gameObject);
            //For stopping other object
            GameObject.Find("Player").GetComponent<PlayerController>().enabled = false;
            GameObject.Find("Canvas").GetComponent<Fade5>().enabled = true;
            // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
            Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }      

    }
}

