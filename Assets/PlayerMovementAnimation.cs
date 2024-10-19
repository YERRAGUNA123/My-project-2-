using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    // Reference to the Animation component
    private Animation animationComponent;

    // Animation clips that can be set in the Inspector
    [SerializeField] private AnimationClip moveForwardAnimation;
    [SerializeField] private AnimationClip idleAnimation;

    void Start()
    {
        // Get the Animation component
        animationComponent = GetComponent<Animation>();

        if (animationComponent == null)
        {
            Debug.LogError("Animation component not found on the player.");
            return;
        }

        // Add the animations to the Animation component
        if (moveForwardAnimation != null)
        {
            animationComponent.AddClip(moveForwardAnimation, "MoveForward");
        }

        if (idleAnimation != null)
        {
            animationComponent.AddClip(idleAnimation, "Idle");
        }
    }

    void Update()
    {
        // Get player's vertical input
        float verticalInput = Input.GetAxis("Vertical");

        // Play the move forward animation if the player is moving forward
        if (verticalInput > 0)
        {
            PlayAnimation("MoveForward");
        }
        else
        {
            PlayAnimation("Idle");
        }
    }

    // Method to play a specific animation
    private void PlayAnimation(string animationName)
    {
        if (animationComponent != null && animationComponent.IsPlaying(animationName) == false)
        {
            animationComponent.Play(animationName);
        }
    }
}
