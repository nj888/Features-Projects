using System;

namespace FishTank.Lib
{
    
    public class BabelFish : IFish
    {
        private float _weight;
        public BabelFish()
        {
            _weight = 0.3f;
        }
        public BabelFish(float weight)
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
