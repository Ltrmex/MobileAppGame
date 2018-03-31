using UnityEngine;

public class Placement : MonoBehaviour {
    public Color startColor;
    public Color hoverColor;
    public Vector3 offset;
    private new Renderer renderer;
    private GameObject place;
    private PlayerStats playerStats;

    private void Start() {
        renderer = GetComponent<Renderer>();
        playerStats = GameObject.FindGameObjectWithTag("Manager").GetComponent<PlayerStats>();
    }   //  Start()

    private void OnMouseEnter() {
        renderer.material.color = hoverColor;
    }   //  OnMouseEnter()

    private void OnMouseExit() {
        renderer.material.color = startColor;
    }   //  OnMouseExit()

    private void OnMouseDown() {
        if (place != null) {
            Debug.Log("Already Occupied!");
            return;
        }   //  if
        else if (playerStats.turrets <= 0) {
            Debug.Log("Not Enough Turrets Bought!");
            return;
        }   //  else if

        GameObject build = Builder.instance.GetTurret();
        place = (GameObject)Instantiate(build, transform.position + offset,transform.rotation);
        --playerStats.turrets;
    }   //  OnMouseDown()
}   //  Placement
