using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // Define variables
    private float speed = 4.0f;
    private float rotationSpeed = 30.0f;
    public float verticalInput;
    private float forwardInput = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left, Time.deltaTime * rotationSpeed * verticalInput);
    }
}
