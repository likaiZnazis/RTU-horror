using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WendingMachine : MonoBehaviour, IInteractable
{
    [SerializeField] private string _promt;
    public string InteractionPromt => _promt;

    public bool Interact(Interactor interactor)
    {
        //Check if player has money, if has then return true;
        Debug.Log(message:"Dabuj dzērienu");
        return true;
    }
}
