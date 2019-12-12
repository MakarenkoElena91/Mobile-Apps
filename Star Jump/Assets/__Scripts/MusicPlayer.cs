using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private void Awake()
    {
        SetupMusicSingleton();
    }
    private void SetupMusicSingleton()
    {
        if (FindObjectsOfType<AudioSource>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }



    }

}