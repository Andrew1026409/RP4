using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public Scene sceneToLoad; // Scene to load when the player enters the collider
    public float delay = 0f; // Delay before loading the scene
    public AudioClip soundEffect; // Sound effect to play when loading the scene

    private AudioSource audioSource; // Reference to the AudioSource component

    private void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            // Check if a scene is assigned
            if (sceneToLoad != null)
            {
                // Play sound effect if available
                if (soundEffect != null && audioSource != null)
                {
                    audioSource.PlayOneShot(soundEffect);
                }

                // Invoke the LoadSceneWithDelay method after the specified delay
                Invoke("LoadSceneWithDelay", delay);
            }
            else
            {
                Debug.LogWarning("No scene assigned to load!");
            }
        }
    }

    private void LoadSceneWithDelay()
    {
        // Load the specified scene by name
        SceneManager.LoadScene(sceneToLoad.name);
    }
}