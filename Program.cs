using ReCapProject.Business.Concrete;
using ReCapProject.DataAccess.Concrete;
using ReCapProject.Entities.Concrete;
using System;

namespace ConsoleUII
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();

            CarManager carManager = new CarManager(inMemoryCarDal);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Otomobil ID: " + car.Id + " " + "Marka ID: " + car.BrandId + " " + "Renk ID: " + car.ColorId + " " + "Model Yılı: " + car.ModelYear + " " +
                  "Günlük Fiyatı: " + car.DailyPrice + "TL" + "\n" + "Açıklaması: " + car.Description + "\n");
            }
            Console.WriteLine("OTOMOBİL LİSTESİNİN SONU." + "\n" + "\n");

            Console.WriteLine("ADD METODUNU TEST EDELİM. HONDA MARKA YENİ BİR ARAÇ EKLİYORUM VE TEKRAR GETALL METODU İLE LİSTELİYORUM;" + "\n");
            Car honda = new Car { Id = 10, BrandId = 7, ColorId = 4, ModelYear = 2021, DailyPrice = 500, Description = "2021 model, lacivert renk, Honda Civic" };
            inMemoryCarDal.Add(honda);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Otomobil ID: " + car.Id + " " + "Marka ID: " + car.BrandId + " " + "Renk ID: " + car.ColorId + " " + "Model Yılı: " + car.ModelYear + " " +
                                "Günlük Fiyatı: " + car.DailyPrice + "TL" + "\n" + "Açıklaması: " + car.Description + "\n");
            }
            Console.WriteLine("ADD METODUNUN SONU" + "\n" + "\n");

            Console.WriteLine("DELETE METODUNU TEST EDELİM. 3 NUMARALI ARACI SİLİYORUM;" + "\n");
            inMemoryCarDal.Delete(new Car { Id = 3 });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Otomobil ID: " + car.Id + " " + "Marka ID: " + car.BrandId + " " + "Renk ID: " + car.ColorId + " " + "Model Yılı: " + car.ModelYear + " " +
                                "Günlük Fiyatı: " + car.DailyPrice + "TL" + "\n" + "Açıklaması: " + car.Description + "\n");
            }
            Console.WriteLine("DELET METODUNUN SONU" + "\n" + "\n");

            Console.WriteLine("UPDATE METODUNU TEST EDELİM. 2 NUMARALI OTOMOBİLİ GÜNCELLİYORUM;" + "\n");
            inMemoryCarDal.Update(new Car { Id = 2, BrandId = 8, ColorId = 1, ModelYear = 2022, DailyPrice = 600, Description = "2022 model, beyaz renk,BMW 520i" });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Otomobil ID: " + car.Id + " " + "Marka ID: " + car.BrandId + " " + "Renk ID: " + car.ColorId + " " + "Model Yılı: " + car.ModelYear + " " +
                                "Günlük Fiyatı: " + car.DailyPrice + "TL" + "\n" + "Açıklaması: " + car.Description + "\n");
            }
            Console.WriteLine("UPDATE METODUNUN SONU" + "\n" + "\n");

            Console.WriteLine("GetByColorId METODUNU TEST EDELİM. ID'Sİ 1 OLAN YANİ BEYAZ RENKLİ ARAÇLARI LİSTELEYELİM." + "\n" + "3 ADET BEYAZ RENKLİ ARACIMIZ VAR" + "\n");

            foreach (var car in inMemoryCarDal.GetByColorId(1))
            {
                Console.WriteLine("Otomobil ID: " + car.Id + " " + "Marka ID: " + car.BrandId + " " + "Renk ID: " + car.ColorId + " " + "Model Yılı: " + car.ModelYear + " " +
                                "Günlük Fiyatı: " + car.DailyPrice + "TL" + "\n" + "Açıklaması: " + car.Description + "\n");
            }
            Console.WriteLine("GetByColorId METODUNUN SONU." + "\n" + "\n");

            Console.WriteLine("GetByBrandId METODUNU TEST EDELİM. MARKA ID'Sİ 4 OLAN PEUGEOT MARKA OTOMOBİLLERİ LİSTELEYELİM" + "\n" + "LİSTEDE 2 ADET VAR" + "\n");
            foreach (var car in inMemoryCarDal.GetByBrandId(4))
            {
                Console.WriteLine("Otomobil ID: " + car.Id + " " + "Marka ID: " + car.BrandId + " " + "Renk ID: " + car.ColorId + " " + "Model Yılı: " + car.ModelYear + " " +
                                "Günlük Fiyatı: " + car.DailyPrice + "TL" + "\n" + "Açıklaması: " + car.Description + "\n");
            }
            Console.WriteLine("BÜTÜN METOTLAR BAŞARIYLA ÇALIŞTI");

        }
    }
}
