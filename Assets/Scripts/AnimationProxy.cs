using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationProxy : MonoBehaviour
{
    public Animator animator;
    public bool move;

    void Update() {
    	
    	if (move) {
    		animator.SetBool( "Walk", true );
    	} else {
    		animator.SetBool( "Walk", false );
    	}
    	
    }
}
