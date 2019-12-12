using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
      // Audio players components.
    public AudioSource audioSource;
    public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
         audioSource.clip = audioClip;
    }

     public void PlayCollision () {
       if(audioSource!=null)
        audioSource.Play ();
    }
}
