using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashSoundScript : MonoBehaviour
{
    public GameObject myflashsound;
    public Flash flashscript;

    // Start is called before the first frame update
    void Start()
    {
        myflashsound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        flashsound();
    }

    void flashsound()
    {
        if (!flashscript.gameObject.activeSelf)
        {
            myflashsound.SetActive(true);
        }

    }
}