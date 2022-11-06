using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PickUpPistol : MonoBehaviour
{
    public float CastDistance;
    public Collider CastTarget;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject FakePistol;
    public GameObject RealPistol;
    public GameObject crosshairBoundary;
    public GameObject GuideArrow;

    void Update()
    {
        CastDistance = PlayerCasting.DistanceFromTarget;
        CastTarget = PlayerCasting.HitTarget;
    }

    void OnMouseOver()
    {
        if (CastDistance <= 5 && CastTarget == this.GetComponent<BoxCollider>())
        {
            crosshairBoundary.SetActive(true);
            actionText.GetComponent<Text>().text = "Pick up Pistol";
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
            if (Input.GetButtonDown("Action"))
            {
                this.GetComponent<BoxCollider>().enabled = false;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                FakePistol.SetActive(false);
                RealPistol.SetActive(true);
                crosshairBoundary.SetActive(false);
                GuideArrow.SetActive(false);
            }
        }
    }

    void OnMouseExit()
    {
        crosshairBoundary.SetActive(false);
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }
}
