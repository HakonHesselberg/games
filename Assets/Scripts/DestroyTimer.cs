using UnityEngine;
using System.Collections;

public class DestroyTimer : MonoBehaviour {

    public float destroyTimer;

    void Start()
    {
        Destroy(transform.gameObject, destroyTimer);
    }
}
