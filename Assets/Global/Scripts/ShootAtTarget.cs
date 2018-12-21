using UnityEngine;
using System.Collections;

public class ShootAtTarget : MonoBehaviour {

    private float nextActionTime = 0.0f;
    public float period = 0.01f;
    public bool shouldLookAt = true;

    public GameObject bullet = null;
    public float bulletSpeed = 500f;
    public Transform target;

	// Use this for initialization
	void Awake () {
        Debug.Log("I've been made");
    }

    // Update is called once per frame
    //void Update () {
    //    if (shouldLookAt)
    //        transform.LookAt(target);
    //    if (Time.time > nextActionTime)
    //    {
    //        nextActionTime += period;
    //        // execute block of code here
    //        Shoot();
    //    }
    //}

    // Shoot at target
    void Shoot()
    {
        //GameObject shot = GameObject.Instantiate(bullet, transform.position + (transform.forward * 2), transform.rotation) as GameObject;
        GameObject shot = GameObject.Instantiate(bullet, transform.position, transform.rotation) as GameObject;
        shot.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        //Debug.Log("I shoot shoot");
        //yield return new WaitForSeconds(1);
    }
}
