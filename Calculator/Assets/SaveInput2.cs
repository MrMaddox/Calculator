using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static SetActiveScript;
using static DetectText2;

public class SaveInput2 : MonoBehaviour
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

    public void submitNumber()
    {
        GameObject InputField_secondNumber = GameObject.Find("InputField_secondNumber");
        DetectText2 inputField_secondNumber = InputField_secondNumber.GetComponent<DetectText2>();
        int intNumber = inputField_secondNumber.theNumber;

        if (intNumber == -1)
        {
            GameObject SetErrorPanelActive_Script = GameObject.Find("SetErrorPanelActive_Script");
            SetErrorActive setErrorActive = SetErrorPanelActive_Script.GetComponent<SetErrorActive>();
            setErrorActive.activateme = true;
        }

        GameObject SetPanelActive_Script = GameObject.Find("SetPanelActive_Script");
        SetActiveScript setActiveScript = SetPanelActive_Script.GetComponent<SetActiveScript>();
        setActiveScript.activateme2 = true;

        string number = GameObject.Find("InputField_secondNumber").GetComponent<InputField>().text;
        print("Number is " + number);
        numberDisplay.GetComponent<Text>().text = number;

        eraseField.text = "";

    }
}