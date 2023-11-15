using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyPlots : MonoBehaviour
{                                                                                                                                                                                                                                                                                                                                                                                                                                                          public GameObject plot1; public GameObject plot2; public GameObject plot3; public GameObject plot4; public GameObject plot5; public GameObject plot6; public GameObject plot7; public GameObject plot8; public GameObject plot9; public GameObject[] plots1; public GameObject[] plots2; public GameObject[] plots3; public GameObject[] plots4; public GameObject[] plots5; public GameObject[] plots6; public GameObject[] plots7; public GameObject[] plots8; public GameObject[] plots9;
    private bool plantable;
    private float geld;
    private int plotAmount;
    private float plotCost = 1;
    private int totalPlots = 9;
    
    void Start()
    {
        var current = this.gameObject;
        var all = current.GetComponents<GameObject>();
        Transform Farmfield1 = transform.Find("Farmfield 1");
       
        plantable = false;

        for (plotAmount = 0; plotAmount < totalPlots; plotAmount++)
        {
            plotCost = Mathf.Pow(plotAmount, 2f);


        }
    }
    
    
    void Update()
    {
        
    }
}
