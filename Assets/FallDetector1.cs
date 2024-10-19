using UnityEngine;

public class FallDetector1 : MonoBehaviour
{
    // Set this value to the height below which the player is considered to have fallen.
    [SerializeField] private float fallThreshold = -10f;

    // Set the position where the player will respawn
    [SerializeField] private Vector3 respawnPosition = new Vector3(0, 1, 0);

    // Reference to the player's Rigidbody (optional, if you need to reset velocity)
    private Rigidbody playerRigidbody;

    void Start()
    {
        // Get the player's Rigidbody component (optional)
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check if the player has fallen below the threshold
        if (transform.position.y < fallThreshold)
        {
            // Call the method to handle the fall
            HandleFall();
        }
    }

    // Method to handle what happens when the player falls
    private void HandleFall()
    {
        // Reset the player's position to the respawn position
        transform.position = respawnPosition;

        // Optional: Reset the player's velocity to zero to avoid weird movement after respawn
        if (playerRigidbody != null)
        {
            playerRigidbody.linearVelocity = Vector3.zero;
            playerRigidbody.angularVelocity = Vector3.zero;
        }

        // Optional: Log a message or add a visual/audio cue
        Debug.Log("Player has fallen! Respawning...");
    }
}
