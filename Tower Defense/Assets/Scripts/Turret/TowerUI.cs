using UnityEngine;

//  CODE ADAPTED FROM: https://www.youtube.com/playlist?list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0

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
