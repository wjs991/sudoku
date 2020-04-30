using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sGameManager : MonoBehaviour
{
    // Start is called before the first frame update


    private static sGameManager _get = null;
    public static sGameManager Get
    {
        get{
            if(_get==null)
            {
                _get = new sGameManager();
            }

            return _get;
            
        }
    }
    public btn_manager _Btn_Manager;
    public btn_manager manager_btn
    {
        get{
            _Btn_Manager = GameObject.Find("grid").GetComponent<btn_manager>();
            return  _Btn_Manager;
        }
    }

    public void show_sudoku()
    {
        manager_btn.set_show();
    }

    public void set_sudoku_element_value(int index,int number)
    {
        Debug.Log(manager_btn);
        manager_btn.set_number(index,number);
    }

}
