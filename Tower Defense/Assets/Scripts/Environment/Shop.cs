using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour {
    private PlayerStats playerStats;
    public int cost;
    public int upgradeCost;
    public int rangeCost;
    public Text upgradeCostDisplay;
    public Text rangeCostDisplay;

    // Use this for initialization
    void Start() {
        playerStats = GameObject.FindGameObjectWithTag("Manager").GetComponent<PlayerStats>();
        upgradeCost = 200;
        rangeCost = 100;
    }   //  Start()

    public void BuyTurret() {
        playerStats.turrets = Buy(playerStats.turrets);
    }   //  BuyTurret()

    public void BuyBeam() {
        playerStats.beams = Buy(playerStats.beams);
    }   //  BuyBeam()

    public void UpgradeTurret() {
        Turret.fireRate = Upgrade(Turret.fireRate, "fireRate");
        upgradeCostDisplay.text = "Cost: " + upgradeCost;
    }   //  BuyTurret()

    public void UpgradeBeam() {
        Turret.damageOverTime = Upgrade(Turret.damageOverTime, "damageOverTime");
        upgradeCostDisplay.text = "Cost: " + upgradeCost;
    }   //  BuyBeam()

    public void Upgrade() {
        if (rangeCost > playerStats.gold) {
            PlayerStats.userMessage = "Not Enough Gold!";
            return;
        }   //  if

        playerStats.gold -= rangeCost;

        Turret.range += 1f;

        rangeCost += (int)(rangeCost * 0.20);

        rangeCostDisplay.text = "$" + rangeCost;
    }   //  Upgrade()

    private int Buy(int counter) {
        if (cost > playerStats.gold) {
            PlayerStats.userMessage = "Not Enough Gold!";
            return counter;
        }   //  if

        ++counter;
        playerStats.gold -= cost;

        SoldItem();

        return counter;
    }   //  Buy()

    private float Upgrade(float num, string s) {
        if (upgradeCost > playerStats.gold) {
            PlayerStats.userMessage = "Not Enough Gold!";
            return num;
        }   //  if

        if (s == "fireRate")
            num += 0.2f;
        else
            num += 2f;

        playerStats.gold -= upgradeCost;
        upgradeCost += (int)(upgradeCost * 0.20);

        return num;
    }   //  Buy()

    private void SoldItem() {
        gameObject.GetComponentInChildren<Text>().text = "SOLD";
        gameObject.GetComponent<Image>().color = Color.red;
        gameObject.GetComponent<Button>().interactable = false;
    }   //  SoldItem()

}   //  Shop
