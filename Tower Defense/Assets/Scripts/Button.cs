using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
    Sprite exit;
    Sprite hover;

	// Use this for initialization
	void Start () {
        exit = Resources.Load("Sprites/Inactive Button") as Sprite;
        hover = Resources.Load("Sprites/Active Button") as Sprite;
    }   //  Start ()

    private void OnMouseOver() {
        transform.GetComponent<SpriteRenderer>().sprite = hover;
    }   //  OnMouseOver()

    private void OnMouseExit() {
        transform.GetComponent<SpriteRenderer>().sprite = exit;
    }   //  OnMouseDown()

}   //  Button
