using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
