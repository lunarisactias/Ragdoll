using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private GameObject hips;
    [SerializeField] private float explosionForce = 1000f;
    [SerializeField] private float explosionRadius = 5f;
    [SerializeField] private float upwardModifier = 0.5f;
    [SerializeField] private Vector3 explosionPos = Vector3.zero;
    [SerializeField] private bool explode = false;

    public void Explode()
    {
        if (hips != null)
        {
            Rigidbody hipsRb = hips.GetComponent<Rigidbody>();
            if (hipsRb != null)
            {
                AnimationToRagdoll animationToRagdoll = hips.GetComponentInParent<AnimationToRagdoll>();
                if (animationToRagdoll != null)
                {
                    animationToRagdoll.ToggleRagdoll(false);
                    animationToRagdoll.StartCoroutine(animationToRagdoll.GetBackUp());
                }
                hipsRb.AddExplosionForce(explosionForce, explosionPos, explosionRadius, upwardModifier, ForceMode.Impulse);
            }
        }
    }
     private void Update()
    {
        if (explode)
        {
            Explode();
            explode = false;
        }
    }
}
