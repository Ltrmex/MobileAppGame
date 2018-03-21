using UnityEngine;

public class GenerateMap : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        GameObject prefab = Resources.Load("Nodes") as GameObject;

        for (int i = 0; i < 15; i++) {
            GameObject go = Instantiate(prefab) as GameObject;
            go.transform.position = new Vector3(0, 0, i*5);
        }   //  for
    }   //  Start ()

}   //  GenerateMap
