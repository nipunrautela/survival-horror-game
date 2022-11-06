using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    public static float DistanceFromTarget;
    public static Collider HitTarget;
    float ToTarget;
    public Collider TheTarget;

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            ToTarget = Hit.distance;
            DistanceFromTarget = ToTarget;
            TheTarget = Hit.collider;
            HitTarget = TheTarget;
        }
    }
}
