using UnityEngine;

public class YaziDonme : MonoBehaviour
{
    
    void Update()
    {
        transform.RotateAround(transform.position, transform.up, Time.deltaTime * 40f);
    }
}
