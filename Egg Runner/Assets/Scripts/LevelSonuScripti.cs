using System.Collections;
using UnityEngine;

public class LevelSonuScripti : MonoBehaviour
{
    private Playermove sc;
    private Animator anim;
    public GameManager gameManager;
    PlayerInventory playerInventory;
    AudioSource dance;
    AudioSource yurume;
    AudioSource main;
    public GameObject deniz;
    public GameObject buton1;
    public GameObject buton2;
    private void Start()
    {
        sc = GameObject.FindGameObjectWithTag("Player").GetComponent<Playermove>();
        anim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        yurume = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
        playerInventory = sc.gameObject.GetComponent<PlayerInventory>();
        dance = gameManager.GetComponent<AudioSource>();
        main = deniz.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            main.enabled = false;
            yurume.enabled = false;
            dance.enabled = true;
            sc.enabled = false;
            anim.SetBool("LevelSonu", true);
            StartCoroutine(PlayerMove());
        }

    }

    IEnumerator BasamakDiz()
    {
        for (int i = 0; i < playerInventory.NumberOfYumurtalar; i++)
        {
            if (i<1060)
            {
                gameManager.BasamakList[i].SetActive(true);
            }

            yield return new WaitForSeconds(0f);
            

        }
    }

    IEnumerator PlayerMove()
    {
        yield return new WaitForSeconds(2f);
        sc.FinishMove();
        yield return new WaitForSeconds(2f);

        StartCoroutine(BasamakDiz());
        buton1.SetActive(true);
        buton2.SetActive(true);
    }

}
