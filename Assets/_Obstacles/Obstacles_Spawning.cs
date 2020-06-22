using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles_Spawning : MonoBehaviour
{
    public Transform[] spawns;
    public GameObject[] objects;

    public int startSpawnTime = 10;
    public int spawnTime = 1;

    // Start is called before the first frame update
    void Start()
    {
        /*SpawnObjects(objects, spawns);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   /* private void SpawnObjects(GameObject[] gameObjects, Transform[] locations, bool allowOverlap = true)
    {
        List<GameObjects> remainingGameObjects = new List<GameObjects>(gameObjects);
        List<GameObjects> freeLocations = new List<GameObject>(locations);

        if(locations.Length<gameObjects.Length)

        while(remainingGameObjects.Count > 0)
            {
                if (freeLocations.Count == 0)
                {
                    if (allowOverlap) freeLocations.AddRange(locations);
                    else
                        break;
                }

                int gameObjectIndex = Random.Range(0, remainingGameObjects.Count);
                int locationIndex = Random.Range(0, freeLocations.Count);
                Instantiate(gameObjects[gameObjectIndex], locations[locationIndex].position, Quaternion.identity);
                remainingGameObjects.RemoveAt(gameObjectIndex);
                freeLocations.RemoveAt(locationIndex);
            }
          

    }*/
}
