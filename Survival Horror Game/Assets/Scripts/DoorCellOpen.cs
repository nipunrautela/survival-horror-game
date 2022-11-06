using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DoorCellOpen : MonoBehaviour
{
    bool animPlayed = false;
    float CastDistance;
    Collider CastTarget;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject theDoor;
    public AudioSource creakSound;
    public GameObject crosshairBoundary;
    public GameObject TextBox;

    void Update()
    {
        CastDistance = PlayerCasting.DistanceFromTarget;
        CastTarget = PlayerCasting.HitTarget;
    }

    void OnMouseOver()
    {
        if (CastDistance <= 6 && CastTarget == this.GetComponent<BoxCollider>() && !animPlayed)
        {
            crosshairBoundary.SetActive(true);
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
            if (Input.GetButtonDown("Action"))
            {
                animPlayed = true;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                StartCoroutine(PlankAnimation());
                creakSound.Play();
                this.GetComponent<BoxCollider>().enabled = false;
            }
        }
    }

    void OnMouseExit()
    {
        crosshairBoundary.SetActive(false);
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }

    IEnumerator PlankAnimation()
    {
        theDoor.GetComponent<Animation>().Play("BreakPlanks");
        TextBox.GetComponent<TextMeshProUGUI>().text = "*Creak Sound*";
        yield return new WaitForSeconds(2f);
        TextBox.GetComponent<TextMeshProUGUI>().text = "";
    }
}
