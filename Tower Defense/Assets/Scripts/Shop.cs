using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour {
    private PlayerStats playerStats;
    public int cost;
    public Text costDisplay;

	// Use this for initialization
	void Start () {
        playerStats = GameObject.FindGameObjectWithTag("Manager").GetComponent<PlayerStats>();
    }   //  Start()
	
	// Update is called once per frame
	void Update () {
        costDisplay.text = "Cost: " + cost;
    }   //  Update()

    public void BuyTurret() {
        playerStats.turrets = Buy(playerStats.turrets);
    }   //  BuyTurret()

    public void BuyBeam() {
        playerStats.beams = Buy(playerStats.beams);
    }   //  BuyBeam()

    private int Buy(int counter) {
        if (cost > playerStats.gold) {
            Debug.Log("Not Enough Gold!");
            return counter;
        }   //  if

        ++counter;
        playerStats.gold -= cost;

        SoldItem();

        return counter;
    }   //  Buy()

    private void SoldItem() {
        gameObject.GetComponentInChildren<Text>().text = "SOLD";
        gameObject.GetComponent<Image>().color = Color.red;
        gameObject.GetComponent<Button>().interactable = false;
    }   //  SoldItem()

}   //  Shop
