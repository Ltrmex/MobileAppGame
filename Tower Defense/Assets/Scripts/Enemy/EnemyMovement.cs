using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public float startSpeed = 10f;
    public float speed;
    private Transform target;
    private int wavepointIndex;

	// Use this for initialization
	void Start () {
        speed = startSpeed;
        wavepointIndex = 0;
        target = Waypoints.waypoints[0];
    }   //  Start ()

    // Update is called once per frame
    void Update () {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
            GetNext();

        speed = startSpeed;
    }   //  Update ()

    private void GetNext() {
        if (wavepointIndex >= Waypoints.waypoints.Length - 1) { 
            Destroy(gameObject);
            --PlayerStats.lives;
            Debug.Log("Lives left: " + PlayerStats.lives);
            return;
        }   //  if

        ++wavepointIndex;
        target = Waypoints.waypoints[wavepointIndex];
    }   //  GetNext()

    public void Slow(float percentage) {
        speed = startSpeed * (1f - percentage);
    }   //  Slow()
}   //  EnemyMovement
