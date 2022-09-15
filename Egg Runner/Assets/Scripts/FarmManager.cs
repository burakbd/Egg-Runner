using System.Collections;
using UnityEngine;

public class FarmManager : MonoBehaviour
{
    public GameObject player;
    public GameObject homeSweetHome;
    public GameObject exit;
    public Camera cam1;
    public Camera cam2;
    AudioSource tanitim;
    AudioSource farm;

  
    void Start()
    {   
        tanitim = GameObject.FindGameObjectWithTag("Tanitim").GetComponent<AudioSource>();
        farm = GameObject.FindGameObjectWithTag("FarmLife").GetComponent<AudioSource>();
        StartCoroutine(Tanitim());
    }

    private void Update()
    {
        if (player.activeInHierarchy)
        {
            farm.enabled = true;
        }
    }

    IEnumerator Tanitim()
    {
        tanitim.enabled = true;
        yield return new WaitForSeconds(10f);
        tanitim.enabled = false;
        cam1.enabled = false;
        cam2.enabled = true;
        homeSweetHome.SetActive(false);
        exit.SetActive(true);
        player.SetActive(true);
    }
}
