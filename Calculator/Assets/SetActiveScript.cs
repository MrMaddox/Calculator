using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveScript : MonoBehaviour
{
    public GameObject myobject1;
    public bool activateme1;

    public GameObject myobject2;
    public bool activateme2;

    public GameObject myobject3;
    public bool activateme3;

    // Update is called once per frame
    void Update()
    {
        if (activateme1 == true)
        {
            myobject1.SetActive(true);
        }
        else
        {
            myobject1.SetActive(false);
        }

        if (activateme2 == true)
        {
            myobject2.SetActive(true);
        }
        else
        {
            myobject2.SetActive(false);
        }

        //tämä vaihdetaan toimimaan napin painalluksesta
        if (activateme3 == true)
        {
            myobject3.SetActive(true);
        }
        else
        {
            myobject3.SetActive(false);
        }
    }
}
