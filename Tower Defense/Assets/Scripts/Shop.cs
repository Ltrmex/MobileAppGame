using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour {
    private PlayerStats playerStats;
    private static int cost;
    public Text costDisplay;

	// Use this for initialization
	void Start () {
        playerStats = GameObject.FindGameObjectWithTag("Manager").GetComponent<PlayerStats>();
        cost = 200;
    }   //  Start()
	
	// Update is called once per frame
	void Update () {
        costDisplay.text = "Cost: " + cost;
    }   //  Update()

    public void BuyTurret() {
        if (cost > playerStats.gold) {
            Debug.Log("Not Enough Gold!");
            return;
        }   //  if

        ++playerStats.turrets;
        playerStats.gold -= cost;

        cost = (int)(cost * 0.20) + cost;

        SoldItem();
    }   //  BuyTurret()

    private void SoldItem() {
        gameObject.GetComponentInChildren<Text>().text = "SOLD";
        gameObject.GetComponent<Image>().color = Color.red;
        gameObject.GetComponent<Button>().interactable = false;
    }   //  SoldItem()

    public void Upgrade() {

    }   // Upgrade() 
}   //  Shop
