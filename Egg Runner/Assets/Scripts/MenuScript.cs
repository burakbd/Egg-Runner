using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public GameObject chicken;
    public GameObject start;
    public GameObject exit;
    public GameObject credits;
    public GameObject eggs;
    public GameObject creditsPanel;
    public void Baslat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Kapat()
    {
        Application.Quit();
    }

    public void Credit()
    {
        chicken.SetActive(false);
        start.SetActive(false);
        exit.SetActive(false);
        credits.SetActive(false);
        eggs.SetActive(false);
        creditsPanel.SetActive(true);
    }

    public void MainMenu()
    {
        chicken.SetActive(true);
        start.SetActive(true);
        exit.SetActive(true);
        credits.SetActive(true);
        eggs.SetActive(true);
        creditsPanel.SetActive(false);
    }
}
