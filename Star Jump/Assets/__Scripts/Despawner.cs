using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(spawn(4f));
    }
 
    IEnumerator spawn(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(gameObject);
       
        //StartCoroutine(spawn(2f));
    }
}
