using UnityEngine;
using System.Collections;

public class ShootRight : MonoBehaviour {

    public Rigidbody Bullet;
    public float speed = 20;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody instantiatedProjectile = Instantiate(Bullet, transform.position + (transform.right * 1) + (transform.forward * 0.5f), transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
        }

    }
}
