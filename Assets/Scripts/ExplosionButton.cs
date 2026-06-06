using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionButton : MonoBehaviour
{
    public AudioClip buttonClick;
    public AudioClip explosionSound;
    public GameObject explosionVFX;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            audioSource.PlayOneShot(buttonClick);
            explosionVFX.SetActive(true);
            audioSource.PlayOneShot(explosionSound, 3f);
            GameManagerScript.instance.ExplodeEveryRagdoll();
            StartCoroutine(DeactivateVFX());
        }
    }

    private IEnumerator DeactivateVFX()
    {
        yield return new WaitForSeconds(2f);
        explosionVFX.SetActive(false);
    }
}
