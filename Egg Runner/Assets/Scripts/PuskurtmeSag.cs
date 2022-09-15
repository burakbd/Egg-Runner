using System.Collections;
using UnityEngine;

public class PuskurtmeSag : MonoBehaviour
{
    public GameObject fireObject;
    public GameObject fireVariantUc;
    public GameObject fireVariantDort;
    public GameObject fireVariantAlti;
    public GameObject fireVariantYedi;
    public GameObject fireVariantOn;
    public GameObject fireVariantOnbir;
    public GameObject fireVariantOniki;
    public GameObject fireVariantOnuc;
    public GameObject fireVariantOndort;

    void Start()
    {
        StartCoroutine(FireSequence());
        StartCoroutine(VariantUcSequence());
        StartCoroutine(VariantDortSequence());
        StartCoroutine(VariantAltiSequence());
        StartCoroutine(VariantYediSequence());
        StartCoroutine(VariantOnSequence());
        StartCoroutine(VariantOnbirSequence());
        StartCoroutine(VariantOnikiSequence());
        StartCoroutine(VariantOnucSequence());
        StartCoroutine(VariantOndortSequence());
    }



    IEnumerator FireSequence()
    {
        while (true)
        {
            int wait_time = Random.Range(2, 4);
            yield return new WaitForSeconds(wait_time);
            fireObject.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireObject.SetActive(false);
            yield return new WaitForSeconds(1);
            fireObject.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireObject.SetActive(false);
            yield return new WaitForSeconds(1);
        }


    }

    IEnumerator VariantUcSequence()
    {
        while (true)
        {
            int wait_time = Random.Range(2, 4);
            yield return new WaitForSeconds(wait_time);
            fireVariantUc.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireVariantUc.SetActive(false);
            yield return new WaitForSeconds(1);
            fireVariantUc.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireVariantUc.SetActive(false);
            yield return new WaitForSeconds(1);
        }


    }

    IEnumerator VariantDortSequence()
    {
        while (true)
        {
            int wait_time = Random.Range(2, 4);
            yield return new WaitForSeconds(wait_time);
            fireVariantDort.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireVariantDort.SetActive(false);
            yield return new WaitForSeconds(1);
            fireVariantDort.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireVariantDort.SetActive(false);
            yield return new WaitForSeconds(1);
        }


    }

    IEnumerator VariantAltiSequence()
    {
        while (true)
        {
            int wait_time = Random.Range(2, 4);
            yield return new WaitForSeconds(wait_time);
            fireVariantAlti.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireVariantAlti.SetActive(false);
            yield return new WaitForSeconds(1);
            fireVariantAlti.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireVariantAlti.SetActive(false);
            yield return new WaitForSeconds(1);
        }


    }

    IEnumerator VariantYediSequence()
    {
        while (true)
        {
            int wait_time = Random.Range(2, 4);
            yield return new WaitForSeconds(wait_time);
            fireVariantYedi.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireVariantYedi.SetActive(false);
            yield return new WaitForSeconds(1);
            fireVariantYedi.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireVariantYedi.SetActive(false);
            yield return new WaitForSeconds(1);
        }


    }

    IEnumerator VariantOnSequence()
    {
        while (true)
        {
            int wait_time = Random.Range(2, 4);
            yield return new WaitForSeconds(wait_time);
            fireVariantOn.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireVariantOn.SetActive(false);
            yield return new WaitForSeconds(1);
            fireVariantOn.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireVariantOn.SetActive(false);
            yield return new WaitForSeconds(1);
        }


    }

    IEnumerator VariantOnbirSequence()
    {
        while (true)
        {
            int wait_time = Random.Range(2, 4);
            yield return new WaitForSeconds(wait_time);
            fireVariantOnbir.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireVariantOnbir.SetActive(false);
            yield return new WaitForSeconds(1);
            fireVariantOnbir.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireVariantOnbir.SetActive(false);
            yield return new WaitForSeconds(1);
        }


    }

    IEnumerator VariantOnikiSequence()
    {
        while (true)
        {
            int wait_time = Random.Range(2, 4);
            yield return new WaitForSeconds(wait_time);
            fireVariantOniki.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireVariantOniki.SetActive(false);
            yield return new WaitForSeconds(1);
            fireVariantOniki.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireVariantOniki.SetActive(false);
            yield return new WaitForSeconds(1);
        }


    }

    IEnumerator VariantOnucSequence()
    {
        while (true)
        {
            int wait_time = Random.Range(2, 4);
            yield return new WaitForSeconds(wait_time);
            fireVariantOnuc.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireVariantOnuc.SetActive(false);
            yield return new WaitForSeconds(1);
            fireVariantOnuc.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireVariantOnuc.SetActive(false);
            yield return new WaitForSeconds(1);
        }


    }

    IEnumerator VariantOndortSequence()
    {
        while (true)
        {
            int wait_time = Random.Range(2, 4);
            yield return new WaitForSeconds(wait_time);
            fireVariantOndort.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireVariantOndort.SetActive(false);
            yield return new WaitForSeconds(1);
            fireVariantOndort.SetActive(true);
            yield return new WaitForSeconds(wait_time);
            fireVariantOndort.SetActive(false);
            yield return new WaitForSeconds(1);
        }


    }





}
