using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonanda : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void set_number()
    {
        sGameManager.Get.set_sudoku_element_value(3,5); // 숫자 셋팅
        sGameManager.Get.set_sudoku_element_value(80,9);
        sGameManager.Get.set_sudoku_element_value(0,7);
        sGameManager.Get.show_sudoku();
    }
}
