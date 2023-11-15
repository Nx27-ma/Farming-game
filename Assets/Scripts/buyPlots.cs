using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class buyPlots : MonoBehaviour
{                                                                                                                                                                                                                                                                                                                                                                                                                                                          public GameObject plot1; public GameObject plot2; public GameObject plot3; public GameObject plot4; public GameObject plot5; public GameObject plot6; public GameObject plot7; public GameObject plot8; public GameObject plot9; public GameObject[] plots1; public GameObject[] plots2; public GameObject[] plots3; public GameObject[] plots4; public GameObject[] plots5; public GameObject[] plots6; public GameObject[] plots7; public GameObject[] plots8; public GameObject[] plots9;
    private bool plantable = false;
    private float geld;
    private GameObject[,] plotsCollection;
    public float Geld { get => geld; set => geld = value; }
    private int plotAmount;
    private float plotCost = 1;
    private int totalPlots = 9;

    

    void Start()
    {
        plotsCollection = new GameObject[9, 4];
        for (int i = 0; i <= 9; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                int correctie = i + 1;
                string objectName = "plots" + correctie;
                plotsCollection[i, j] = GameObject.Find(objectName);
                Debug.Log(plotsCollection);
            }
        }


    }
    
    
    void Update()
    {
        
    }
}
