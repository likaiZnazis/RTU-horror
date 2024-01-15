using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    [SerializeField] private string _promt;
    private Animator _animator;
    private bool _isOpen = false;

    [SerializeField] private AudioSource doorOpenAudioSource;
    [SerializeField] private float openDelay = 0;
    [Space(10)]
    [SerializeField] private AudioSource doorCloseAudioSource;
    [SerializeField] private float closeDelay = 0.8f;
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
        if (_isOpen)
        {
            _animator.Play("Opening 1");
            Debug.Log("Atver mazās durvis");
            doorOpenAudioSource.PlayDelayed(openDelay);
        }
        else
        {
            _animator.Play("Closing 1");
            Debug.Log("Aizver mazās durvis");
            doorCloseAudioSource.PlayDelayed(closeDelay);
        }

        return true;
    }
}
