using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusButton : MonoBehaviour
{
    public AudioClip busSound;
    public AudioClip buttonClick;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(busSound, transform.position);
            AudioSource.PlayClipAtPoint(buttonClick, transform.position);
            GameManagerScript.instance.TurnOnBus();
        }
    }
}
