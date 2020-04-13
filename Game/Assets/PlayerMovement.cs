using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public Rigidbody rb;

	public float forwardForce = 2000f;

	public float sideForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);
		if (Input.GetKey(KeyCode.D))
		{
			rb.AddForce(sideForce * Time.deltaTime, 0, 0);
		}

		if (Input.GetKey(KeyCode.A))
		{
			rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
		}
	}
}
