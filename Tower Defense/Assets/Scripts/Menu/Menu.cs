using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    
    public void Easy() {
        LoadLevel();
        GenerateMap.difficulty = "Easy";
    }   //  Easy()

    public void Medium() {
        LoadLevel();
        GenerateMap.difficulty = "Medium";
    }   //  Medium()

    public void Advanced() {
        LoadLevel();
        GenerateMap.difficulty = "Advanced";
    }   //  Advanced()

    private void LoadLevel() {
        SceneManager.LoadScene("Main");
    }   //  LoadLevel()

    public void LoadMenu() {
        SceneManager.LoadScene("Main Menu");
    }   //  LoadLevel()

    public void Quit() {
        Application.Quit();
    }   //  Quit()

}   //  Menu
