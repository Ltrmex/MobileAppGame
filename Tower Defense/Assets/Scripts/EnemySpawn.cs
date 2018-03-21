using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject enemy;
    public float interval;

    void Start() {
        InvokeRepeating("Spawn", interval, interval);
    }   //  Start()

    private void Spawn() {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }   //  Spawn()
}
