using UnityEngine;
using System.Collections;

public class PullBowString : MonoBehaviour
{

    public Rigidbody Bullet;
    public float speed;

    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            speed += Time.deltaTime * 100;
        }
        if (Input.GetButtonUp("Fire2"))
        {
            if (speed > 10)
            {
                speed = 10;
            }
            Vector3 spawnVector = transform.position;

            Rigidbody instantiatedProjectile = Instantiate(Bullet, transform.position + (transform.right * 1) + (transform.forward * 0.5f), transform.rotation) as Rigidbody;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            speed = 0;
        }

    }
}
