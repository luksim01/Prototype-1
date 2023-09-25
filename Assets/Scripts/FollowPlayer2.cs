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
        mainCameraP2.SetActive(true);
        otherCameraP2.SetActive(false);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetButtonDown("RightShift"))
        {
            mainCameraP2.SetActive(!mainCameraP2.activeSelf);
            otherCameraP2.SetActive(!otherCameraP2.activeSelf);
        }
        if(mainCameraP2.activeSelf)
        {
            transform.position = player2.transform.position;
        }
        if (otherCameraP2.activeSelf)
        {
            transform.position = player2.transform.position;
        }
    }
}
