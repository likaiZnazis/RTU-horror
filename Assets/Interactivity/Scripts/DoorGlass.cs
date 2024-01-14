using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorGlass : MonoBehaviour, IInteractable
{
    // [SerializeField] private string _promt;
    // public string InteractionPromt => _promt;

    // public bool Interact(Interactor interactor)
    // {
    //     //Check if player has key/card/whatever, if has then return true;
    //     Debug.Log(message:"Atver lielās durvis");
    //     return true;
    // }

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
            _animator.Play("Opening");

            Debug.Log(message:"Atver lielās durvis");
        }else{
			_animator.Play("Closing 1");
            _animator.Play("Closing");

            Debug.Log(message:"Aizver lielās durvis");
        }

        return true;
    }   
}