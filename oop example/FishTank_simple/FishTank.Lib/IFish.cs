using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank.Lib
{
    public interface IFish
    {
        string Name { get; set; }
        //float Food();
        float Weight { get; }
    }

}
