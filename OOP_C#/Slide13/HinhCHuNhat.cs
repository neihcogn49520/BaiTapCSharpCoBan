using System;
using System.Collections.Generic;
using System.Text;

namespace Slide13
{
    class HinhChuNhat : Shape, ChiPhiSon
    {
        public int tinhDienTich()
        {
            return (rong * cao);
        }
        public int tinhChiPhi(int dientich)
        {
            return dientich * 70;
        }
    }
}
