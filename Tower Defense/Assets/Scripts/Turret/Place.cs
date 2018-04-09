using UnityEngine;

//  CODE ADAPTED FROM: https://www.youtube.com/playlist?list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0

public class Place : MonoBehaviour {
    Builder build;

    private void Start() {
        build = Builder.instance;
    }
    public void PlaceTurret() {
        build.SetTurret(build.turretPrefab);
    }   //  PlaceTurret()

    public void PlaceBeam() {
        build.SetTurret(build.beamPrefab);
    }   //  PlaceTurret()

}   //  Place
