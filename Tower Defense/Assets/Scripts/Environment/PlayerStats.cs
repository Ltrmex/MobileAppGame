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
    public string playerName;
    public static string userMessage;
    public static int lives;
    public GameObject gameOver;
    public GameObject buttons;
    public GameObject tabs;
    public GameObject pauseMenu;

    private DataController dataController;
    private WaveSpawn waveSpawn;
    private bool isClicked = false;

    // Use this for initialization
    void Start() {
        Time.timeScale = 1;

        gameOver.SetActive(false);
        buttons.SetActive(true);
        tabs.SetActive(true);

        dataController = FindObjectOfType<DataController>();
        waveSpawn = FindObjectOfType<WaveSpawn>();

        gold = 200;
        turrets = 2;
        beams = 1;
        userMessage = "Click: S - Open Tab, T - Place Turret, B - Place Beam. Keyboard: ESC - Pause";
        playerName = "Player 1";
        isClicked = false;
    }   //  Start()

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
            Pause();

        goldDisplay.text = "Gold: " + gold;
        turretsDisplay.text = "Turrets: " + turrets;
        difficultyDisplay.text = "Difficulty: " + GenerateMap.difficulty;
        livesDisplay.text = "Lives: " + lives;
        beamsDisplay.text = "Beams: " + beams;
        userMessageDisplay.text = "" + userMessage;

        if (lives <= 0) {
            GameOver();
            if (isClicked)
                dataController.Submit(waveSpawn.waveNumber, playerName, GenerateMap.difficulty);
        }   //  if

    }   //  Update()

    public void GetInput(string playerName) {
        this.playerName = playerName;
    }   //  GetInput()

    public void Clicked() {
        isClicked = true;
    }   //  Clicked()

    void GameOver() {
        gameOver.SetActive(true);
        buttons.SetActive(false);
        tabs.SetActive(false);
    }   //  GameOver()

    void Pause() {
        
        if (Time.timeScale == 1) {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }   //  inner if

        else if (Time.timeScale == 0) {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }   //  inner else
    }   //  Pause()

    public void Quit() {
        Application.Quit();
    }   //  Quit()
}   //  PlayerStats
