using UnityEngine;
using UnityEngine.SceneManagement;

public class FarmLevel : MonoBehaviour
{
    public GameObject bu;
    public GameObject message;

    private void Update()
    {
        if (bu.activeInHierarchy)
        {
            message.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
