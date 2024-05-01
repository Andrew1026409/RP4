using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of rotation

    private Quaternion initialRotation; // Initial rotation of the GameObject

    void Start()
    {
        // Store the initial rotation of the GameObject
        initialRotation = transform.rotation;
    }

    void Update()
    {
        // Get input for rotation from WASD keys
        float horizontalInput = Input.GetAxis("Horizontal") * -1; // Invert horizontal input
        float verticalInput = Input.GetAxis("Vertical") * -1; // Invert vertical input

        // Calculate rotation angles based on input
        float yaw = horizontalInput * rotationSpeed * Time.deltaTime;
        float pitch = verticalInput * rotationSpeed * Time.deltaTime;

        // Rotate the GameObject only around X and Z axes
        transform.Rotate(Vector3.right, pitch);
        transform.Rotate(Vector3.forward, -yaw);
    }

    // Reset the rotation to the initial rotation when called
    public void ResetRotation()
    {
        transform.rotation = initialRotation;
    }
}