using System;

namespace FirstHomework
{
    #region
    #endregion
    class ComplexNumber
    {
        public string Number { get; set; }
        private double Real, Complex;
        #region
        public void GetRealAndComplexPart()
        {
            bool f = true;
            bool f1 = false;
            string stringReal = "";
            string stringComplex = "";
            int i = 0;
            for (; i < Number.Length; i++)
            {

                if (Number[i] == '+')
                {
                    f1 = true;
                    i++;
                    break;
                }
                else if (Number[i] == '-' && i != 0)
                {
                    f = false;
                    f1 = true;
                    i++;
                    break;
                }
                stringReal += Number[i];
            }
            if (f == false)
                stringComplex += "-";
            for (; i < Number.Length - 1; i++)
            {

                stringComplex += Number[i];
            }
            Real = Convert.ToDouble(stringReal);
            if (f1 == false)
                Complex = 0;
            else if (stringComplex == "")
                Complex = 1;
            else if (stringComplex == "-")
                Complex = -1;
            else
                Complex = Convert.ToDouble(stringComplex);
        }
        #endregion
        #region
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            string outNumber = "";
            c1.GetRealAndComplexPart();
            c2.GetRealAndComplexPart();
            double outReal = c1.Real * c2.Real - c1.Complex * c2.Complex;
            double outComplex = c1.Real * c2.Complex + c2.Real * c1.Complex;
            if (outComplex == 0)
                outNumber += outReal;
            else if (outReal == 0)
                outNumber += outComplex + "i";
            else if (outComplex > 0)
                outNumber += outReal + "+" + outComplex + "i";
            else
            {
                outComplex *= -1;
                outNumber += outReal + "-" + outComplex + "i";
            }
            return new ComplexNumber { Number = outNumber };
        }
        #endregion
        #region
        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            string outNumber = "";
            c2.GetRealAndComplexPart();
            ComplexNumber c3;
            ComplexNumber c4;
            if (c2.Complex < 0)
            {
                c3 = c1 * new ComplexNumber { Number = "" + c2.Real + "+" + c2.Complex * (-1) + "i" };
                c4 = c2 * new ComplexNumber { Number = "" + c2.Real + "+" + c2.Complex * (-1) + "i" };
            }
            else
            {
                c3 = c1 * new ComplexNumber { Number = "" + c2.Real + c2.Complex * (-1) + "i" };
                c4 = c2 * new ComplexNumber { Number = "" + c2.Real + c2.Complex * (-1) + "i" };
            }
            c3.GetRealAndComplexPart();
            c4.GetRealAndComplexPart();
            double outReal = c3.Real / c4.Real;
            double outComplex = c3.Complex / c4.Real;
            if (outComplex == 0)
                outNumber += outReal;
            else if (outReal == 0)
                outNumber += outComplex;
            else if (outComplex > 0)
                outNumber += outReal + "+" + outComplex + "i";
            else
            {
                outComplex *= -1;
                outNumber += outReal + "-" + outComplex + "i";
            }
            return new ComplexNumber { Number = outNumber };
        }
    }
    #endregion
}
