using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {
    
    public Transform cameraTransform;  // Reference to the camera's transform
    public Transform targetPosition;   // Reference to the target position (near the kitchen table)
    public Transform targetRotation;   // Reference to the target rotation
    public float moveSpeed = 2.0f;     // Speed of the camera movement
    public float rotationSpeed = 0.5f; // Speed of the camera rotation

    private bool shouldMove = false;   // Whether the camera should move

    
    // Call this method when the "Start" button is pressed
    public void StartMovingCamera() {
        shouldMove = true;
    }

    
    void Update() {
        // If the camera should move, interpolate the camera's position
        if (shouldMove) {
            // Move the camera towards the target position
            cameraTransform.position = Vector3.Lerp(cameraTransform.position, targetPosition.position, moveSpeed * Time.deltaTime);

            // Rotate the camera towards the target rotation
            cameraTransform.rotation = Quaternion.Lerp(cameraTransform.rotation, targetRotation.rotation, rotationSpeed * Time.deltaTime);

            // Check if the camera has reached the target and stop the movement
            if (Vector3.Distance(cameraTransform.position, targetPosition.position) < 0.01f &&
                Quaternion.Angle(cameraTransform.rotation, targetRotation.rotation) < 0.5f) {
                shouldMove = false;     // Stop moving when close enough to the target
            }
        }
    }
}
