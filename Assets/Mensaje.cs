using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Mensaje : MonoBehaviour
{

    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void btn_Click()
    {
        int i = num2;

        if (num1 == num2 || num1 > num2)
        {
            Debug.Log("Error");
        }


        else
        {
            while (i > num1 && i <= num2)
            {
                Debug.Log(i);
                i -= 1;
            }
        }
    }

}
