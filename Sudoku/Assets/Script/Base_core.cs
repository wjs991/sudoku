using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_core : MonoBehaviour
{
    // Start is called before the first frame update
    protected virtual void init()
    {
        Debug.Log("init");
    }

    protected virtual void set_number(int number)
    {
        Debug.Log("set_number");
    }
    
    void Awake()
    {
        init();
        set_number(0);
    }

    protected virtual void show()
    {
        Debug.Log("show_");
    }

}
