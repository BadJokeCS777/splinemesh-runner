using System;
using UnityEngine;

public class Wallet : MonoBehaviour
{
    public int Money { get; private set; }
    
    public event Action MoneyChanged;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Coin coin) == false)
            return;
        
        coin.PickUp();
        AddMoney();
    }

    private void AddMoney()
    {
        Money++;
        MoneyChanged?.Invoke();
    }
}