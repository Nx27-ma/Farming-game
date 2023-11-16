using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Plot: MonoBehaviour
{

    public GameObject PlotObj;
    public Plots PlotScriptObj;
    public GameObject PlotGui;
    public TextMeshProUGUI PlotText;

    public GameObject FarmFieldObj;
    public GameObject FarmFieldGui;
    public TextMeshProUGUI FarmFieldText;

    private void OnMouseDown()
    {
        Debug.Log(PlotScriptObj.Gekocht);

        if (PlotScriptObj.Gekocht == false)
        {
            PlotText.text = PlotObj.name;
            PlotGui.SetActive(true);
            return;
        }else
        {
            PlotGui.SetActive(false);
        }

        if (PlotScriptObj.Gekocht == false)
        {
            PlotGui.SetActive(true);
            return;
        }


    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }
    }
}
