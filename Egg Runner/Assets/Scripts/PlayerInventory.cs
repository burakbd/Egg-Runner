using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
   public int NumberOfYumurtalar { get; private set; }

    public UnityEvent<PlayerInventory> OnYumurtaBirikti;

    public void YumurtaBirikti()
    {
        NumberOfYumurtalar++;
        OnYumurtaBirikti.Invoke(this);
    }
}
