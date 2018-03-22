using UnityEngine;

public class Placement : MonoBehaviour {
    public Color startColor;
    public Color hoverColor;
    public Vector3 offset;
    private new Renderer renderer;
    private GameObject place;

    private void Start() {
        renderer = GetComponent<Renderer>();
    }   //  Start()

    private void OnMouseEnter() {
        renderer.material.color = hoverColor;
    }   //  OnMouseEnter()

    private void OnMouseExit() {
        renderer.material.color = startColor;
    }   //  OnMouseExit()

    private void OnMouseDown() {
        if (place != null) {
            Debug.Log("Already occupied");
            return;
        }   //  if

        GameObject build = Builder.instance.GetTurret();
        place = (GameObject)Instantiate(build, transform.position + offset,transform.rotation);

    }   //  OnMouseDown()
}   //  Placement
