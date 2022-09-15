using UnityEngine;

public class YaziKapatma : MonoBehaviour
{
    public GameObject yazi;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            yazi.SetActive(false);
        }

    }
}