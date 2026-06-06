using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour
{
    private Vector3 startPosition;
    private bool canMove = false;
    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (canMove)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 100);
        }
    }

    public void MoveBus()
    {
        canMove = true;
        StartCoroutine(ResetBus());
    }

    public IEnumerator ResetBus()
    {
        yield return new WaitForSeconds(15f);
        transform.position = startPosition;
        canMove = false;
    }
}
