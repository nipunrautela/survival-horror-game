using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{
    public GameObject target;
    public static float distanceFromTarget;
    public float toTarget;

    // Update is called once per frame
    void Update()
    {
        toTarget = Vector3.Distance(transform.position, target.transform.position);
        PlayerCasting.distanceFromTarget = toTarget;
    }
}
