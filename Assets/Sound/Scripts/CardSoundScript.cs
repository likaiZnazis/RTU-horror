using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSoundScript : MonoBehaviour
{
    public GameObject mycardsound;
    public Keycard cardscript;

    // Start is called before the first frame update
    void Start()
    {
        mycardsound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        cardsound();
    }

    void cardsound()
    {
        if (!cardscript.gameObject.activeSelf)
        {
            mycardsound.SetActive(true);
        }

    }
}