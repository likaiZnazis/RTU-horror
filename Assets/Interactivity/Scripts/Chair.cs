using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour, IInteractable
{
    [SerializeField] private string _promt;
    public string InteractionPromt => _promt;
    private Vector3 originalCameraPosition;
    private GameObject playerCamera;
    private Vector3 originalplayerBodyPosition;
    private Vector3 chairpos;
    private GameObject playerBody;

    private bool sitdown = false;
    private void Start()
    {
        //Atrod kameru ar Player tag
        playerCamera = GameObject.FindGameObjectWithTag("PlayerCamera");
        playerBody = GameObject.FindGameObjectWithTag("PlayerBody");

    }

    public bool Interact(Interactor interactor)
    {
    
        //Saglabā kameras un spēlētāja pozīciju pirms apsēšanās
        originalCameraPosition = playerCamera.transform.position;
        // originalplayerBodyPosition = playerBody.transform.position;
        // chairpos = transform.position;

        // Debug.Log(chairpos);
        // Debug.Log(originalplayerBodyPosition);

        // Rotē spēlētāju(kameru) tāpat kā sarotēts krēsls
        interactor.transform.rotation = Quaternion.LookRotation(transform.forward, Vector3.up);
        // playerBody.transform.rotation = Quaternion.LookRotation(transform.forward, Vector3.up);

        // Pazemināt kameru, kad ir apsēdies
        playerCamera.transform.position = new Vector3(playerCamera.transform.position.x, transform.position.y + 0.5f, playerCamera.transform.position.z);

        //Spēlētāja ķermeni pārvieto uz krēsla
        // playerBody.transform.position = chairpos;

        Debug.Log("Apsēžas vienkārši");
        
        sitdown = true;
        return true;
    }

    private void Update()
    {

        if (sitdown)
        {
            // Ja piespiež jebkuru taustiņu, tad pieceļas, jeb kamera uz augšu
            if (Input.anyKeyDown)
            {
                // Attiestata kamera pozīciju
                playerCamera.transform.position = originalCameraPosition;
                //Attiestats spēlētāja pozīciju
                // playerBody.transform.position = originalplayerBodyPosition;
                Debug.Log("Pieceļas");
                sitdown = false;
            }
        }
    }
}
