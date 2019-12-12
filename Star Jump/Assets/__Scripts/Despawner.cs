using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour {
    void Start () {
        StartCoroutine (despawn (4f));
    }

    IEnumerator despawn (float seconds) {
        yield return new WaitForSeconds (seconds);
        Destroy (gameObject);
    }
}