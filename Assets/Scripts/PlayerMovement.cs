using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sideSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sideSpeed * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sideSpeed * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if(rb.position.y<-1f)
        {
            FindObjectOfType<Manage>().Lost();
        }
    }
}
