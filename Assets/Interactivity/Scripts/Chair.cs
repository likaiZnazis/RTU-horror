using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour, IInteractable
{
    [SerializeField] private string _promt;
    public string InteractionPromt => _promt;

    public bool Interact(Interactor interactor)
    {
        //Check if player has key/card/whatever, if has then return true;
        Debug.Log(message:"Apsēžas vienkārši");
        return true;
    }
}
