using UnityEngine;
using System.Collections;

public class PullBowString : MonoBehaviour {

    public Rigidbody Bullet;
    public float speed;

    void Start()
    {
        //print(Mathf.Sin(90*(Mathf.PI/180)));
        //print(Mathf.Sin(0));
        //print(Mathf.Sin(Mathf.PI / 2));
        //print(Mathf.Sin(2));
        //print(Mathf.Sin(3));
        //print(Mathf.Sin(4));
        //print(Mathf.Sin(5));
        //print(Mathf.Cos(0));
        //print(Mathf.Cos(1));
        //print(Mathf.Cos(2));
        //print(Mathf.Cos(3));
        //print(Mathf.Cos(4));
        //print(Mathf.Cos(5));
    }

    void Update () {
        if (Input.GetButton("Fire2"))
        {
            speed += Time.deltaTime*100;
        }
        if (Input.GetButtonUp("Fire2"))
            {
                if (speed > 10) {
                    speed = 10;
                    }
                Vector3 spawnVector = transform.position;
            //spawnVector.x += 1;
            //spawnVector.z += 1;
            spawnVector.y += 1;
            float deg = transform.rotation.y;
            spawnVector.x += 1 + (Mathf.Cos(Mathf.Deg2Rad*deg));
            //print(Mathf.Cos(transform.rotation.y) * (Mathf.PI / 180));
            //print(Mathf.Cos(transform.rotation.y));
            spawnVector.z += 1 + (Mathf.Sin(Mathf.Deg2Rad * deg));
            //print(Mathf.Sin(transform.rotation.y) * (Mathf.PI / 180));
            Rigidbody instantiatedProjectile = Instantiate(Bullet, spawnVector, transform.rotation) as Rigidbody;
                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
                speed = 0;
            }

    }
}
