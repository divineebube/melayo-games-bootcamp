using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    
    private float horizontalInput;
    private float forwardInput;
    
    private float turnSpeed = 45;
    private float speed = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        //moving the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
       // rotates the car based on horizontal input
       transform.Rotate(Vector3.up, turnSpeed * horizontalInput *Time.deltaTime);
    }
}
