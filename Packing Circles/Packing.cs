using System;
using System.Collections.Generic;
using System.Drawing;

namespace Packing_Circles
{
    class Packing
    {
        protected float nextX;
        protected float nextY;
        protected float size;
        protected float space;
        protected int qty;
        protected int circleCount;

        private int lastSheetCount;
        private List<float[]> cornersListR;
        private List<float[]> cornersListT;
        private float scale;
        public Packing(float size, float space, int qty)
        {
            this.size = size;
            this.space = space;
            this.qty = qty;
            //cornersListR = new List<float[]>();
            //cornersListT = new List<float[]>();
        }

        public void InitiateCornersListR()
        {
            cornersListR = new List<float[]>();
        }
        public void InitiateCornersListT()
        {
            cornersListT = new List<float[]>();
        }
        public void FillSheet(Graphics g, float x, float y, float width, float height, string packType)
        {
                        
            float[] cornersArray;
            bool isLastSheet;
            int layerCount = 1;           
            nextY = y + space;
            circleCount = 0;

            while (Math.Round(nextY, 2) <= Math.Round(y + height - size - space, 2))
            {         
                nextX = GetNextX(packType, x, layerCount);
                while (Math.Round(nextX, 2) <= Math.Round(x + width - size - space, 2))
                {
                    if (circleCount < lastSheetCount)
                    {
                        isLastSheet = false;
                        cornersArray = new float[2];
                        cornersArray[0] = (float) Math.Round((nextX - x)/scale, 2);
                        cornersArray[1] = (float) Math.Round((nextY - y)/scale, 2);
                        if (packType == "rectangular") {                            
                            cornersListR.Add(cornersArray);
                        } else
                        {                            
                            cornersListT.Add(cornersArray);
                        }
                        
                    }
                    else
                    {
                        isLastSheet = true;
                    }
                    DrawCircle(g, isLastSheet);
                    circleCount += 1;                    
                    nextX += size + space;
                }
                nextY += GetNextY(packType);
                layerCount += 1;
            }            
        }
        
        protected float GetNextX(string packType, float x, int layerCount)
        {
            if(packType == "rectangular")
            {
                return x + space;
            } else
            {
                if(layerCount % 2 == 0)
                {
                    return x + space + size / 2;
                } else
                {
                    return x + space;
                }
            }
        }
        protected float GetNextY(string packType)
        {
            if (packType == "rectangular")
            {
                return size + space;
            }
            else
            {
                return Convert.ToSingle(Math.Sqrt(3) / 2 * size + space * Math.Sqrt(3) / 2);
            }
        }
        private void DrawCircle(Graphics g, bool isLastSheet)
        {
            Pen myPen = new Pen(Color.White);
            SolidBrush mySolidBrush = new SolidBrush(Color.White);
            g.DrawEllipse(myPen, nextX, nextY, size, size);
            if (!isLastSheet)
            {
                g.FillEllipse(mySolidBrush, nextX, nextY, size, size);
            }
        }

        public int GetCount()
        {
            return circleCount;
        }

        public int GetSheetCount()
        {
            return (int) Math.Ceiling((double) qty / circleCount);
        }

        public int GetLastSheetCount()
        {
            return circleCount * GetSheetCount() - qty;
        }

        public int LastSheetRestPercent()
        {
            return (int) Math.Round((double) GetLastSheetCount() / circleCount*100);
        } 
        public void SetCurrentSheetCount(int currentSheetCount)
        {
            this.lastSheetCount = currentSheetCount;
        }            
        public List<string[]> GetCircleCenters(string packType)
        {
            List<float[]> sourceCentersList;
            List<string[]>  circleCentersList = new List<string[]>();
            string[] centersArray;

            if (packType == "rectangular")
            {
                sourceCentersList = cornersListR;
            }
            else
            {
                sourceCentersList = cornersListT;
            }

            foreach (float[] corners in sourceCentersList)
            {
                centersArray = new string[2];
                centersArray[0] = Math.Round(corners[0] + size/2/scale, 2).ToString("0.00");
                centersArray[1] = Math.Round(corners[1] + size/2/scale, 2).ToString("0.00");
                circleCentersList.Add(centersArray);
            }

            return circleCentersList;
        }
        public void SetScale(float scale)
        {
            this.scale = scale;
        }       
    }
}
