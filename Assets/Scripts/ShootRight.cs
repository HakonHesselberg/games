using UnityEngine;
using System.Collections;

public class ShootRight : MonoBehaviour {

    public GameObject Bullet;
    public Transform shotSpawn;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1"))
        {
            Instantiate(Bullet, shotSpawn.position, shotSpawn.rotation);
            GameObject clone = Instantiate(Bullet, transform.position, transform.rotation) as GameObject;
        }
	}
}
