using System.Collections;
using UnityEngine;

public class CREDITSVENGE : MonoBehaviour
{
    public GameObject VengeAnim2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VengeAnim2.SetActive(false);
        {
            StartCoroutine(ActivateAfterSeconds(10f));
        }
    }

    IEnumerator ActivateAfterSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        VengeAnim2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
