using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {
    public Text goldDisplay;
    public Text turretsDisplay;
    public Text difficultyDisplay;
    public int gold;
    public int turrets;
    
    // Use this for initialization
    void Start () {
        gold = 200;
        turrets = 1;
	}   //  Start()
	
	// Update is called once per frame
	void Update () {
        goldDisplay.text = "Gold: " + gold;
        turretsDisplay.text = "Turrets: " + turrets;
        difficultyDisplay.text = "Difficulty: " + GenerateMap.difficulty;
    }   //  Update()
}   //  PlayerStats
