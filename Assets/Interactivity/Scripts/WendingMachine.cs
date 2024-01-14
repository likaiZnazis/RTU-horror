using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;

public class WendingMachine : MonoBehaviour, IInteractable
{
    [SerializeField] private string _promt;
    public string InteractionPromt => _promt;

    private int costOfItem = 10; // Replace with the actual cost of the item
    new public string name = "Cola";
    public Sprite _Image = null;


    public bool Interact(Interactor interactor)
    {
        // Check if the player has the Money item in their inventory
        foreach (var item in interactor.inventory.mItems)
        {
            if(item.Name == "Money")
            {
                interactor.inventory.RemoveItem(item);
                IInventoryItem colaItem = new Item(_Image, name);
                interactor.inventory.AddItem(colaItem);
                costOfItem = costOfItem - 1;
                UnityEngine.Debug.Log("Dabuj dzērienu");
                return true;
            }
            
        }
        return false;
    }
}