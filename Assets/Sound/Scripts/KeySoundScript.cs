using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySoundScript : MonoBehaviour
{
    public GameObject mykeysound;
    public Key keyscript;

    // Start is called before the first frame update
    void Start()
    {
        mykeysound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        keysound();
    }

    void keysound()
    {
        if (!keyscript.gameObject.activeSelf)
        {
            mykeysound.SetActive(true);
        }

    }
}