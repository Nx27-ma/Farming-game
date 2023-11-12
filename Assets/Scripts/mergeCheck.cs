using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mergeCheck : MonoBehaviour
{
    public cropBehavior farmland1;
    public cropBehavior farmland2;
    public cropBehavior farmland3;
    public cropBehavior farmland4;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (farmland1.WhatSeed == farmland2.WhatSeed && farmland1.ImgIndex == farmland2.ImgIndex)
        {
            //display dat het mergable is
            if(farmland1.ImgIndex == 2)
            {
                farmland2.ImgIndex = 3;
            }
            if(farmland1.ImgIndex == 4)
            {
                //drop de crop farmland2 dropt
            }
            farmland1.WhatSeed = 0;
        }
        if (farmland2.WhatSeed == farmland3.WhatSeed && farmland2.ImgIndex == farmland3.ImgIndex)
        {
            //display dat het mergable is
            if (farmland2.ImgIndex == 2)
            {
                farmland3.ImgIndex = 3;
            }
            if (farmland2.ImgIndex == 4)
            {
                //drop de crop farmland3 dropt
            }
            farmland2.WhatSeed = 0;

        }
        if (farmland3.WhatSeed == farmland4.WhatSeed && farmland3.ImgIndex == farmland4.ImgIndex)
        {
            //display dat het mergable is
            if (farmland3.ImgIndex == 2)
            {
                farmland4.ImgIndex = 3;
            }
            if (farmland3.ImgIndex == 4)
            {
                //drop de crop farmland4 dropt
            }
            farmland3.WhatSeed = 0;
        }
        if (farmland4.WhatSeed == farmland1.WhatSeed && farmland4.ImgIndex == farmland1.ImgIndex)
        {
            //display dat het mergable is
            if (farmland4.ImgIndex == 2)
            {
                farmland1.ImgIndex = 3;
            }
            if (farmland4.ImgIndex == 4)
            {
                //drop de crop farmland1 dropt
            }
            farmland4.WhatSeed = 0;

        }
    }
}
