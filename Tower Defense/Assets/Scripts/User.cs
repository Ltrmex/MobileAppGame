using UnityEngine.UI;

[System.Serializable]
public class User {
    public Text nameDisplay;
    public Text difficultyDisplay;
    public Text waveDisplay;

    private string name;
    private string difficulty;
    private int wave;

    public string Name {
        get { return name; }
        set { name = value; }
    }   //  Name

    public string Difficulty {
        get { return difficulty; }
        set { difficulty = value; }
    }   //  Difficulty

    public int Wave {
        get { return wave; }
        set { wave = value; }
    }   //  Wave

    public void SetValues() {
        nameDisplay.text = Name;
        difficultyDisplay.text = Difficulty;
        waveDisplay.text = Wave.ToString();
    }   //  SetValues()
}   //  User
