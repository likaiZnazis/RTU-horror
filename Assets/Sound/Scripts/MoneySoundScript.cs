using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySoundScript : MonoBehaviour
{
    public GameObject mymoneysound;
    public Money moneyscript;

    // Start is called before the first frame update
    void Start()
    {
        mymoneysound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        moneysound();
    }

    void moneysound()
    {
        if (!moneyscript.gameObject.activeSelf)
        {
            mymoneysound.SetActive(true);
        }
        
    }
}