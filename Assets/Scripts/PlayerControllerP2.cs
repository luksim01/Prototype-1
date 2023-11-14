using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerP2 : MonoBehaviour
{
    [SerializeField] float horsePower = 30000.0f;
    [SerializeField] float turnSpeed = 45.0f;
    [SerializeField] float horizontalInput;
    [SerializeField] float forwardInput;

    private Rigidbody player2Rb;
    [SerializeField] GameObject centerOfMass;

    // Start is called before the first frame update
    void Start()
    {
        player2Rb = GetComponent<Rigidbody>();
        player2Rb.centerOfMass = centerOfMass.transform.localPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("HorizontalP2");
        forwardInput = Input.GetAxis("VerticalP2");

        // Moves the vehicle forward based on vertical input
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        player2Rb.AddRelativeForce(Vector3.forward * horsePower * forwardInput);
        // Rotates the vehicle based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
