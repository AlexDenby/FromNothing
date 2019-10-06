using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrollCutscene : MonoBehaviour
{

	public Vector3 pos;

    void Start()
    {
    	pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    	if (transform.position.x >= -29.5f) {
    		pos.x -= .02f;
        	transform.position = pos;
        } else {
			SceneManager.LoadScene("Nixfield");
        }
    }
        
}
