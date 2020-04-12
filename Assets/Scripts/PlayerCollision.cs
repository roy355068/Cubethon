using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    // A reference to the PlayerMovement script (for disabling the script once hit)
    public PlayerMovement movement;

    // Collision is the object of the collision event
    public void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
