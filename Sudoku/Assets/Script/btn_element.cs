using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btn_element : MonoBehaviour
{
   private int number;
   public int Number{
       get{
           return number;
       }
       set{
           number = value;
       }
   }

   public void show_number_btn()
   {
       this.transform.GetChild(0).GetComponent<Text>().text = Number.ToString();
   }
}
