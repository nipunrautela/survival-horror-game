using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class opening_001 : MonoBehaviour
{
    public GameObject player;
    public GameObject fadeScreenIn;
    public GameObject TextBox;

    void Start()
    {
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(2f);
        fadeScreenIn.SetActive(false);
        TextBox.GetComponent<TextMeshProUGUI>().text = "What is this place?!";
        yield return new WaitForSeconds(3f);
        TextBox.GetComponent<TextMeshProUGUI>().text = "I must get out of here?!";
        yield return new WaitForSeconds(3f);
        TextBox.GetComponent<TextMeshProUGUI>().text = "";
    }
}
