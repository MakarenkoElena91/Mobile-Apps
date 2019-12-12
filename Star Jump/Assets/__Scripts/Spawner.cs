using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform Planet;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn(2f));
    }
 
    IEnumerator spawn(float seconds)
    {
        yield return new WaitForSeconds(seconds);
      
        Instantiate(Planet, new Vector3(6, Random.Range(-4f, 4f), 0), Quaternion.identity);
        StartCoroutine(spawn(2f));
    }
}
