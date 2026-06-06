using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionButton : MonoBehaviour
{
    public AudioClip buttonClick;
    public AudioClip explosionSound;
    public GameObject explosionVFX;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(buttonClick, transform.position);
            explosionVFX.SetActive(true);
            AudioSource.PlayClipAtPoint(explosionSound, explosionVFX.transform.position);
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
