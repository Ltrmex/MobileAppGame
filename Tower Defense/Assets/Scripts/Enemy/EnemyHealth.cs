using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {
    public Slider healthSlider;
    public int currentHealth;
    private int startHealth = 100;

    // Use this for initialization
    void Start () {
        currentHealth = startHealth;
	}   //  Start()

    public void TakeDamage(int damage) {
        currentHealth -= damage;
        

        if (currentHealth <= 0)
            Death();
    }   //  TakeDamage

    void Death() {
        Destroy(gameObject);
    }   //  Death()

	// Update is called once per frame
	void Update () {
        healthSlider.value = currentHealth;
    }   //  Update()
}   //  EnemyHealth
