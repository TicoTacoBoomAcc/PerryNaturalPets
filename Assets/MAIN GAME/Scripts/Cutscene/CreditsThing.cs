using System;
using System.Collections;
using UnityEngine;

public class CreditsThing : MonoBehaviour
{
    public GameObject VengeAnim;
    public GameObject EthanAnim;
    public GameObject EvieAnim;
    public GameObject HarrisonAnim;

    public GameObject LimeShark;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VengeAnim.SetActive(false);
        {
            StartCoroutine(ActivateAfterSeconds(10f));
        }

        EthanAnim.SetActive(false);
        {
            StartCoroutine(ActivateAfterSeconds(20f));
        }

        EvieAnim.SetActive(false);
        {
            StartCoroutine(ActivateAfterSeconds(30f));
        }

        HarrisonAnim.SetActive(false);
        {
            StartCoroutine(ActivateAfterSeconds(40f));
        }

        LimeShark.SetActive(false);
        {
            StartCoroutine(ActivateAfterSeconds(50f));
        }

    }

    IEnumerator ActivateAfterSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        VengeAnim.SetActive(true);

        yield return new WaitForSeconds(delay);
        EthanAnim.SetActive(true);

        yield return new WaitForSeconds(delay);
        EvieAnim.SetActive(true);

        yield return new WaitForSeconds(delay);
        HarrisonAnim.SetActive(true);

        yield return new WaitForSeconds(delay);
        LimeShark.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
