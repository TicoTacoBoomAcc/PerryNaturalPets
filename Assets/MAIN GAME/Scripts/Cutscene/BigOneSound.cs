using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigOneSound : MonoBehaviour
{
    public GameObject targetSound;

    // Start is called before the first frame update
    void Start()
    {
        targetSound.SetActive(false);

        StartCoroutine(ActivateAfterSeconds(5.8f));
    }

    IEnumerator ActivateAfterSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        targetSound.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
