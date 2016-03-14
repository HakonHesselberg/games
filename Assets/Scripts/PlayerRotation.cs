using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour
{
    private float hitDist;
    private Vector3 targetPoint;
    CharacterController cc;

    void Start()
    {
        hitDist = 0;
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        var playerPlane = new Plane(Vector3.up, transform.position);
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (playerPlane.Raycast(ray, out hitDist))
        {
            targetPoint = ray.GetPoint(hitDist);
        }

        cc.transform.LookAt(targetPoint);
    }
}