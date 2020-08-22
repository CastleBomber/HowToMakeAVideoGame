using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // ref to rigigbody comp
    public Rigidbody rb;

    public static float forwardForce = 2000;
    public float sidewaysForce;

	private void Start()
	{
        rb = GetComponent<Rigidbody>();
	}

	// mesh w/ physics
	void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("d"))
        {
          rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("a"))
        {
          rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

    }
}
