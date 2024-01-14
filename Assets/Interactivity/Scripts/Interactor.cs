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
                break; // Assuming you only want to interact with one object at a time
            }
        }
    }
    public void pickupItem()
    {
        for (int i = 0; i < _numFound; i++)
        {
            var interactable = _colliders[i].GetComponent<IInteractable>();
           

            if (interactable != null)
            {
                UnityEngine.Debug.Log("Item interacted: ");
                interactable.Interact(this);

                // Assuming the interactable object implements IInventoryItem
                IInventoryItem inventoryItem = interactable as IInventoryItem;

                if (inventoryItem != null)
                {
                    UnityEngine.Debug.Log("Item added to inventory: ");
                    inventory.AddItem(inventoryItem);
                }

                break; // Assuming you only want to interact with one object at a time
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_interactionPoint.position, _interactionPointRadius);
    }
}
