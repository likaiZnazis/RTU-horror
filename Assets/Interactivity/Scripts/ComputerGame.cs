using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComputerGame : MonoBehaviour, IInteractable
{
    [SerializeField] private string _promt;
    [SerializeField] private string _sceneToLoad;
    [SerializeField] private string _sceneToUNLoad;

    public string InteractionPromt => _promt;
    private bool start = false;
    private bool pressq = false;
    private void Start()
    {


    }

    public bool Interact(Interactor interactor)
    {
        start = true;
        // SceneManager.LoadSceneAsync(_sceneToLoad);
        // SceneManager.UnloadSceneAsync(_sceneToUNLoad);

        Debug.Log("Sāk spēli");

        return true;
    }

    private void Update()
    {

        //     pressq = Input.GetKeyDown(KeyCode.Q);

        //     if (Input.anyKeyDown);
        //     {
        //         Debug.Log("beidz speeli");
        //         Debug.Log(Input.GetKeyDown(KeyCode.Q));
        // // SceneManager.LoadSceneAsync(_sceneToUNLoad);
        // // SceneManager.UnloadSceneAsync(_sceneToLoad);
        //     }
    }
}
