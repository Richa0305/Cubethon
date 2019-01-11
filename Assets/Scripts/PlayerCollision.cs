using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obsticle")
        {
            movement.enabled = false;
            FindObjectOfType<ManageGame>().EndGame();
        }
    }
}
