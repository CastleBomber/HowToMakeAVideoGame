using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    //public Player
    
    void OnCollisionEnter (Collision collisionInfo)
    {
        //movement = GetComponent<PlayerMovement>();
        Debug.Log("we hit something");

        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
			movement.enabled = false;
            Debug.Log("inside movement disabled  ->" + collisionInfo.collider.tag);
            PlayerMovement.forwardForce = 0;
        }
    }
}
