using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoButton : MonoBehaviour
{
    public AudioClip pianoSound;
    public AudioClip buttonClick;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(pianoSound, transform.position);
            AudioSource.PlayClipAtPoint(buttonClick, transform.position);
            GameManagerScript.instance.DropPianos();
        }
    }
}
