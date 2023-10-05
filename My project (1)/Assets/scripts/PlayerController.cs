using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 50.0f;
    public float TurnSpeed = 50.0f;
    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward* Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up* TurnSpeed * horizontalInput * Time.deltaTime);
        
    }
}
