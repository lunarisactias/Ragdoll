using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoButton : MonoBehaviour
{
    public AudioClip pianoSound;
    public AudioClip buttonClick;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.PlayOneShot(pianoSound, 3f);
            audioSource.PlayOneShot(buttonClick);
            GameManagerScript.instance.DropPianos();
        }
    }
}
