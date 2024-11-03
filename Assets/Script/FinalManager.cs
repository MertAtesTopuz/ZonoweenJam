using System.Collections;
using System.Diagnostics;
using UnityEngine;

public class FinalManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip Clap, UmutEnter, MertEnter, ElifEnter, YagmurEnter,ZeynepEnter, HarunEnter, Arda1, Arda2, Arda3, Arda4, Boo;

    public void PlaySound(/*AudioClip clip*/)
    {
        audioSource.PlayOneShot(Clap);
    }

    void Start()
    {
        audioSource.PlayOneShot(Clap);
    }
    
}
