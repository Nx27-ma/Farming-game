using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plot: MonoBehaviour
{

    public GameObject PlotObj;
    public Plots PlotScriptObj;
    public GameObject PlotGui;
    public GameObject PlotText;

    public GameObject FarmFieldObj;
    public GameObject FarmFieldGui;
    public GameObject FarmFieldText;

    private void OnMouseDown()
    {
        if (PlotScriptObj.Gekocht == false)
        {
            PlotGui.SetActive(true);
            return;
        }

        PlotGui.SetActive(false);

        if (PlotScriptObj.Gekocht == false)
        {
            PlotGui.SetActive(true);
            return;
        }


    }
}
