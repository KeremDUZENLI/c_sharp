using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimSatis
{
    class Program
    {
        static void Main(string[] args)
        {
            IEgitimService egitimService = new EgitimManager(new EfEgitimDal());
            foreach (var egitim in egitimService.ListeleEgitimler())
            {
                Console.WriteLine(egitim.Ad + " = " + egitim.Fiyat);
            }



            Console.ReadLine();
        }
    }

    class Egitim : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
    }

    interface IEntity
    {
    }

    class EgitimManager : IEgitimService
    {
        IEgitimDal _egitimDal;

        public EgitimManager(IEgitimDal egitimDal)
        {
            _egitimDal = egitimDal;
        }

        public List<Egitim> ListeleEgitimler()
        {
            List<Egitim> egitimler = _egitimDal.ListeleEgitimler();
            StandardFiyataGoreGuncelle(egitimler);
            return egitimler;
        }

        private void StandardFiyataGoreGuncelle(List<Egitim> egitimler)
        {
            foreach (var egitim in egitimler)
            {
                egitim.Fiyat = GuncelStandardFiyatiGetir();
            }
        }

        private decimal GuncelStandardFiyatiGetir()
        {
            // veri tabanına bağlan
            return 25;
        }
    }

    interface IEgitimDal
    {
        List<Egitim> ListeleEgitimler();
    }

    class EfEgitimDal : IEgitimDal
    {
        public List<Egitim> ListeleEgitimler()
        {
            return new List<Egitim>
            {
                new Egitim{Id=1, Ad="C# Kursu", Fiyat=400},
                new Egitim{Id=2, Ad="Java Kursu", Fiyat=300},
                new Egitim{Id=3, Ad="Python Kursu", Fiyat=200}
            };
        }
    }

    interface IEgitimService
    {
        List<Egitim> ListeleEgitimler();
    }
}
