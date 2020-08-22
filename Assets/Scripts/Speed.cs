using UnityEngine;

public class Speed : MonoBehaviour {

	#region Variables
	public float speed = 0;
	Vector3 lastPosition = Vector3.zero;
	#endregion

	private void FixedUpdate()
	{
		speed = (transform.position - lastPosition).magnitude;
		lastPosition = transform.position;
		Debug.Log("speed: " + speed);
	}
}
