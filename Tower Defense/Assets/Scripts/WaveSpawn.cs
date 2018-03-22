using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawn : MonoBehaviour {
    public Transform spawnPoint;
    public GameObject enemy;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public Text waveDisplay;
    private int waveNumber;

    private void Start() {
        StartCoroutine("SpawnWave");
        waveNumber = 1;
    }   //  Start()

    private void Update() {
        waveDisplay.text = "Wave: " + waveNumber.ToString();
    }   //  Update()

    IEnumerator SpawnWave() {
        yield return new WaitForSeconds(startWait);
        
        while (true) {
            for (int i = 0; i < hazardCount; i++) {
                Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
                yield return new WaitForSeconds(spawnWait);
            }   //  for
            yield return new WaitForSeconds(waveWait);
            ++waveNumber;
        }   //  while
    }   //   SpawnWave()
}   //  WaveSpawn
