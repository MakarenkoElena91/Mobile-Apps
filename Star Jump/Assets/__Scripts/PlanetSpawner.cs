using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawner : MonoBehaviour {
    [SerializeField]
    private GameObject planetPrefab;
    private float spawnDelay = 1.0f;
    private float spawnInterval = 1f;
    private IList<SpawnPoint> spawnPoints;
    private GameObject planetParent;

    private float previousPos = -1;

    void Start () 
    {
        planetParent = GameObject.Find ("PlanetParent");
        if (!planetParent) {
            planetParent = new GameObject ("PlanetParent");
        }
        spawnPoints = GetComponentsInChildren<SpawnPoint> ();
        SpawnRepeating ();
    }

    private void SpawnRepeating () 
    {
        InvokeRepeating ("Spawn", spawnDelay, spawnInterval);
    }

    private int getRandom(){
        return Random.Range (0, spawnPoints.Count);
    }

    private void Spawn () 
    {
        var randomIndex = -1;
        for(int i=0; i<2; i++){
            do{
                randomIndex = getRandom();
            }while(randomIndex == previousPos);
            previousPos = randomIndex;

            var currPoint = spawnPoints[randomIndex];
            var planet = Instantiate (planetPrefab, planetParent.transform);
            planet.transform.position = currPoint.transform.position;
        }
        
    }
}