using UnityEngine;

public class Builder : MonoBehaviour {
    public static Builder instance; //  singleton
    private GameObject build;
    public GameObject turretPrefab;
    public GameObject beamPrefab;

    private void Awake() {
        if(instance != null) {
            Debug.Log("Already defined");
            return;
        }   //  if

        instance = this;
    }   //  Awake()

    public GameObject GetTurret() {
        return build;
    }   //  GetTurret()

    public void SetTurret(GameObject tower) {
        build = tower;
    }   //  SetTurret()

}   //  Builder
