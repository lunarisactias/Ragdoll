using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBullet : MonoBehaviour
{
    [SerializeField] private float launchForce = 500f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * launchForce);
    }

    private void Update()
    {
        rb.AddForce(transform.forward * launchForce * Time.deltaTime);
    }
}
