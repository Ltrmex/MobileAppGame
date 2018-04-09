using System;
using UnityEngine;

public class GenerateMap : MonoBehaviour {
    public GameObject[] prefabs;
    public static string difficulty = "Easy";
    public GameObject start;
    public GameObject end;
    public GameObject enemy;
    private EnemyHealth enemyHealth;
    private GameObject mainCamera;

    // Use this for initialization
    void Start() {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        enemyHealth = enemy.GetComponent<EnemyHealth>();
        CreateMap();
    }   //  Start ()

    private void CreateMap() {
        string[] mapData = Read();

        int xSize = mapData[0].ToCharArray().Length;
        int ySize = mapData.Length;

        for (int y = 0; y < ySize; y++) {
            char[] newWall = mapData[y].ToCharArray();

            for (int x = 0; x < xSize; x++) {
                Place(newWall[x].ToString(), x, y);
            }
        }
    }   //  GenerateMap()

    private void Place(string type, int x, int y) {
        int index = int.Parse(type);

        GameObject wall = Instantiate(prefabs[index]) as GameObject;
        wall.transform.position = new Vector3(10 * x, 0, 10 * y);
    }   //  PlaceWall()

    private string[] Read() {
        TextAsset bind = Resources.Load(difficulty) as TextAsset;
        string data = bind.text.Replace(Environment.NewLine, string.Empty);
        GameObject waypoints = Resources.Load("Easy Waypoints") as GameObject;

        if (difficulty == "Easy") {
            start.transform.position = new Vector3(100f, 0f, 80f);
            end.transform.position = new Vector3(0f, 0f, 10f);

            enemyHealth.startHealth = 100;

            mainCamera.transform.position = new Vector3(50f, 100f, 20f);
        }   //  if
        else if (difficulty == "Medium") {
            waypoints = Resources.Load("Medium Waypoints") as GameObject;

            start.transform.position = new Vector3(130f, 0f, 140f);
            end.transform.position = new Vector3(10f, 0f, 0f);

            enemyHealth.startHealth = 150;

            mainCamera.transform.position = new Vector3(70f, 150f, 30f);
        }   //  else if
        else {
            waypoints = Resources.Load("Advanced Waypoints") as GameObject;

            start.transform.position = new Vector3(0f, 0f, 250f);
            end.transform.position = new Vector3(240f, 0f, 10f);

            enemyHealth.startHealth = 200;

            mainCamera.transform.position = new Vector3(120f, 220f, 50f);
        }   //  else

        Instantiate(waypoints, waypoints.transform.position, waypoints.transform.rotation);

        return data.Split('!');
    }   // Read() 
}   //  GenerateMap
