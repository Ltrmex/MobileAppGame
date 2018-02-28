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

public class Click : MonoBehaviour {
    //  Variables
    public Text goldDisplay;
    public Text gpc;
    public float gold = 0.0f;
    public int goldPerClick = 1;

    private void Update() {
        goldDisplay.text = "Gold: " + gold;
        gpc.text = goldPerClick + " Gold/Click";
    }   //  Update()

    public void Clicked() {
        gold += goldPerClick;
    }   //  Clicked()
}   //  Click
