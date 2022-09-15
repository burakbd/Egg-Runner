using UnityEngine;

public class StartC : MonoBehaviour
{
    private Playermove move;
    private Animator anim;
    AudioSource main;
    public GameObject deniz;
    public GameObject buton1;
    public GameObject buton2;


    private void Start()
    {
        move = GameObject.FindGameObjectWithTag("Player").GetComponent<Playermove>();
        anim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        main = deniz.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            main.enabled = true;
            anim.SetBool("LevelSonu", false);
            move.enabled = true;
            buton1.SetActive(false);
            buton2.SetActive(false);
        }

    }
}
