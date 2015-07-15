namespace LottoProject.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LottoProject.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<LottoProject.Web.Infrastructure.LottoDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LottoProject.Web.Infrastructure.LottoDb context)
        {
            context.Draws.AddOrUpdate(d => d.Catergory,
                new Draw() { Catergory = "655",FirstDigit =1,SecondDigit=2,ThirdDigit=3,FourthDigit =4 ,FifthDigit =5 ,SixthDigit=6, DrawDate = DateTime.Now},
                new Draw() { Catergory = "649", FirstDigit = 1, SecondDigit = 2, ThirdDigit = 3, FourthDigit = 4, FifthDigit = 5, SixthDigit = 6 , DrawDate = DateTime.Now}

                );
        }
    }
}
