using System.Collections;
using UnityEngine;
using UnityEngine.UI;

//  CODE ADAPTED FROM: https://unity3d.com/learn/tutorials/projects/space-shooter/spawning-waves

public class WaveSpawn : MonoBehaviour {
    public Transform spawnPoint;
    public GameObject enemy;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public Text waveDisplay;
    public int waveNumber;

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
            for (int i = 1; i <= Random.Range(1, 10); i++) {
                Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
                yield return new WaitForSeconds(spawnWait);
            }   //  for
            yield return new WaitForSeconds(waveWait);
            ++waveNumber;

            if (waveNumber % 5 == 0) {
                enemy.GetComponent<EnemyHealth>().startHealth += 20;

                if (!(enemy.GetComponent<EnemyMovement>().speed >= 25f)) {
                    waveWait -= .2f;
                    enemy.GetComponent<EnemyMovement>().speed += 0.5f;
                }
                if (!(waveWait <= 5))
                    waveWait -= 0.5f;
            }   //  if
        }   //  while
    }   //   SpawnWave()
}   //  WaveSpawn
