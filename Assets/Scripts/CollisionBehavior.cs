using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehavior : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Rigidbody rb;
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.collider.tag.Equals("Obstacle"))
        {
            rb.AddForce(0, 0, -1000);
        }

    }
}
