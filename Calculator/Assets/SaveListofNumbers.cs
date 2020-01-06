using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static DetectText;

public class SaveListofNumbers : MonoBehaviour
{
    public GameObject InputField;

    public int[] list;

    private DetectText detectText;
    private DetectText textInField;

    void Awake()
    {
        detectText = InputField.GetComponent<DetectText>();
        textInField = InputField.GetComponent<DetectText>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        list = new int[detectText.listOfNumbers.Length];
        list = detectText.listOfNumbers;
    }
    public void submitList()
    {
        //string nam = GameObject.Find("InputField").GetComponent<UnityEngine.UI.InputField>().text;

        string arvo = detectText.arvoOn;

       //for (int i = 0; i < list.Length; i++)
       //{
       //print("Lista on tällä hetkellä: " + list[0]);
        print("testiaa" + arvo);
        //}
        

    }
}
