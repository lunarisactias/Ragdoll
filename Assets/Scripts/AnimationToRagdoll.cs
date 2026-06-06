using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationToRagdoll : MonoBehaviour
{
    [SerializeField] private Collider myCollider;
    [SerializeField] private float respawnTime = 5f;
    [SerializeField] private Rigidbody[] myRigidbodies;
    private Vector3 startingPlace;
    private bool activateRagdoll = false;

    private void Start()
    {
        startingPlace = transform.position;
        myRigidbodies = GetComponentsInChildren<Rigidbody>();
        ToggleRagdoll(true);

        foreach (Rigidbody rb in myRigidbodies)
        {
            rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile") && !activateRagdoll)
        {
            ToggleRagdoll(false);
            StartCoroutine(GetBackUp());
        }
    }

    public IEnumerator GetBackUp()
    {
        yield return new WaitForSeconds(respawnTime);
        ToggleRagdoll(true);
        transform.position = startingPlace;
    }

    public void ToggleRagdoll(bool isAnimation)
    {
        activateRagdoll = !isAnimation;
        myCollider.enabled = isAnimation;

        foreach (Rigidbody rb in myRigidbodies)
        {
            rb.isKinematic = isAnimation;
        }

        GetComponent<Animator>().enabled = isAnimation;

        if (isAnimation) RandomAnimation();

    }

    private void RandomAnimation()
    {
        int randomAnim = Random.Range(0, 1);

        Animator animator = GetComponent<Animator>();

        if (randomAnim == 0)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }
}
