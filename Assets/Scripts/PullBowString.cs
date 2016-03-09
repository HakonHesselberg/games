using UnityEngine;
using System.Collections;

public class PullBowString : MonoBehaviour {

    public Rigidbody Bullet;
    public float speed;

    // Update is called once per frame
    void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
            speed += Time.deltaTime*300;
        }
        if (Input.GetButtonUp("Fire2"))
            {
                if (speed > 40) {
                    speed = 40;
                    }
                Vector3 spawnVector = transform.position;
                spawnVector.x += 1;
                Rigidbody instantiatedProjectile = Instantiate(Bullet, spawnVector, transform.rotation) as Rigidbody;
                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            
            }

    }
}
