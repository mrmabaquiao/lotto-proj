using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoProject.Domain
{
    public class Draw
    {
        public virtual int Id { get; set; }
        public virtual int FirstDigit { get; set; }
        public virtual int SecondDigit { get; set; }
        public virtual int ThirdDigit { get; set; }
        public virtual int FourthDigit { get; set; }
        public virtual int FifthDigit { get; set; }
        public virtual int SixthDigit { get; set; }
        public virtual DateTime DrawDate { get; set; }
        public virtual string Catergory { get; set; }
    }
}
