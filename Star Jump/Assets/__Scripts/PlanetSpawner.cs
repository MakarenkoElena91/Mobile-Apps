using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetSpawner : MonoBehaviour {
    [SerializeField]
    private GameObject planetPrefab;
    private float spawnDelay = 2.0f;
    private float spawnInterval = 1f;
    private IList<SpawnPoint> spawnPoints;
    private GameObject planetParent;

    private float previousPos = -1;

    void Start () {
        planetParent = GameObject.Find ("PlanetParent");
        if (!planetParent) {
            planetParent = new GameObject ("PlanetParent");
        }
        spawnPoints = GetComponentsInChildren<SpawnPoint> ();
        SpawnRepeating ();
    }

    private void SpawnRepeating () {
        InvokeRepeating ("Spawn", spawnDelay, spawnInterval);
    }

    private int getRandom () {
        return Random.Range (0, spawnPoints.Count);
    }

    private void Spawn () {
        var randomIndex = -1;
        Scene scene = SceneManager.GetActiveScene ();
        if (scene.name == "Level2") {
            for (int i = 0; i < 1; i++) {
                do {
                    randomIndex = getRandom ();
                } while (randomIndex == previousPos);
                previousPos = randomIndex;

                var currPoint = spawnPoints[randomIndex];
                var planet = Instantiate (planetPrefab, planetParent.transform);
                planet.transform.position = currPoint.transform.position;
            }
        } else if (scene.name == "Level3") {
            for (int i = 0; i < 1; i++) {
                do {
                    randomIndex = getRandom ();
                } while (randomIndex == previousPos);
                previousPos = randomIndex;

                var currPoint = spawnPoints[randomIndex];
                var planet = Instantiate (planetPrefab, planetParent.transform);
                planet.transform.position = currPoint.transform.position;
            }
        }

    }
}