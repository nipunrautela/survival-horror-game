using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class opening_002 : MonoBehaviour
{
    public GameObject player;
    public GameObject TextBox;
    public GameObject marker;

    void OnTriggerEnter(Collider other)
    {
        player.GetComponent<MouseLook>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
        StartCoroutine(ScenePlayer());
        this.GetComponent<BoxCollider>().enabled = false;
    }

    IEnumerator ScenePlayer()
    {
        TextBox.GetComponent<TextMeshProUGUI>().text = "A room?! Is that a gun on that table?!";
        yield return new WaitForSeconds(3f);
        TextBox.GetComponent<TextMeshProUGUI>().text = "";
        player.GetComponent<MouseLook>().enabled = true;
        player.GetComponent<PlayerMovement>().enabled = true;
        marker.SetActive(true);
    }
}
