using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleTransition : MonoBehaviour
{
    public bool fuckyeah = false;
    public Vector3 pos;
    public float speed;
    public float bound;
    public bool goingup;
    public bool isSceneTrigger;

    void Update() {
        if (Input.anyKey) {
            fuckyeah = true;
        }
        if (!goingup && fuckyeah && transform.position.y >= bound) {
        	transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);
        }
        if (goingup && fuckyeah && transform.position.y <= bound) {
        	transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);
        }

        if (isSceneTrigger && !goingup && transform.position.y <= bound) {
			SceneManager.LoadScene("OpeningCutscene");
        } else if (isSceneTrigger && goingup && transform.position.y >= bound) {
        	SceneManager.LoadScene("OpeningCutscene");
        }
    }

}
