using UnityEngine;

public class Highscores : MonoBehaviour {
    public User [] user;
    private int i = 0;
    private DataController dataController;
    private Data []data;

    // Use this for initialization
    void Start () {
        dataController = FindObjectOfType<DataController>();
        data = dataController.Get();

        while (i < user.Length) {
            user[i].Name = data[i].name;
            user[i].Difficulty = data[i].difficulty;
            user[i].Wave = data[i].wave;
            user[i].SetValues();

            ++i;
        }   //  for

	}   //  Start()

}   //  Highscores
