using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonShark : MonoBehaviour
{
    public AudioClip buttonClick;
    public AudioClip sharkSound;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.PlayOneShot(buttonClick);
            audioSource.PlayOneShot(sharkSound, 3f);
        }
    }
}
