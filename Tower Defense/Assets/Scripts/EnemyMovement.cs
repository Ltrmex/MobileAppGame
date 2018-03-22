using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public float speed;
    private Transform target;
    private int wavepointIndex;

	// Use this for initialization
	void Start () {
        speed = 10f;
        wavepointIndex = 0;
        target = Waypoints.waypoints[0];
    }   //  Start ()

    // Update is called once per frame
    void Update () {
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
            GetNext();
    }   //  Update ()

    private void GetNext() {
        if (wavepointIndex >= Waypoints.waypoints.Length - 1) { 
            Destroy(gameObject);
            return;
        }   //  if

        ++wavepointIndex;
        target = Waypoints.waypoints[wavepointIndex];
    }   //  GetNext()
}
