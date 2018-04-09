using UnityEngine;

//  CODE ADAPTED FROM: https://www.youtube.com/playlist?list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0

public class Bullet : MonoBehaviour {
    //  Variables
    private Transform target;   //  enemy target
    public float speed = 70f;   //  speed of bullets
    public GameObject impactEffect; //  when bullet hits the enemy
    
    //  Set the enemy target
    public void Seek(Transform _target) {
        target = _target;
    }   //  Seek

    // Update is called once per frame
    void Update() {

        //  If no target
        if (target == null) {
            Destroy(gameObject);    //  destroy the bullet
            return; //  return - destroy might take a while to finish off
        }   //  if

        Vector3 direction = target.position - transform.position;   //  find direction for bullet to travel
        float distance = speed * Time.deltaTime;   //  how much move per frame

        //  Check if length of direction vector is less than or equal to distance is moved this frame
        if (direction.magnitude <= distance) {
            HitTarget();    //  then target was hit
            return; //  if enemy hit then return
        }   //  if

        //  Move the bullet in proper direction
        transform.Translate(direction.normalized * distance, Space.World);  //   move at constant speed

    }   //  Update()

    //  When target is hit
    void HitTarget() {
        //  Create instance of the particle effect
        GameObject effect = (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effect, 2f);    //  destroy the effect after two seconds

        target.GetComponent<EnemyHealth>().TakeDamage(50);

        Destroy(gameObject);    //  destroy bullet
    }   //  HitTarget()
}   //  Bullet
