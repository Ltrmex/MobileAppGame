/*
Name: Maciej Majchrzak
Code Adapted From: https://github.com/Brackeys/Tower-Defense-Tutorial
*/
using System;
using UnityEngine;

public class Turret : MonoBehaviour {
    //  Variables
    private Transform target;   //  current target - enemy

    [Header("Attributes")]
    public float range = 15f;   //  range of the shooting & following
    public float fireRate = 1f; //  fire one bullet each second
    private float fireCountdown = 0f;   //  shooting countdown

    public bool shootLaser = false;
    public LineRenderer lineRenderer;
    public ParticleSystem laserEffect;

    [Header("Unity Setup Fields")]
    public string enemyTag = "Enemy";   //  tag reference
    public Transform gun;  //  reference to part which will rotate
    public float turnSpeed = 10f;   //  how fast turret rotates
    public GameObject bulletPrefab; //  bullet reference
    public Transform firePoint; //  reference to point at which bullet spawns

    // Use this for initialization
    void Start() {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);  //  repeat updating the target at a interval
    }   //   Start()

    //  Update target - which enemy turret will follow
    void UpdateTarget() {
        //  Variables
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag); //  get reference to all of the enemies
        float shortestDistance = Mathf.Infinity;    //  shortest distance to enemy
        GameObject nearestEnemy = null; //  nearest enemy that was found

        //  Loop through each enemy
        foreach (GameObject enemy in enemies) {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position); //  variable to store distance between the turret and enemy

            //  Check if enemy's location is the shortest 
            if (distanceToEnemy < shortestDistance) {
                shortestDistance = distanceToEnemy; //  set new shortestDistance
                nearestEnemy = enemy;   //  mark this enemy as the nearest one
            }   //  if
        }   //  foreach

        //  If found enemy and within range
        if (nearestEnemy != null && shortestDistance <= range)
            target = nearestEnemy.transform;    //  set this enemy as a target
        else
            target = null;  //  else no target

    }   //  UpdateTarget()

    // Update is called once per frame
    void Update() {
        if (target == null) { //  if no target then return
            if (shootLaser) {
                if (lineRenderer.enabled) {
                    lineRenderer.enabled = false;
                    laserEffect.Stop();
                }   //  if
            }   //  inner if

            return;
        }   //  if

        //  Lock on
        LockOn();

        if (shootLaser) { 
            Laser();
        }   //  if
        else { 
            //  If time to shoot
            if (fireCountdown <= 0f) {
                Shoot();    //  then shoot
                fireCountdown = 1f / fireRate;  //  set fireCountdown
            }   //  if

            fireCountdown -= Time.deltaTime;    //  countdown fireCountdown
        }   //  else
    }   //  Update()

    private void Laser() {
        if (!lineRenderer.enabled) {
            lineRenderer.enabled = true;
            laserEffect.Play();
        }   //  if
            

        lineRenderer.SetPosition(0, firePoint.position);
        lineRenderer.SetPosition(1, target.position);

        Vector3 direction = firePoint.position - target.position;

        laserEffect.transform.position = target.position + direction.normalized;

        laserEffect.transform.rotation = Quaternion.LookRotation(direction);

    }   //  Laser()

    private void LockOn() {
        //  Target lock on
        Vector3 direction = target.position - transform.position;   //  direction to point at, direction from one point to another point
        Quaternion lookRotation = Quaternion.LookRotation(direction);   //  turn rotation

        //  Rotation - smooth transition over time
        Vector3 rotation = Quaternion.Lerp(gun.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;

        //  Rotate head of the turret
        gun.rotation = Quaternion.Euler(0f, rotation.y, 0f);    //   around y axis

    }   //  LockOn()

    void Shoot() {
        //  Variables
        GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);    //  temporary reference to the bullet, create instance of bullet
        Bullet bullet = bulletGO.GetComponent<Bullet>();    //  get bullet script

        if (bullet != null) //  if bullet is not null
            bullet.Seek(target);    //  seek enemy target
    }   //  Shoot()

    //  Display turret's range when selected
    void OnDrawGizmosSelected() {
        Gizmos.DrawWireSphere(transform.position, range);   //  draw sphere with range as radius
    }   //  OnDrawGizmosSelected()
}   //  Turret
