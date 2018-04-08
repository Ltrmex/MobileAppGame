using UnityEngine;

public class TowerUI : MonoBehaviour {
    private Placement target;
    public GameObject ui;

    public void SetTarget(Placement target) {
        this.target = target;

        transform.position = this.target.GetBuildPosition();
        ui.SetActive(true);
    }   //  SetTarget()

    public void Hide() {
        ui.SetActive(false);
    }   //  Hide()
}   //  TowerUI
