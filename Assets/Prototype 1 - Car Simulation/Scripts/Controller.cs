using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 10.0f;
    public float turnSpeed = 45.0f;
    public float horizontalInput;
    public float forwardInput;
    private Rigidbody rbody;
    // Start is called before the first frame update
    void Start()
    {
        ///create rigidbody
        rbody = this.GetComponent<Rigidbody>();
        ///set mass of the car
        rbody.mass = 2500;
        ///set drag of the car
        rbody.drag = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }

}
