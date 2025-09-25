using UnityEngine;

/// <summary>
/// A smooth camera follow script that follows a target's position.
/// </summary>
public class CameraFollow : MonoBehaviour
{
    // The target object for the camera to follow (e.g., the player).
    [Tooltip("The target the camera should follow.")]
    public Transform target;

    // The speed at which the camera will follow the target.
    // A smaller value will make the camera lag more, creating a smoother effect.
    [Tooltip("How quickly the camera catches up to the target. Smaller value is slower.")]
    [Range(0.01f, 1.0f)]
    public float smoothSpeed = 0.125f;

    // The offset from the target's position.
    // This allows you to position the camera behind and above the player, for example.
    [Tooltip("The distance and angle the camera should maintain from the target.")]
    public Vector3 offset;

    void LateUpdate()
    {
        // Check if a target has been assigned. If not, do nothing.
        if (target == null)
        {
            Debug.LogWarning("Camera Follow Target is not set!");
            return;
        }

        // Calculate the desired position for the camera.
        // This is the target's position plus the offset.
        Vector3 desiredPosition = target.position + offset;

        // Smoothly interpolate from the camera's current position to the desired position.
        // Vector3.Lerp() creates a gradual transition between two points.
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Apply the new position to the camera.
        transform.position = smoothedPosition;

        // Optional: Make the camera always look at the target.
        // This is useful for 3D games where the camera might rotate.
        // Uncomment the line below if you want this behavior.
        // transform.LookAt(target);
    }
}