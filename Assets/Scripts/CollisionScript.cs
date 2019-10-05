/*using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour {

    public void FadeMe(){
        StartCoroutine (DoFade());
    }
    void OnCollisionEnter()
    {
        Debug.log(Collided);
    }
    void OnCollisionEnter(Collision obj)
    {
        If(obj.gameobject.name==myObject);
        {
            IEnumerator DoFade (){
                CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
                while (canvasGroup.alpha>0){
                    canvasGroup.alpha -= Time.deltaTime / 2;
                    yield return null;
                }
                canvasGroup.interactable = false;
                yield return null;
                }
            }
        }
    }*/