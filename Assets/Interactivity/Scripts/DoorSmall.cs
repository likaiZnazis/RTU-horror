using System.Collections;
using System.Collections.Generic;
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
        _isOpen = !_isOpen;

        //Check if player has key/card/whatever, if has then return true;
        if(_isOpen){
            _animator.Play("Opening 1");
            Debug.Log(message:"Atver mazās durvis");
        }else{
			_animator.Play("Closing 1");
            Debug.Log(message:"Aizver mazās durvis");
        }

        // Debug.Log(message:"Atver mazās durvis");
        return true;
    }
}
