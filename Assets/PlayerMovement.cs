using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // ref to rigigbody comp
    public Rigidbody rb;

    // mesh w/ physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
