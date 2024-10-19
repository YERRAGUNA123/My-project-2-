using UnityEngine;

public class FallDetector : MonoBehaviour
{
    // Set this value to the height below which the player is considered to have fallen.
    [SerializeField] private float fallThreshold = -10f;

    // Set the position where the player will respawn
    [SerializeField] private Vector3 respawnPosition = new Vector3(0, 1, 0);

    // Reference to the player's Rigidbody (optional, if you need to reset velocity)
    private Rigidbody playerRigidbody;

    // Reference to the player object
    private GameObject player;

    void Start()
    {
        // Find the player object using the "Player" tag
        player = GameObject.FindWithTag("Player");
        
        if (player == null)
        {
            Debug.LogError("Player object not found. Make sure the player has the 'Player' tag.");
            return;
        }

        // Get the player's Rigidbody component (optional)
        playerRigidbody = player.GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check if the player has fallen below the threshold
        if (player != null && player.transform.position.y < fallThreshold)
        {
            // Call the method to handle the fall
            HandleFall();
        }
    }

    // Method to handle what happens when the player falls
    private void HandleFall()
    {
        // Reset the player's position to the respawn position
        player.transform.position = respawnPosition;

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
