using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour {

    public GameObject[] roads;
    public GameObject block;

    private float blockIndex, roadIndex = 1;

    void Start() {

        blockIndex = -10;

        for (int i = 0; i < 10; i++) {
            SpawnBlock();
        }

        blockIndex = 0;

    }

    public void MakeRoad() {

        int n = Random.Range(0, roads.Length);

        Vector3 newPosition = new Vector3(roadIndex * 100 - 100, 0f, 0f);

        GameObject newRoad =
            Instantiate(roads[n], newPosition, roads[n].transform.rotation);

        for(int i = 0; i < 10; i++) {
            SpawnBlock();
        }

        roadIndex++;

    } // make road

    void SpawnBlock() {

        Vector3 newPosition = new Vector3(
            Random.Range(blockIndex * 10 - 20, blockIndex * 10 - 10), 1f,
            Random.Range(-1f, 1f));

        GameObject newBlock = Instantiate(block, newPosition, Quaternion.identity);

        blockIndex++;

    } // spawn block



} // class











































