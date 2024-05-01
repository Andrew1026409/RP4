using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    // Ensure there's only one instance of AudioManager throughout the game
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Play the provided audio clip
    public void PlayAudioClip(AudioClip clip)
    {
        if (clip != null)
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            if (audioSource != null)
            {
                audioSource.clip = clip;
                audioSource.Play();
            }
        }
    }
}
