using UnityEngine;

public class Victory : MonoBehaviour
{

    AudioSource kale;
    public GameObject flag1;
    public GameObject flag2;


    void Start()
    {
        kale = GameObject.FindGameObjectWithTag("Kale").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            kale.enabled = true;
            flag1.SetActive(true);
            flag2.SetActive(true);
        }

    }

}
