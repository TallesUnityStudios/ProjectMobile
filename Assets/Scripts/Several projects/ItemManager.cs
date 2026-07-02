using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public static ItemManager Instance;
    public int Coins;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        Reset();
    }

    private void Reset()
    {
        Coins = 0;
    }

    public void AddCoin(int amount = 1)
    {
        Coins += amount;
    }
}
