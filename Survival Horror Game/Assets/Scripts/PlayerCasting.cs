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
        RaycastHit hit;
        if (Physics.Raycast(transform.position, target.transform.position, out hit))
        {
            toTarget = hit.distance;
            PlayerCasting.distanceFromTarget = toTarget;
        }
    }
}
