using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // ref to rigigbody comp
    public Rigidbody rb;

    public float forwardForce = 2000;
    public float sidewaysForce;

	private void Start()
	{
        rb = GetComponent<Rigidbody>();
	}

	// mesh w/ physics
    // float delta time
    //              manual input =.01
    //              results in missed collisions if not set to agreeable value
	void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        /* mesh w/ physics
         * 
         * float deltaTime
         *              manual input =.01
         *              results in missed collisions if not set to agreeable value
         */

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
