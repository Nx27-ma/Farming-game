using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class cropBehavior : MonoBehaviour
{
    //needed for script 
    public int WhatSeed { get { return whatSeed; } set { whatSeed = value; } } //start bij 0 anders vermoord quinten me
    private int whatSeed;
    private int imgIndex = 1;       //start niet bij 0 want quinten gaat het nooit nodig hebben
    public int ImgIndex { get { return imgIndex; } set { imgIndex = value; } }
    public float growthSpeed { get; set; } //int between 0 and 1
    static float timeToGrow = 30;
    private float totalTime() { return timeToGrow * growthSpeed; }
    private Renderer rd;
                                                                                                                                                                                                                                                                                                                                                                    public Texture emptyPlot;    public Texture greenSomething1; public Texture greenSomething2; public Texture greenSomething3; public Texture greenSomething4;    public Texture grass1; public Texture grass2; public Texture grass3; public Texture grass4;    public Texture wheat1; public Texture wheat2; public Texture wheat3; public Texture wheat4;    public Texture carrot1; public Texture carrot2; public Texture carrot3; public Texture carrot4;    public Texture potato1; public Texture potato2; public Texture potato3; public Texture potato4;    public Texture tomato1; public Texture tomato2; public Texture tomato3; public Texture tomato4;    public Texture berries1; public Texture berries2; public Texture berries3; public Texture berries4;    public Texture melon1; public Texture melon2; public Texture melon3; public Texture melon4;    public Texture pumpkin1; public Texture pumpkin2; public Texture pumpkin3; public Texture pumpkin4;    public Texture beetroot1; public Texture beetroot2; public Texture beetroot3; public Texture beetroot4;    public Texture cabbage1; public Texture cabbage2; public Texture cabbage3; public Texture cabbage4;    public Texture spinach1; public Texture spinach2; public Texture spinach3; public Texture spinach4;
    void Start()
    {
        rd = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (whatSeed != 0)
        {
            float tickingtime = totalTime();
            while (tickingtime > 0 && imgIndex == 1 || imgIndex == 3)
            {
                tickingtime = totalTime() - Time.deltaTime;
            }
            if (tickingtime <= 0)
            {
                imgIndex++;
                plantCheck(whatSeed, imgIndex);

            }
        }
        else
        {
            plantCheck(0, imgIndex);
        }
    }
    
    void plantCheck(int planted, int imgIndex)
    {
        switch (planted)
        {
            case 0:
                rd.material.mainTexture = emptyPlot;
                break;
            case 1:
                cropGrowth(greenSomething1, greenSomething2, greenSomething3, greenSomething4, imgIndex);
                break;
            case 2:
                cropGrowth(grass1, grass2, grass3, grass4, imgIndex);
                break;
            case 3:
                cropGrowth(wheat1, wheat2, wheat3, wheat4, imgIndex);
                break;
            case 4:
                cropGrowth(carrot1, carrot2, carrot3, carrot4, imgIndex);
                break;
            case 5:
                cropGrowth(potato1, potato2, potato3, potato4, imgIndex);
                break;
            case 6:
                cropGrowth(tomato1, tomato2, tomato3, tomato4, imgIndex);
                break;
            case 7:
                cropGrowth(berries1, berries2, berries3, berries4, imgIndex);
                break;
            case 8:
                cropGrowth(melon1, melon2, melon3, melon4, imgIndex);
                break;
            case 9:
                cropGrowth(pumpkin1, pumpkin2, pumpkin3, pumpkin4, imgIndex);
                break;
            case 10:
                cropGrowth(beetroot1, beetroot2, beetroot3, beetroot4, imgIndex);
                break;
            case 11:
                cropGrowth(cabbage1, cabbage2, cabbage3, cabbage4, imgIndex);
                break;
            case 12:
                cropGrowth(spinach1, spinach2, spinach3, spinach4, imgIndex);
                break;
            default:
                //default plot
                break;
        }
    }

    void cropGrowth(Texture plant1, Texture plant2, Texture plant3, Texture plant4, int imgIndex)
    {
        if (imgIndex == 1)
        {
            rd.material.mainTexture = plant1;
        }
        else if (imgIndex == 2)
        {
            rd.material.mainTexture = plant2;
        } else if (imgIndex == 3) 
        {
           rd.material.mainTexture = plant3;
        } else if (imgIndex == 4)
        {
            rd.material.mainTexture = plant4;
        }






    }

}
