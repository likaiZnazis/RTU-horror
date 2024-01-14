using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    [SerializeField] private string _promt;
    private Animator _animator;
    private bool _isOpen = false;
    public string InteractionPromt => _promt;

   private void Start()
    {
        //Iegūst animācijas komponenti
        _animator = GetComponent<Animator>();
    }

    public bool Interact(Interactor interactor)
    {
        
        foreach (var item in interactor.inventory.mItems)
        {
            if (item.Name == "Key" && !_isOpen)
            {
                _animator.Play("Opening 1");
                _isOpen = true;
                return true;
            }
            else if(item.Name == "Key" && _isOpen)
            {
                _isOpen = false;
                _animator.Play("Closing 1");
                return true;
            }
            else
            {
                UnityEngine.Debug.Log("Nav atslegas");
            }

        }
        return false;
    }
}
