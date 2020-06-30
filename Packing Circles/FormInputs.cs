using System;

namespace Packing_Circles
{
    class FormInputs
    {
        private float x;
        private float y;
        private float width;
        private float height;

        private float scale;
        private float scaleWidth;
        private float scaleHeight;

        private float maxWidth;
        private float maxHeight;

        private float size;
        private float space;

        public FormInputs(int x, int y, int formWidth, int formHeight){
            this.x = x;
            this.y = y;
            maxWidth = (formWidth - x - 30);
            maxHeight = (formHeight - y - 74 - 12)/2;
        }                

        public void AdjustScale()
        {
            try
            {
                scale = Math.Min(scaleWidth, scaleHeight);
                SetWidth(width * scale);
                SetHeight(height * scale);
                SetSize(size * scale);
                SetSpace(space * scale);
            }catch
            {

            }
        }  
        
        public string GetDecimalNumber(string numString)
        {            
            if (numString.StartsWith("."))
            {
                return "0" + numString;
            }
            else
            {
                return numString;
            }
        }
        public void SetWidth(float width)
        {
            this.width = width;
            scaleWidth = maxWidth / width;            
        }
        public void SetHeight(float height)
        {
            this.height = height;
            scaleHeight = maxHeight / height;
        }
        public void SetSize(float size)
        {
            this.size = size;            
        }
        
        public void SetSpace(float space)
        {
            this.space = space;
        }
        public float GetX()
        {
            return x;
        }
        public float GetY()
        {
            return y;
        }
        public float GetWidth()
        {
            return width;
        }
        public float GetHeight()
        {
            return height;
        }
        public float GetSize()
        {
            return size;
        }
        public float GetSpace()
        {
            return space;
        }
        public float GetScale()
        {
            return scale;
        }
    }
}
