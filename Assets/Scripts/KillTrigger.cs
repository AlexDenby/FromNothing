using UnityEngine;
using System.Collections;

 public class KillTrigger : MonoBehaviour
{
    public GameObject myPrefab;
    // Instantiate at position (0, 0, 0) and zero rotation.
    public GameObject Progression;
    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Player")
        {
            Progression.GetComponent<ProgressionHandler>().Kill();
            //For stopping the same object
            //GetComponent<PlayerController>().enabled = false;
            //Destroy object
            //Destroy(col.gameObject);
            //For stopping other object
            //GameObject.Find("GameObject").GetComponent<ProgressionHandler>().enabled = true;
            //Destroy(col.gameObject);
            /*//For stopping other object
            GameObject.Find("Player2").GetComponent<PlayerController>().enabled = false;
            //Destroy object
            Destroy(col.gameObject);
            //For stopping other object
            GameObject.Find("Player3").GetComponent<PlayerController>().enabled = false;
            //Destroy object
            Destroy(col.gameObject);
            //For stopping other object
            GameObject.Find("Player4").GetComponent<PlayerController>().enabled = false;
            //Destroy object
            Destroy(col.gameObject);
            //For stopping other object
            GameObject.Find("Player5").GetComponent<PlayerController>().enabled = false;
            //Destroy object
            Destroy(col.gameObject);
            GameObject.Find("Canvas").GetComponent<Fade5>().enabled = true;
            */
            // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
            //Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);


        }      

    }
}

