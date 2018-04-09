using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {
    public Text goldDisplay;
    public Text turretsDisplay;
    public Text difficultyDisplay;
    public Text livesDisplay;
    public Text beamsDisplay;
    public Text userMessageDisplay;

    public int gold;
    public int turrets;
    public int beams;
    public static string userMessage;
    public static int lives;
    public GameObject gameOver;
    public GameObject buttons;
    public GameObject tabs;

    // Use this for initialization
    void Start () {
        gameOver.SetActive(false);
        buttons.SetActive(true);
        tabs.SetActive(true);

        gold = 200;
        turrets = 2;
        beams = 1;
        lives = 5;
        userMessage = "User Messages!";
    }   //  Start()
	
	// Update is called once per frame
	void Update () {
        goldDisplay.text = "Gold: " + gold;
        turretsDisplay.text = "Turrets: " + turrets;
        difficultyDisplay.text = "Difficulty: " + GenerateMap.difficulty;
        livesDisplay.text = "Lives: " + lives;
        beamsDisplay.text = "Beams: " + beams;
        userMessageDisplay.text = "" + userMessage;

        if (lives <= 0) {
            gameOver.SetActive(true);
            buttons.SetActive(false);
            tabs.SetActive(false);
        }   //  if

    }   //  Update()

}   //  PlayerStats
