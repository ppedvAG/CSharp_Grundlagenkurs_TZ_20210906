using System;
using System.Collections.Generic;

namespace M012_05_SOLID_InterfaceSegregationPrincip
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository kontoRepo = new KontoRepository();
            kontoRepo.Create(new Konto());
            kontoRepo.Update(new Konto());
            kontoRepo.GetAll();
            kontoRepo.GetById(123);
            kontoRepo.Delete(123);


            //für Mitarbeiter gedacht, die nur REadonly Rechte im System haben 
            IReadKontoRepository readonlyKontoRepo = new KontoRepository();
            readonlyKontoRepo.GetAll();
            readonlyKontoRepo.GetById(123);


            #region Better Code
            //User darf nur lesen

            ICanReadKonto readKontoRepository = new BetterKontoRepository();
            readKontoRepository.GetAll(); 
            readKontoRepository.GetById(123);


            ICanInsertKonto insertKontoRepository = new BetterKontoRepository();
            insertKontoRepository.Insert(new Konto());


            ICanUpdateKonto updateRepo = new BetterKontoRepository();
            updateRepo.Update(new Konto());
            #endregion

        }
    }

    public class Konto
    {
        public int Id { get; set; }
        public decimal Kontostand { get; set; }
    }



    #region Bad Code
    //Repository CRUD -> Create / Read / Update / Delete 

    public interface IReadKontoRepository
    {
        public IList<Konto> GetAll();
        public Konto GetById(int id);
    }

    public interface IRepository : IReadKontoRepository
    {
        public void Create(Konto konto);
        public void Update(Konto konto);
        public void Delete(int Id);
    }

    public class KontoRepository : IRepository
    {
        public void Create(Konto konto)
        {
            //erstelle ein Datensatz   
        }

        public void Delete(int Id)
        {
            //Lösche ein Datensatz   
        }

        public IList<Konto> GetAll()
        {
            return new List<Konto>();
        }

        public Konto GetById(int id)
        {
            return new Konto();
        }

        public void Update(Konto konto)
        {
           //Mach ein Update
        }
    }
    #endregion


    #region Better Code

    public interface ICanReadKonto
    {
        public IList<Konto> GetAll();
        public Konto GetById(int id);
    }

    public interface ICanUpdateKonto
    {
        public void Update(Konto konto);
    }

    public interface ICanInsertKonto
    {
        public void Insert(Konto konto);
    }

    public interface ICanDeleteKonto
    {
        public void Delete(int Id);
    }


    public class BetterKontoRepository : ICanReadKonto, ICanUpdateKonto, ICanInsertKonto, ICanDeleteKonto
    {
        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IList<Konto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Konto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Konto konto)
        {
            throw new NotImplementedException();
        }

        public void Update(Konto konto)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
