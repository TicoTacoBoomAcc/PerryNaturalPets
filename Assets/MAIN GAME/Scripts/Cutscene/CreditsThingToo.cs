using System;
using System.Collections;
using UnityEngine;

public class CreditsThingToo : MonoBehaviour
{
    public GameObject VengeAnim;
    public GameObject EthanAnim;
    public GameObject EvieAnim;
    public GameObject HarrisonAnim;

    public GameObject LimeShark;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VengeAnim.SetActive(true);
        {
            StartCoroutine(ActivateAfterSeconds(20f));
        }

        EthanAnim.SetActive(false);
        {
            StartCoroutine(ActivateAfterSeconds(30f));
        }

        EvieAnim.SetActive(false);
        {
            StartCoroutine(ActivateAfterSeconds(40f));
        }

        HarrisonAnim.SetActive(false);
        {
            StartCoroutine(ActivateAfterSeconds(50f));
        }

        LimeShark.SetActive(false);
        {
            StartCoroutine(ActivateAfterSeconds(60f));
        }

    }

    IEnumerator ActivateAfterSeconds(float delay)
    {
        yield return new WaitForSeconds(delay);
        VengeAnim.SetActive(false);

        yield return new WaitForSeconds(delay);
        EthanAnim.SetActive(false);

        yield return new WaitForSeconds(delay);
        EvieAnim.SetActive(false);

        yield return new WaitForSeconds(delay);
        HarrisonAnim.SetActive(false);

        yield return new WaitForSeconds(delay);
        LimeShark.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}