using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    public float speed = 5.0f;
    public float turnSpeed;
    public string horizontalAxisName = "Horizontal";
    public string verticalAxisName = "Vertical";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get player input
        float horizontalInput = Input.GetAxis(horizontalAxisName);
        float verticalInput = Input.GetAxis(verticalAxisName);


        //We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
