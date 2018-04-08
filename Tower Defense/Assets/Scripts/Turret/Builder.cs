using System;
using UnityEngine;

public class Builder : MonoBehaviour {
    private GameObject build;
    private Placement selectedTower;
    public static Builder instance; //  singleton
    public GameObject turretPrefab;
    public GameObject beamPrefab;
    public TowerUI towerUI;

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

    public void SelectTower(Placement tower) {
        if (selectedTower == tower) {
            FocusOut();
            return;
        }   //  if
            
        selectedTower = tower;
        build = null;

        towerUI.SetTarget(selectedTower);
    }   //  SelectTower()

    private void FocusOut() {
        selectedTower = null;
        towerUI.Hide();
    }   //  FocusOut()

    public void SetTurret(GameObject tower) {
        build = tower;
        selectedTower = null;

        FocusOut();
    }   //  SetTurret()

}   //  Builder
