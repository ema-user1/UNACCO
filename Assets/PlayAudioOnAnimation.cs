using UnityEngine;

public class PlayAudioOnAnimation : MonoBehaviour
{
    public AudioSource audioSource; 

    public void PlaySound()
    {
        if (audioSource != null)
            audioSource.Play();
    }
}
