using UnityEngine;

//  CODE ADAPTED FROM: https://www.youtube.com/watch?v=82Mn8v55nr0

public class SoundController : MonoBehaviour {
    private static SoundController instance = null;

    public static SoundController Instance {
        get { return instance; }
    }

    void Awake() {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        }
        else {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }   //  Awake()
}   //  SoundController