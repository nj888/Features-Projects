using System;
using System.Collections.Generic;
using System.Text;

namespace FishTank.Lib
{
    public class GoldFish : IFish
    {
        private float _weight;
        /// <summary>
        /// 
        /// </summary>
        public GoldFish()
        {
            _weight = 0.1f;
        }

        public GoldFish(float weight)
        {
            _weight = weight;
        }

        public string Name { get; set; }

        public float Weight => _weight;

        public float Food()
        {
            return _weight;
        }
    }

}
