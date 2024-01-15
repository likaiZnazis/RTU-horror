using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanSoundScript : MonoBehaviour
{
    public GameObject mycansound;
    public Can canscript;

    // Start is called before the first frame update
    void Start()
    {
        mycansound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        cansound();
    }

    void cansound()
    {
        if (!canscript.gameObject.activeSelf)
        {
            mycansound.SetActive(true);
        }

    }
}