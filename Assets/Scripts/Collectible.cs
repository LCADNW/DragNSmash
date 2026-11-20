using System;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    public enum CollectibleType
    {
        Treasure,
        Trinket
    }
    [SerializeField] CollectibleType type;
    [SerializeField] int amount = 1;
    void Update()
    {
      
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Raise the event instead of directly calling the manager
            CollectibleEventSystem.RaiseCollectibleCollected(type,
           amount);
            Destroy(gameObject);
        }
    }
}


