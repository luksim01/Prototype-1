using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControllerP2 : MonoBehaviour
{
    [SerializeField] float horsePower = 30000.0f;
    [SerializeField] float turnSpeed = 45.0f;
    [SerializeField] float horizontalInput;
    [SerializeField] float forwardInput;

    private Rigidbody player2Rb;
    [SerializeField] GameObject centerOfMass;

    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] float speed;

    [SerializeField] TextMeshProUGUI rpmText;
    [SerializeField] float rpm;

    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;

    // Start is called before the first frame update
    void Start()
    {
        player2Rb = GetComponent<Rigidbody>();
        player2Rb.centerOfMass = centerOfMass.transform.localPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (IsOnGround())
        {
            speed = Mathf.Round(player2Rb.velocity.magnitude * 2.237f);
            speedometerText.SetText("Speed: " + speed + "mph");

            rpm = Mathf.Round((speed % 30) * 40);
            rpmText.SetText("RPM: " + rpm);

            horizontalInput = Input.GetAxis("HorizontalP2");
            forwardInput = Input.GetAxis("VerticalP2");

            // Moves the vehicle forward based on vertical input
            //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            player2Rb.AddRelativeForce(Vector3.forward * horsePower * forwardInput);
            // Rotates the vehicle based on horizontal input
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        }
    }

    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }
        if (wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
