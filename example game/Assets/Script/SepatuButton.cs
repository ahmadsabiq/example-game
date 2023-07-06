using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SepatuButton : MonoBehaviour
{
    public void checkShoes(){
        if (this.gameObject.tag == "falseShoes")
        {
            Debug.Log("Salah");
        }
        else
        {
            Debug.Log("Benar");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
