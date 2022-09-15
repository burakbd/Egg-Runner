using UnityEngine;

public class DokunBasaGec : MonoBehaviour
{
    private Playermove sc;


    private void Start()
    {
        sc = GameObject.FindGameObjectWithTag("Player").GetComponent<Playermove>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sc.RestartMove();
        }

    }

}
