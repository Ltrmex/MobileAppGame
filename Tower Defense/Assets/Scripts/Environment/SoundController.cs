using UnityEngine;

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