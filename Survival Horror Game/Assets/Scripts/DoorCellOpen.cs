using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCellOpen : MonoBehaviour
{
    public float theDistance = 100;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject theDoor;
    public AudioSource creakSound;

    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;

        if (theDistance <= 3)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
            if (Input.GetButtonDown("Action"))
            {
                this.GetComponent<BoxCollider>().enabled = false;
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
                creakSound.Play();
            }
        }
        else
        {
            actionDisplay.SetActive(false);
            actionText.SetActive(false);
        }

    }
}
