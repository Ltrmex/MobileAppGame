﻿using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {
    public Text goldDisplay;
    public Text turretsDisplay;
    public int gold;
    public int turrets;

    // Use this for initialization
    void Start () {
        gold = 0;
        turrets = 1;
	}   //  Start()
	
	// Update is called once per frame
	void Update () {
        goldDisplay.text = "Gold: " + gold;
        turretsDisplay.text = "Turrets: " + turrets;
    }   //  Update()
}   //  PlayerStats