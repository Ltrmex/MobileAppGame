using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {
    private int startHealth = 100;
    private PlayerStats playerStats;
    public Slider healthSlider;
    public int currentHealth;

    // Use this for initialization
    void Start () {
        currentHealth = startHealth;
        playerStats = GameObject.FindGameObjectWithTag("Manager").GetComponent<PlayerStats>();
	}   //  Start()

    public void TakeDamage(int damage) {
        currentHealth -= damage;
        
        if (currentHealth <= 0)
            Death();
    }   //  TakeDamage

    void Death() {
        playerStats.gold += 20;
        Destroy(gameObject);
    }   //  Death()

	// Update is called once per frame
	void Update () {
        healthSlider.value = currentHealth;
    }   //  Update()
}   //  EnemyHealth
