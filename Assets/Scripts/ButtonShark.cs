using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonShark : MonoBehaviour
{
    public AudioClip buttonClick;
    public AudioClip sharkSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(buttonClick, transform.position);
            AudioSource.PlayClipAtPoint(sharkSound, transform.position);
        }
    }
}
