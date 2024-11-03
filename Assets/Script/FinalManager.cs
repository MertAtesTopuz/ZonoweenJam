using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip Clap, UmutEnter, MertEnter, ElifEnter, YagmurEnter,ZeynepEnter, HarunEnter, Arda1, Arda2, Arda3, Arda4, Boo, Background;

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

    void Start()
    {
        audioSource.PlayOneShot(Background);
    }

    public void SceneChange()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
