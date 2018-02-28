using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldPerSecond : MonoBehaviour {
    public Text gpsDisplay;
    public Click click;
    public ItemManager[] items;

    // Use this for initialization
    void Start() {
        StartCoroutine(AutoTick());
    }

    // Update is called once per frame
    void Update() {
        gpsDisplay.text = GetGoldPerSecond() + " Gold/Sec";
    }

    public int GetGoldPerSecond() {
        int tick = 0;
  
        foreach (ItemManager item in items) {
            tick += item.count * item.tickValue;
        }

        return tick;
    }

    public void AutoGoldPerSecond() {
        click.gold += GetGoldPerSecond();
    }

    IEnumerator AutoTick() {
        while (true) {
            AutoGoldPerSecond();
            yield return new WaitForSeconds(1); 
        }
    }

}
