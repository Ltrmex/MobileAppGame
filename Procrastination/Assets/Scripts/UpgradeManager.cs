/*
Name: Maciej Majchrzak
G-Number: G00332746
Group: B
Code Reference: https://www.youtube.com/watch?v=sTJyJvHZZ1I
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour {
    //  Variables
    public Click click;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int count = 0;
    public int clickPower;
    public string itemName;
    private float _newCost;

    private void Update() {
        itemInfo.text = itemName + "\nCost: " + cost + "\nPower: " + clickPower;
    }   //  Update()

    public void PurchasedUpgrade() {
        if (click.gold >= cost) {
            click.gold -= cost;
            ++count;
            click.goldPerClick += clickPower;

            // Increase the price
            cost = Mathf.Round(cost * 1.15f);
            _newCost = Mathf.Pow(cost, _newCost = cost);
        }   //  if
    }   //  PurchasedUpgrade()

}   //  UpgradeManager
