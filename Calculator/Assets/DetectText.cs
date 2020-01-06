using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DetectText : MonoBehaviour
{

    public int[] listOfNumbers;
    public string arvoOn;
    public int theNumber;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<InputField>().onEndEdit.AddListener(displayText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void displayText(string textInField)
    {
        saveText(textInField);
        print(textInField);
        arvoOn = textInField;
    }
    public void saveText(string textInField)
    {
        string number = textInField;
        theNumber = ConvertToInt(number);
        print("IntNumero on " + theNumber);
    }

    private int ConvertToInt(string number)
    {
        int x;
        int notNumber = -1;

            if (int.TryParse(number, out x))
            {
                int intNumber = x;
                return intNumber;
            }
            else
            {
                return notNumber;
            }
        
    }
}
