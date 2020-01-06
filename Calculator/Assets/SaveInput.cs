using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static SetActiveScript;
using static SetErrorActive;
using static DetectText;
using static DetectText2;

public class SaveInput : MonoBehaviour
{
    public GameObject panel;
    public GameObject numberDisplay;

    public InputField eraseField;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void submitNumber ()
    {
        GameObject InputField_firstNumber = GameObject.Find("InputField_firstNumber");
        DetectText inputField_firstNumber = InputField_firstNumber.GetComponent<DetectText>();
        int intNumber = inputField_firstNumber.theNumber;

        if (intNumber == -1)
        {
            GameObject SetErrorPanelActive_Script = GameObject.Find("SetErrorPanelActive_Script");
            SetErrorActive setErrorActive = SetErrorPanelActive_Script.GetComponent<SetErrorActive>();
            setErrorActive.activateme = true;
        }
        
        GameObject SetPanelActive_Script = GameObject.Find("SetPanelActive_Script");
        SetActiveScript setActiveScript = SetPanelActive_Script.GetComponent<SetActiveScript>();
        setActiveScript.activateme1 = true;

        string number = GameObject.Find("InputField_firstNumber").GetComponent<InputField>().text;
        print("Number is " + number);
        numberDisplay.GetComponent<Text>().text = number;

        eraseField.text = "";

    }
}
