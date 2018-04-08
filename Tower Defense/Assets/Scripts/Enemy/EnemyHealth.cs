using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {
    private float startHealth = 100;
    private PlayerStats playerStats;
    private int coins = 20;

    public Slider healthSlider;
    public float currentHealth;

    // Use this for initialization
    void Start () {
        currentHealth = startHealth;
        playerStats = GameObject.FindGameObjectWithTag("Manager").GetComponent<PlayerStats>();
	}   //  Start()

    public void TakeDamage(float damage) {
        currentHealth -= damage;
        
        if (currentHealth <= 0)
            Death();
    }   //  TakeDamage

    void Death() {
        playerStats.gold += coins;
        Destroy(gameObject);
    }   //  Death()

	// Update is called once per frame
	void Update () {
        healthSlider.value = currentHealth;
    }   //  Update()
}   //  EnemyHealth
