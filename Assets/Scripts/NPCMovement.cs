using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]



public class NPCMovement : MonoBehaviour
{
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;
    public float proximityThreshold = 1.0F;

    public GameObject[] path = new GameObject[10];
    private int i = 0;
    public int rotationDirection = 1; // Use 1 for clockwise path, -1 for counter-clockwise path

    // Update is called once per frame
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        // Rotate around y - axis
        float yDiff = transform.position.y - path[i].transform.position.y;
        Vector3 temp = new Vector3(0, yDiff, 0);

        if (Vector3.Angle(transform.forward, (path[i].transform.position + temp - transform.position)) > 15)
        {
            transform.Rotate(0, rotationDirection * rotateSpeed, 0);
        }
        else if (Vector3.Angle(transform.forward, (path[i].transform.position + temp - transform.position)) > 5)
        {
            transform.Rotate(0, rotationDirection * .25F * rotateSpeed, 0);
        }
        else if (Vector3.Angle(transform.forward, (path[i].transform.position + temp - transform.position)) > 1)
        {
            transform.LookAt(path[i].transform.position + temp);
        }
        else if (Vector3.Distance(path[i].transform.position + temp, transform.position) > proximityThreshold){
            // Move forward / backward
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            controller.SimpleMove(forward * speed);
        }
        else
        {
            i++;
            if (i >= path.Length)
            {
                i = 0;
            }
        }
    }
}
