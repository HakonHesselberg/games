using UnityEngine;
using System.Collections;

public class BurstGun : MonoBehaviour {

    public Rigidbody Bullet;
    public float speed = 20;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.F))
        {
            Rigidbody instantiatedProjectile = Instantiate(Bullet, transform.position + (transform.right * 1) + (transform.forward * 0.5f), transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            //Rigidbody instantiatedProjectile2 = Instantiate(Bullet, transform.position + (transform.right * 0.95f) + (transform.forward * 0.5f), transform.rotation) as Rigidbody;
            //instantiatedProjectile2.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            //Rigidbody instantiatedProjectile3 = Instantiate(Bullet, transform.position + (transform.right * 1.05f) + (transform.forward * 0.5f), transform.rotation) as Rigidbody;
            //instantiatedProjectile3.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            Rigidbody instantiatedProjectile4 = Instantiate(Bullet, transform.position + (transform.right * 1.02f) + (transform.forward * 0.5f), transform.rotation) as Rigidbody;
            instantiatedProjectile4.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            Rigidbody instantiatedProjectile5 = Instantiate(Bullet, transform.position + (transform.right * 0.98f) + (transform.forward * 0.5f), transform.rotation) as Rigidbody;
            instantiatedProjectile5.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
        }
	}
}
