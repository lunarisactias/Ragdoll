using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript instance;
    public GameObject pianoPrefab;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void ExplodeEveryRagdoll()
    {
        Explosion[] explosions = FindObjectsOfType<Explosion>();
        foreach (Explosion explosion in explosions) {
            explosion.Explode();
        }
    }

    public void DropPianos()
    {
        Piano[] pianos = FindObjectsOfType<Piano>();
        foreach (Piano piano in pianos)
        {
            piano.DropPiano();
        }
    }

    public void TurnOnBus()
    {
        Bus[] buses = FindObjectsOfType<Bus>();
        foreach (Bus bus in buses)
        {
            bus.MoveBus();
        }
    }
}
