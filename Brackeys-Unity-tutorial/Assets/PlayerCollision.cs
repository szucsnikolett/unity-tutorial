using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    // stops reference player's movement on collision
    public void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
