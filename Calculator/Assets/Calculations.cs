using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static DropDown;
using static DetectText;
using static DetectText2;
using static SetActiveScript;


public class Calculations : MonoBehaviour
{
    public GameObject calculationDisplay;

    public InputField eraseField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void doCalculations()
    {
        GameObject Calculation_Script = GameObject.Find("Calculation_Script");
        DropDown calculation_Script = Calculation_Script.GetComponent<DropDown>();
        int valArvo = calculation_Script.arvo;

        if (valArvo == 0)
        {
            doAdd();
        }
        if (valArvo == 1)
        {
            doSub();
        }
        if (valArvo == 2)
        {
            doMult();
        }
        if (valArvo == 3)
        {
            doDiv();
        }
    }

    public void doAdd()
    {
        GameObject InputField_firstNumber = GameObject.Find("InputField_firstNumber");
        DetectText inputField_firstNumber = InputField_firstNumber.GetComponent<DetectText>();
        int intNumber1 = inputField_firstNumber.theNumber;

        GameObject InputField_secondNumber = GameObject.Find("InputField_secondNumber");
        DetectText2 inputField_secondNumber = InputField_secondNumber.GetComponent<DetectText2>();
        int intNumber2 = inputField_secondNumber.theNumber;

        GameObject SetPanelActive_Script = GameObject.Find("SetPanelActive_Script");
        SetActiveScript setActiveScript = SetPanelActive_Script.GetComponent<SetActiveScript>();
        setActiveScript.activateme3 = true;

        decimal calNumber = intNumber1 + intNumber2;

        string number = calNumber.ToString();
        print("Calculation is " + number);
        calculationDisplay.GetComponent<Text>().text = number;

    }
    public void doSub()
    {
        GameObject InputField_firstNumber = GameObject.Find("InputField_firstNumber");
        DetectText inputField_firstNumber = InputField_firstNumber.GetComponent<DetectText>();
        decimal intNumber1 = inputField_firstNumber.theNumber;

        GameObject InputField_secondNumber = GameObject.Find("InputField_secondNumber");
        DetectText2 inputField_secondNumber = InputField_secondNumber.GetComponent<DetectText2>();
        decimal intNumber2 = inputField_secondNumber.theNumber;

        GameObject SetPanelActive_Script = GameObject.Find("SetPanelActive_Script");
        SetActiveScript setActiveScript = SetPanelActive_Script.GetComponent<SetActiveScript>();
        setActiveScript.activateme3 = true;

        decimal calNumber = intNumber1 - intNumber2;

        string number = calNumber.ToString();
        print("Calculation is " + number);
        calculationDisplay.GetComponent<Text>().text = number;

    }
    public void doMult()
    {
        GameObject InputField_firstNumber = GameObject.Find("InputField_firstNumber");
        DetectText inputField_firstNumber = InputField_firstNumber.GetComponent<DetectText>();
        decimal intNumber1 = inputField_firstNumber.theNumber;

        GameObject InputField_secondNumber = GameObject.Find("InputField_secondNumber");
        DetectText2 inputField_secondNumber = InputField_secondNumber.GetComponent<DetectText2>();
        decimal intNumber2 = inputField_secondNumber.theNumber;

        GameObject SetPanelActive_Script = GameObject.Find("SetPanelActive_Script");
        SetActiveScript setActiveScript = SetPanelActive_Script.GetComponent<SetActiveScript>();
        setActiveScript.activateme3 = true;

        decimal calNumber = intNumber1 * intNumber2;

        string number = calNumber.ToString();
        print("Calculation is " + number);
        calculationDisplay.GetComponent<Text>().text = number;

    }
    public void doDiv()
    {
        GameObject InputField_firstNumber = GameObject.Find("InputField_firstNumber");
        DetectText inputField_firstNumber = InputField_firstNumber.GetComponent<DetectText>();
        decimal intNumber1 = inputField_firstNumber.theNumber;

        GameObject InputField_secondNumber = GameObject.Find("InputField_secondNumber");
        DetectText2 inputField_secondNumber = InputField_secondNumber.GetComponent<DetectText2>();
        decimal intNumber2 = inputField_secondNumber.theNumber;

        GameObject SetPanelActive_Script = GameObject.Find("SetPanelActive_Script");
        SetActiveScript setActiveScript = SetPanelActive_Script.GetComponent<SetActiveScript>();
        setActiveScript.activateme3 = true;

        decimal calNumber = intNumber1 / intNumber2;

        string number = calNumber.ToString();
        print("Calculation is " + number);
        calculationDisplay.GetComponent<Text>().text = number;

    }
}
