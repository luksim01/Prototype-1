using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer1 : MonoBehaviour
{
    public GameObject player1;
    public GameObject mainCameraP1;
    public GameObject otherCameraP1;

    // Start is called before the first frame update
    void Start()
    {
        // Initially set main camera to active, other camera to inactive
        mainCameraP1.SetActive(true);
        otherCameraP1.SetActive(false);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Left Shift button press inverts activity of both cameras for P1
        if (Input.GetButtonDown("LeftShift"))
        {
            mainCameraP1.SetActive(!mainCameraP1.activeSelf);
            otherCameraP1.SetActive(!otherCameraP1.activeSelf);
        }
        // Track P2 position
        transform.position = player1.transform.position;
    }
}
