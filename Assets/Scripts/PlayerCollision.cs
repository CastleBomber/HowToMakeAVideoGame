using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    
    
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            //movement = GameObject.Find("Obstacle").GetComponent<PlayerMovement>();
            //i tried
            movement.enabled = false;
        }
    }
}
