using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncomingVehicle : MonoBehaviour
{
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Oncoming vehicle moves in a straight direction
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
