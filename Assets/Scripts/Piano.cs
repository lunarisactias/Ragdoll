using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piano : MonoBehaviour
{
    private Vector3 spawnPosition;
    private Vector3 spawnRotation;

    private void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
        spawnPosition = transform.position;
        spawnRotation = transform.eulerAngles;
    }

    public void DropPiano()
    {
        GetComponent<Rigidbody>().useGravity = true;
        StartCoroutine(ResetPiano());
    }

    IEnumerator ResetPiano()
    {
        yield return new WaitForSeconds(8f);
        transform.position = spawnPosition;
        transform.eulerAngles = spawnRotation;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
