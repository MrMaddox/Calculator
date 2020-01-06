using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListForming : MonoBehaviour
{

    public GameObject panelOriginal;
    public GameObject panelContainer;

    void Start()
    {
        CreatePanels(3);
    }

    void Update()
    {
        
    }

    void CreatePanels(int panelNum)
    {
        for (int i = 0; i < panelNum; i++)
        {
            GameObject panelClone = Instantiate(panelOriginal, new Vector2(10, 10), panelOriginal.transform.rotation);
            panelClone.transform.parent = panelContainer.transform;
            panelClone.name = "PanelClone" + (i + 1);
        }
    }
}
