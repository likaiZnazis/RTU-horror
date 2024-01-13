using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    bool hasKey = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        //Test, piespiežot K, būs atslēga
        if(Input.GetKeyDown(KeyCode.K)){
            hasKey = !hasKey;
        }
    }
}
