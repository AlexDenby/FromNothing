using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade4 : MonoBehaviour
{
    IEnumerator Fade()
    {
        void Update()
        {
            if (Input.GetKeyDown("f"))
            {
                StartCoroutine("Fade");
            }
        }
        for (float ft = 1f; ft >= 0; ft -= 0.1f)
        {
            Color c = GetComponent<Color>();
            c.a = ft;
            c = GetComponent<Color>();
            yield return new WaitForSeconds(.1f);
        }
    }

}