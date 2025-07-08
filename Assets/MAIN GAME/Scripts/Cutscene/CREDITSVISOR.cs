using System.Collections;
using UnityEngine;


public class CREDITSVISOR : MonoBehaviour
{
    public GameObject VengeAnim3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VengeAnim3.SetActive(false);
        {
            StartCoroutine(ActivateAfterSeconds(10f));
        }
    }
    IEnumerator ActivateAfterSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        VengeAnim3.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
