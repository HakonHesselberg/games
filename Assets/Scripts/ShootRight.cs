using UnityEngine;
using System.Collections;

public class ShootRight : MonoBehaviour {

    public GameObject Bullet;
    public Transform shotSpawn;
    public float maxDelay = 0.2f;

    private float delayTimer = 0f;

	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1"))
        {
            if (delayTimer > maxDelay)
            {
                Instantiate(Bullet, shotSpawn.position, shotSpawn.rotation);
                delayTimer = 0;
            }

            // Til Vegard - Denne var det som gjorde at det kom for mange kuler, siden når du lager et gameObject med
            // Instantiate(...) så lager du den faktisk i spillet. Når du tar GameObject clone = Instantiate(...) så
            // får du laget objectet, i tillegg til at du setter variablen "clone" til å bli det gameObjectet. Dette
            // er nyttig hvis du for eksempel skal endre farge eller position på kulen du spawnet senere i scriptet,
            // eller få den til å eksplodere etterhvert. Eksempel clone.deathTimer(10) <-- I just made this up, not
            // real code

            //GameObject clone = Instantiate(Bullet, transform.position, transform.rotation) as GameObject;
        }
        delayTimer += Time.deltaTime;

	}
}
