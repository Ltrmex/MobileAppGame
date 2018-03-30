using System;
using UnityEngine;

public class GenerateMap : MonoBehaviour {
    public GameObject[] prefabs;
    public static string difficulty = "Medium";
    public GameObject start;

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
        TextAsset bind = Resources.Load(difficulty) as TextAsset;
        string data = bind.text.Replace(Environment.NewLine, string.Empty);
        GameObject waypoints = Resources.Load("Easy Waypoints") as GameObject; ;

        if (difficulty == "Easy") {
            start.transform.position = new Vector3(100f, 0f, 80f);
        }   //  if
        else if (difficulty == "Medium") {
            waypoints = Resources.Load("Medium Waypoints") as GameObject;
            start.transform.position = new Vector3(130f, 0f, 140f);
        }   //  else if
        else {

        }   //  else

        Instantiate(waypoints, waypoints.transform.position, waypoints.transform.rotation);

        return data.Split('!');
    }   // Read() 
}   //  GenerateMap
