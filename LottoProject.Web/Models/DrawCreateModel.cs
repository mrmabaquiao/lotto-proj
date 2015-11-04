using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LottoProject.Web.Models
{
    public class DrawCreateModel
    {
        public virtual int Id { get; set; }
        public virtual int FirstDigit { get; set; }
        public virtual int SecondDigit { get; set; }
        public virtual int ThirdDigit { get; set; }
        public virtual int FourthDigit { get; set; }
        public virtual int FifthDigit { get; set; }
        public virtual int SixthDigit { get; set; }
        public virtual string Catergory { get; set; }
    }
}