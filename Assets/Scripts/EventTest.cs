using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class EventTest : MonoBehaviour
{
    public int Coins { get; private set; }

    public event Action<int, string> OnCoinsChanged;

    public void AddCoins()
    {
        Coins++;

        OnCoinsChanged?.Invoke(Coins, "Money");
    }



}
