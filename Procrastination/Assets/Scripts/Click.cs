/*
Name: Maciej Majchrzak
G-Number: G00332746
Group: B
Code Reference: https://www.youtube.com/watch?v=sTJyJvHZZ1I
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {
    //  Variables
    public UnityEngine.UI.Text goldDisplay;
    public UnityEngine.UI.Text gpc;
    public float gold = 0.0f;
    public int goldPerClick = 1;

    private void Update() {
        goldDisplay.text = "Gold: " + gold;
        gpc.text = "GPC: " + goldPerClick;
    }   //  Update()

    public void Clicked() {
        gold += goldPerClick;
    }   //  Clicked()
}   //  Click
