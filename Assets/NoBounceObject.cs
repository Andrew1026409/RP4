using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoBounceObject : MonoBehaviour
{
    public float bounciness = 0f; // Bounciness of the object
    public float friction = 1f; // Friction of the object

    void Start()
    {
        // Get the Collider component attached to this GameObject
        Collider collider = GetComponent<Collider>();
        if (collider != null)
        {
            // Create a new Physics Material
            PhysicMaterial physicsMaterial = new PhysicMaterial();

            // Set the bounciness and friction properties
            physicsMaterial.bounciness = bounciness;
            physicsMaterial.dynamicFriction = friction;
            physicsMaterial.staticFriction = friction;

            // Assign the Physics Material to the Collider
            collider.material = physicsMaterial;
        }
        else
        {
            Debug.LogWarning("Collider component not found!");
        }
    }
}
