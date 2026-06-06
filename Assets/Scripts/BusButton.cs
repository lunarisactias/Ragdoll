using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusButton : MonoBehaviour
{
    public AudioClip busSound;
    public AudioClip buttonClick;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            audioSource.PlayOneShot(busSound, 3f);
            audioSource.PlayOneShot(buttonClick);
            GameManagerScript.instance.TurnOnBus();
        }
    }
}
