using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aktivators : MonoBehaviour
{
    [SerializeField] private Transform _interactionPoint;
    [SerializeField] private float _interactionPointRadius = 0.5f;
    [SerializeField] private LayerMask _interactableMask;

    private readonly Collider[] _colliders = new Collider[3];
    [SerializeField] private int _numFound;

    private void Update()
    {
        _numFound = Physics.OverlapSphereNonAlloc(_interactionPoint.position, _interactionPointRadius, _colliders, (int)_interactableMask);

        if (Input.GetKeyDown(KeyCode.E))
        {
            InteractWithObject();
        }
    }

    private void InteractWithObject()
    {
        for (int i = 0; i < _numFound; i++)
        {
            Darbiba interactable = _colliders[i].GetComponent<Darbiba>();
            if (interactable != null)
            {
                interactable.Interact(this);
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
