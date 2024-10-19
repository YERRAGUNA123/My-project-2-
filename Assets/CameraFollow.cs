using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public Vector3 offset = new Vector3(0, 5, -10); // Adjusted offset for better positioning
    public float smoothSpeed = 0.125f; // How quickly the camera follows

    void LateUpdate()
    {
        // Desired position of the camera
        Vector3 desiredPosition = player.position + offset;

        // Smoothly interpolate between the current position and the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        
        // Apply the smoothed position to the camera
        transform.position = smoothedPosition;

        // Optional: make the camera look at the player
        transform.LookAt(player);
    }
}
