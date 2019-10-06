using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;

    public Animator animator;

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        // Rotate around y - axis
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        // Move forward / backward
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);
    }

    void FixedUpdate() {
        float move = Input.GetAxis ("Horizontal");

        if ( move != 0 ) {
            animator.SetBool( "Walk", true );
            Debug.Log("is moving");
        }
        else {
            animator.SetBool( "Walk", false );
            Debug.Log("is not moving");
        }
    }
}