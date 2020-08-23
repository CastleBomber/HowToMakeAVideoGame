﻿using UnityEngine;

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
            Debug.Log("deltaTime baby!:    -->>  " + Time.deltaTime);
        }
    }
}
