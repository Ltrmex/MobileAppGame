/*
Name: Maciej Majchrzak
G-Number: G00332746
Group: B
Code Reference: https://www.youtube.com/watch?v=sTJyJvHZZ1I
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {
    //  Variables
    public Click click;
    public Text itemInfo;
    public float cost;
    public int count = 0;
    public int clickPower;
    public string itemName;
    private float baseCost;

    private void Start() {
        baseCost = cost;
    }   //  Start()

    private void Update() {
        itemInfo.text = itemName + "\nCost: " + cost + "\nPower: " + clickPower;
    }   //  Update()

    public void PurchasedUpgrade() {
        if (click.gold >= cost) {
            click.gold -= cost;
            ++count;
            click.goldPerClick += clickPower;

            // Increase the price
            cost = Mathf.Round(baseCost * Mathf.Pow(1.15f, count));
        }   //  if
    }   //  PurchasedUpgrade()

}   //  UpgradeManager
