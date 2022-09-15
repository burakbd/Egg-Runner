using UnityEngine;

public class TilkiDamage : MonoBehaviour
{
    AudioSource pismeSesi;
    AudioSource vahvah;
    public GameObject ground;
    public GameObject sokakLambasi;
    AudioSource main;
    public GameObject deniz;
    private void Start()
    {
        pismeSesi = GameObject.FindGameObjectWithTag("Ground").GetComponent<AudioSource>();
        vahvah = GameObject.FindGameObjectWithTag("SesDosyasiVar").GetComponent<AudioSource>();
        main = deniz.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            main.enabled = false;
            vahvah.enabled = true;
            pismeSesi.enabled = true;
            Destroy(other.gameObject);
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
