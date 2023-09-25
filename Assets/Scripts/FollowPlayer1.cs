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
        mainCameraP1.SetActive(true);
        otherCameraP1.SetActive(false);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetButtonDown("LeftShift"))
        {
            mainCameraP1.SetActive(!mainCameraP1.activeSelf);
            otherCameraP1.SetActive(!otherCameraP1.activeSelf);
        }
        if(mainCameraP1.activeSelf)
        {
            transform.position = player1.transform.position;
        }
        if (otherCameraP1.activeSelf)
        {
            transform.position = player1.transform.position;
        }
    }
}
