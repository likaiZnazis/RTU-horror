using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WendingMachine : MonoBehaviour, Darbiba
{
    [SerializeField] private string _promt;
    public string InteractionPromt => _promt;

    public bool Interact(aktivators aktivators)
    {
        Debug.Log(message:"Sāk darbību");
        return true;
    }
}
