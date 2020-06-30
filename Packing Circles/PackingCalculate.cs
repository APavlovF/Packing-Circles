using System;

namespace Packing_Circles
{
    class PackingCalculate : Packing
    {
       
        public PackingCalculate(float size, float space, int qty) : base(size, space, qty) { }

        public int CalculateSheet(float x, float y, float width, float height, string packType)
        {
            int layerCount = 1;
            nextY = y + space;
            circleCount = 0;

            while (Math.Round(nextY, 2) <= Math.Round(y + height - size - space, 2))
            {
                nextX = GetNextX(packType, x, layerCount);
                while (Math.Round(nextX, 2) <= Math.Round(x + width - size - space, 2))
                {                                     
                    circleCount += 1;
                    nextX += size + space;
                }
                nextY += GetNextY(packType);
                layerCount += 1;
            }
            return circleCount;
        }
    }
}
