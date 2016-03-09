using UnityEngine;
using System.Collections;

public class DestroyTimer : MonoBehaviour {

    public float destroyTimer = 7;

    void Start()
    {
        Destroy(transform.gameObject, destroyTimer);
    }
}
