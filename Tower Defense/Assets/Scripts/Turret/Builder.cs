using UnityEngine;

//  CODE ADAPTED FROM: https://www.youtube.com/playlist?list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0

public class Builder : MonoBehaviour {
    private GameObject build;
    private Placement selectedTower;
    public static Builder instance; //  singleton
    public GameObject turretPrefab;
    public GameObject beamPrefab;
    public TowerUI towerUI;

    private void Awake() {
        if(instance != null) {
            PlayerStats.userMessage = "Already defined";
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
