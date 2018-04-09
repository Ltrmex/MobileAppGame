using UnityEngine;

//  CODE ADAPTED FROM: https://www.youtube.com/playlist?list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0

public class Waypoints : MonoBehaviour {
    public static Transform[] waypoints;

    private void Awake() {
        waypoints = new Transform[transform.childCount];    //  count of waypoints

        //  Get locations of waypoints
        for (int i = 0; i < waypoints.Length; i++) {
            waypoints[i] = transform.GetChild(i);   //  iterate through every waypoint
        }   //  for
    }   //  Awake()

}   //  Waypoints
