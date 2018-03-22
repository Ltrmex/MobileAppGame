using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour {
    public static Builder instance; //  singleton
    private GameObject build;
    public GameObject prefab;

    private void Awake() {
        if(instance != null) {
            Debug.Log("Already defined");
            return;
        }   //  if

        instance = this;
    }   //  Awake()

    private void Start() {
        build = prefab;
    }   //  Start()

    public GameObject GetTurret() {

        return build;
    }   //  GetTurret()

}   //  Builder
