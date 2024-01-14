using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    [SerializeField] private Transform _interactionPoint;
    [SerializeField] private float _interactionPointRadius;
    [SerializeField] private LayerMask _interactableMask;

    private readonly Collider[] _colliders = new Collider[3];
    [SerializeField] private int _numFound;

    public Inventory inventory;

    private void Update()
    {
        _numFound = Physics.OverlapSphereNonAlloc(_interactionPoint.position, _interactionPointRadius, _colliders, (int)_interactableMask);

        //Ja objekti ir atrasti un ir piespests E taustins
        if (_numFound > 0 && Input.GetKeyDown(KeyCode.E))
        {
            InteractWithObject();
            pickupItem();
        }
    }

    private void InteractWithObject()
    {
        for (int i = 0; i < _numFound; i++)
        {
            var interactable = _colliders[i].GetComponent<IInteractable>();

            if (interactable != null)
            {
                interactable.Interact(this);
                break; 
            }
        }
    }
    public void pickupItem()
    {
        for (int i = 0; i < _numFound; i++)
        {
            var interactable = _colliders[i].GetComponent<IInventoryItem>();

            if (interactable != null)
            {

                IInventoryItem inventoryItem = interactable as IInventoryItem;

                if (inventoryItem != null)
                {

                    inventory.AddItem(inventoryItem);
                }

                break; 
            }
        }
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_interactionPoint.position, _interactionPointRadius);
    }
}
