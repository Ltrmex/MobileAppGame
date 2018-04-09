using UnityEngine;

public class Highscores : MonoBehaviour {
    public User [] user;
    int i = 0;

    // Use this for initialization
    void Start () {
        while (i < user.Length) {
            user[i].Name = "John " + (i + 1);
            user[i].Difficulty = "Easy " + (i + 1);
            user[i].Wave = (i + 1);
            user[i].SetValues();
            ++i;
        }   //  for
	}   //  Start()
	
	// Update is called once per frame
	void Update () {
		
	}
}   //  Highscores
