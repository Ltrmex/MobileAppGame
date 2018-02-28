using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour {
    public Text itemInfo;
    public Click click;
    public float cost;
    public int tickValue;
    public int count;
    public string itemName;
    private float baseCost;

    private void Start() {
        baseCost = cost;
    }

    private void Update() {
        itemInfo.text = itemName + "\nCost: " + cost + "\nGold:" + tickValue + "\n";
    }

    public void PurchasedItem() {
        if (click.gold >= cost) {
            click.gold -= cost;
            ++count;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.15f, count));
        }
    }
}   //  ItemManager
