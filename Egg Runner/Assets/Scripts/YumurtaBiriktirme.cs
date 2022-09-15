using UnityEngine;

public class YumurtaBiriktirme : MonoBehaviour
{
    AudioSource coin;
    public float uyanDelay = 3f;

    private void Start()
    {
        coin = GameObject.FindGameObjectWithTag("Yol").GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();


        if (playerInventory != null)
        {
            playerInventory.YumurtaBirikti();
            coin.Play();
            gameObject.SetActive(false);
            Invoke("Uyan", uyanDelay);  
        }
    }
    void Uyan()
    {
        gameObject.SetActive(true);
    }
}