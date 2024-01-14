using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Money : MonoBehaviour, IInteractable, IInventoryItem
{

    [SerializeField] private string _promt;
    public string InteractionPromt => _promt;

    public string Name
    {
        get
        {
            return "Money";
        }
    }

    public Sprite _Image = null;

    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }

    public void OnPickUp()
    {
        gameObject.SetActive(false);
    }



    public bool Interact(Interactor interactor)
    {
        OnPickUp();
        return true;
    }
}
