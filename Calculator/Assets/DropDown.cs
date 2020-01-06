using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{
    public GameObject selectionPanel;

    public int arvo;


    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            arvo = 0;
        }
        if (val == 1)
        {
            arvo = 1;
        }
        if (val == 2)
        {
            arvo = 2;
        }
        if (val == 3)
        {
            arvo = 3;
        }
    }
}
