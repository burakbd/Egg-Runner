using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Transform cam;
    public GameObject yazi;
    SwipeManager Swp;
    public GameObject exit;
    bool gameHasEnded = false;
    public float restartDelay = 4f;
    public GameObject roastedText;
    public GameObject pismisCanvas;
    public GameObject fireObjeleri;
    public GameObject kalanYumurtalar;
    public GameObject[] BasamakList;
    private PlayerSecondMove Psc;
    private Animator anim;
    AudioSource yurume;
    public GameObject tilkiler;
    Transform player;


    public static object Instance { get; internal set; }

    private void Start()
    {
        Application.targetFrameRate = 60;
        yazi.SetActive(true);
        exit.SetActive(true);
        Psc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerSecondMove>();
        anim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
        yurume = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
        Swp = GameObject.FindGameObjectWithTag("Player").GetComponent<SwipeManager>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        cam = GameObject.FindGameObjectWithTag("SanalCam").GetComponent<Transform>();
    }

    private void Update()
    {
        Application.targetFrameRate = 60;
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            roastedText.SetActive(true);
            pismisCanvas.SetActive(true);
            fireObjeleri.SetActive(false);
            kalanYumurtalar.SetActive(false);
            tilkiler.SetActive(false);
            player.transform.position = new Vector3(0, transform.position.y, transform.position.z);
            cam.transform.position = new Vector3(0, transform.position.y, transform.position.z);
            Invoke("Restart", restartDelay);
            Application.targetFrameRate = 60;
        }
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Merdiven()
    {
        Swp.enabled = false;
        yurume.enabled = true;
        Psc.enabled = true;
        anim.SetBool("LevelSonu", false);
    }

}
