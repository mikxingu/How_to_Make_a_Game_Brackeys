using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public PlayerMovement movementScript;

	private void Start()
	{
		movementScript = GetComponent<PlayerMovement>();
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "Obstacle")
		{
			movementScript.enabled = false;
		}
	}
}
