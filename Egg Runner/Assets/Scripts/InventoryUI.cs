using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI yumurtasayisiText;
    void Start()
    {
        yumurtasayisiText = GetComponent<TextMeshProUGUI>();
    }

    
    public void UpdateYumurtaSayisiText(PlayerInventory playerInventory)
    {
        yumurtasayisiText.text = playerInventory.NumberOfYumurtalar.ToString() + "/1238";
    }
}
