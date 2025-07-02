using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigOneAnim : MonoBehaviour
{
    public GameObject targetObject; // Assign your GameObject in the Inspector

    void Start()
    {
        targetObject.SetActive(false);
        {
            StartCoroutine(ActivateAfterSeconds(5.5f));
        }
    }
    IEnumerator ActivateAfterSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        targetObject.SetActive(true);
    }
}