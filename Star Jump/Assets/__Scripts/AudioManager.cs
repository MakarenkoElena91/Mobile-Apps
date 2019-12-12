using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {
    // Singleton instance.
    private static AudioManager _instance;
     public static AudioManager Instance
     {
         get
         {
             if (_instance==null)
             {
                 _instance = GameObject.FindObjectOfType<AudioManager>();
                 DontDestroyOnLoad(_instance.gameObject);
             }
             return _instance;
         }
     }

    // Initialize the singleton instance.
    private void Awake () {
         #region SingletonRun
         if (_instance==null)
         {
             _instance = this;
             DontDestroyOnLoad(this);
         }
         else
         {
             if ( this !=_instance)
             {
                 Destroy(this.gameObject);
             }
         }
         #endregion        
     }
}