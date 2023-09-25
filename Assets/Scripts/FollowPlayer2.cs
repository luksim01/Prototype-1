using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer2 : MonoBehaviour
{
    public GameObject player2;
    public GameObject mainCameraP2;
    public GameObject otherCameraP2;

    // Start is called before the first frame update
    void Start()
    {
        // Initially set main camera to active, other camera to inactive
        mainCameraP2.SetActive(true);
        otherCameraP2.SetActive(false);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Right Shift button press inverts activity of both cameras for P2
        if (Input.GetButtonDown("RightShift"))
        {
            mainCameraP2.SetActive(!mainCameraP2.activeSelf);
            otherCameraP2.SetActive(!otherCameraP2.activeSelf);
        }
        // Track P2 position
        transform.position = player2.transform.position;
    }
}
