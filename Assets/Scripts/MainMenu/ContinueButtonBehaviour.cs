using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButtonBehaviour : MonoBehaviour
{
    private bool ValidSavedGame = false;
    public Button ContinueButton;
    // Start is called before the first frame update
    void Start()
    {
        ContinueButton = GetComponent<Button>();
        ContinueButton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        set_interaction();
    }

    private void set_interaction()
    {
        if (ValidSavedGame)
        {
            ContinueButton.interactable = true;
        }
        else
        {
            ContinueButton.interactable = false;
        }
    }

}
