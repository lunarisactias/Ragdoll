using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource audioSource;
    public void PlayBtn()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void SoundBtn()
    {
        audioSource.Play();
    }
}
