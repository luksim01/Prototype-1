using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float horsePower = 30000.0f;
    [SerializeField] float turnSpeed = 45.0f;
    [SerializeField] float horizontalInput;
    [SerializeField] float forwardInput;

    private Rigidbody player1Rb;
    [SerializeField] GameObject centerOfMass;

    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        player1Rb = GetComponent<Rigidbody>();
        player1Rb.centerOfMass = centerOfMass.transform.localPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speed = Mathf.Round(player1Rb.velocity.magnitude * 2.237f);
        speedometerText.SetText("Speed: " + speed + "mph");


        horizontalInput = Input.GetAxis("HorizontalP1");
        forwardInput = Input.GetAxis("VerticalP1");

        // Moves the vehicle forward based on vertical input
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        player1Rb.AddRelativeForce(Vector3.forward * horsePower * forwardInput);
        // Rotates the vehicle based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
