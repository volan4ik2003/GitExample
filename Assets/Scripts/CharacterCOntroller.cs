using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterCOntroller : MonoBehaviour
{
    public event Action OnCharacterDied;

    public int Health { get; private set; }

    void Start()
    {
        Health = 100;
    }

    void Update()
    {
        if (Keyboard.current.enterKey.wasPressedThisFrame)
        {
            TakeDamage(20);
            Debug.Log(Health);
        }
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            OnCharacterDied?.Invoke();
        }
    }
}
