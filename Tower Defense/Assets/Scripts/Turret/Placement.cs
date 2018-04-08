using UnityEngine;
using UnityEngine.EventSystems;

public class Placement : MonoBehaviour {
    public Color startColor;
    public Color hoverColor;
    public Vector3 offset;

    private new Renderer renderer;
    private GameObject place;
    Builder buildManager;
    PlayerStats playerStats;

    void Start() {
        renderer = GetComponent<Renderer>();
        buildManager = Builder.instance;
        playerStats = GameObject.FindGameObjectWithTag("Manager").GetComponent<PlayerStats>();
    }   //  Start()

    public Vector3 GetBuildPosition() {
        return transform.position + offset;
    }   //  GetBuildPosition()

    private void OnMouseEnter() {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (buildManager.GetTurret() == null)
            return;
        else if (playerStats.turrets <= 0 && buildManager.GetTurret().tag == "Turret")
            return;
        else if (playerStats.beams <= 0 && buildManager.GetTurret().tag == "Beam")
            return;

        renderer.material.color = hoverColor;
    }   //  OnMouseEnter()

    private void OnMouseExit() {
        renderer.material.color = startColor;
    }   //  OnMouseExit()

    private void OnMouseDown() {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (place != null) {
            buildManager.SelectTower(this);
            return;
        }   //  if
        else if (playerStats.turrets <= 0 && buildManager.GetTurret().tag == "Turret") {
            Debug.Log("Not Enough Turrets Bought!");
            return;
        }   //  else if
        else if (playerStats.beams <= 0 && buildManager.GetTurret().tag == "Beam") {
            Debug.Log("Not Enough Beams Bought!");
            return;
        }   //  else if

        if (buildManager.GetTurret() == null)
            return;

        if (buildManager.GetTurret().tag == "Turret")
            --playerStats.turrets;
        else if (buildManager.GetTurret().tag == "Beam")
            --playerStats.beams;

        GameObject build = buildManager.GetTurret();
        place = (GameObject)Instantiate(build, transform.position + offset,transform.rotation);
        
    }   //  OnMouseDown()
}   //  Placement
