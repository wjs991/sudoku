using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class btn_manager : Base_core
{
    private btn_element[] btn = new btn_element[81];

    public btn_element[] Btn_element
    {
        get
        {
            return this.btn;
        }
    }


    protected override void init()
    {
        base.init();
        for(int i=0;i<81;i++)
        {
            Btn_element[i] = this.transform.GetChild(i).GetComponent<btn_element>();
            Debug.Log("init : "+ Btn_element[i]);
        }
    }

    protected override void set_number(int number)
    {
        base.set_number(number);
        for(int i=0;i<81;i++)
        {
            Btn_element[i].Number = number;
        }
    }

    public void set_number(int index, int number)
    {
        btn[index].Number = number;
    }

    protected override void show()
    {
        base.show();
        for(int i=0;i<81;i++)
        {
            Btn_element[i].show_number_btn();
        }
    }

    public void set_show()
    {
        show();
    }

}
