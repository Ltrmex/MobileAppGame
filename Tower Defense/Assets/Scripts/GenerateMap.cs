using System;
using UnityEngine;

public class GenerateMap : MonoBehaviour {
    public GameObject[] prefabs;

    // Use this for initialization
    void Start() {
        CreateMap();
    }   //  Start ()

    private void CreateMap() {
        string[] mapData = Read();

        int xSize = mapData[0].ToCharArray().Length;
        int ySize = mapData.Length;

        for (int y = 0; y < ySize; y++) {
            char[] newWall = mapData[y].ToCharArray();

            for (int x = 0; x < xSize; x++) {
                PlaceWall(newWall[x].ToString(), x, y);
            }
        }
    }   //  GenerateMap()

    private void PlaceWall(string type, int x, int y) {
        int index = int.Parse(type);

        GameObject wall = Instantiate(prefabs[index]) as GameObject;
        wall.transform.position = new Vector3(10 * x, 0, 10 * y);
    }   //  PlaceWall()

    private string[] Read() {
        TextAsset bind = Resources.Load("Medium") as TextAsset;
        string data = bind.text.Replace(Environment.NewLine, string.Empty);

        return data.Split('-');
    }   // Read() 
}   //  GenerateMap
