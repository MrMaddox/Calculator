using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetErrorActive : MonoBehaviour
{

    public GameObject errorPanel;
    public bool activateme;

    void Update()
    {
        if (activateme == true)
        {
            errorPanel.SetActive(true);
        }
        else
        {
            errorPanel.SetActive(false);
        }
    }
    public void setOff()
    {
        activateme = false;

    }
}
