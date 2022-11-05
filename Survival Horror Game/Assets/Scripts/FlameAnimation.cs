using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameAnimation : MonoBehaviour
{
    public int LightMode;
    public GameObject FlameLight;

    void Update()
    {
        if (LightMode == 0) {
            StartCoroutine(AnimateLight());
        }
    }

    IEnumerator AnimateLight() {
        LightMode = Random.Range(1, 4);
        FlameLight.GetComponent<Animation>().Play("TorchAnim"+LightMode);

        yield return new WaitForSeconds(0.99f);
        LightMode = 0;
    }
}
