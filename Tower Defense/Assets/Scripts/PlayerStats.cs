using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {
    public Text goldDisplay;
    public Text turretsDisplay;
    public Text difficultyDisplay;
    public Text livesDisplay;

    public int gold;
    public int turrets;
    public static int lives = 5;
    public GameObject gameOver;
    
    // Use this for initialization
    void Start () {
        gameOver.SetActive(false);
        gold = 200;
        turrets = 2;
        lives = 5;
    }   //  Start()
	
	// Update is called once per frame
	void Update () {
        goldDisplay.text = "Gold: " + gold;
        turretsDisplay.text = "Turrets: " + turrets;
        difficultyDisplay.text = "Difficulty: " + GenerateMap.difficulty;
        livesDisplay.text = "Lives: " + lives;

        if (lives <= 0) {
            gameOver.SetActive(true);
        }   //  if

    }   //  Update()
}   //  PlayerStats
