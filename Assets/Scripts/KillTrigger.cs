using UnityEngine;
using System.Collections;

 public class KillTrigger : MonoBehaviour
{
    private IEnumerator coroutine;

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.name == "Player")
        {
            //Progression.GetComponent<ProgressionHandler>().Kill();
            //For stopping the same object
            //GetComponent<PlayerController>().enabled = false;
            //Destroy object
            //Destroy(col.gameObject);
            //For stopping other object
            //GameObject.Find("GameObject").GetComponent<ProgressionHandler>().enabled = true;
            //Destroy(col.gameObject);
            //For stopping other object
            GameObject.Find("Player").GetComponent<PlayerController>().enabled = false;
            /*//Destroy object
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
            */
            GameObject.Find("Canvas").GetComponent<Fade5>().enabled = true;
            // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
            //Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);


            
            coroutine = Wait();
            StartCoroutine(coroutine);

            GameObject.Find("Player").GetComponent<PlayerController>().enabled = true;
            GameObject.Find("Canvas").GetComponent<Fade5>().enabled = false;

            Transform pos = GameObject.Find("Player").GetComponent<Transform>();
            Vector3 spawn = new Vector3(0, 11, -9);
            pos.transform.position = spawn;

        }

    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(10);
    }
}

