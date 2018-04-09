using System;
using UnityEngine;

//  CODE ADAPTED FROM: https://unity3d.com/learn/tutorials/topics/scripting/high-score-playerprefs

public class DataController : MonoBehaviour {
    private Data [] data = new Data[5];
    private bool isSaved = false;

    private void Start() {
        isSaved = false;
        Load();
    }   //  Start()

    public void Submit(int newWave, string newName, string newDifficulty) {
        for (int i = 0; i < 5; i++) { 
            if (newWave > data[i].wave) {
                data[i].wave = newWave;
                data[i].name = newName;
                data[i].difficulty = newDifficulty;

                Array.Sort(data, delegate (Data x, Data y) { return x.wave.CompareTo(y.wave); });

                if(!isSaved)
                    Save();
                else
                    return;
            }   //  if
        }   //  for
    }   //  Submit()

    public Data [] Get() {
        return data;
    }   //  Get()

    private void Load() {
        for (int i = 0; i < 5; i++)
            data[i] = new Data();

        for (int i = 0; i < 5; i++) {
            if (PlayerPrefs.HasKey("HighWave" + ( i + 1))) {
                data[i].wave = PlayerPrefs.GetInt("HighWave" + (i + 1));
                data[i].name = PlayerPrefs.GetString("Name" + (i + 1));
                data[i].difficulty = PlayerPrefs.GetString("Difficulty" + (i + 1));
            }   //  if
        }   //  for
    }   //  Load()

    private void Save() {
        for (int i = 0; i < 5; i++) {
            PlayerPrefs.SetInt("HighWave" + (i + 1), data[i].wave);
            PlayerPrefs.SetString("Name" + (i + 1), data[i].name);
            PlayerPrefs.SetString("Difficulty" + (i + 1), data[i].difficulty);
            isSaved = true;
        }   //  for
    }   //  Save()
}   //  DataController
