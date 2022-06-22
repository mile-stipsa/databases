using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Linq;
using Softverska_kompanija.Entiteti;
using Softverska_kompanija.DTO;
using System.Windows.Forms;

namespace Softverska_kompanija.DTO
{
    public class DTOManager
    {
        public static List<FirmaPRBasic> rukovodiProjektima(int IdProjektant) 
        {
            List<FirmaPRBasic> projekti = new List<FirmaPRBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                StarijiProjektant projektant = s.QueryOver<StarijiProjektant>().Where(x => x.IDZaposljenog == IdProjektant).SingleOrDefault();


                
                foreach (Rukovodi proj in projektant.RukovodiProjektima)
                {
                    if(proj.Kraj.Equals(null))
                        if(proj.Projekat.VremeZavrsetka.Equals(null))
                            projekti.Add(new FirmaPRBasic(proj.Projekat));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                return null;
            }

            return projekti;
        }

        public static List<ProgramerBasic> zaposlenProgramerNaProjektu(int IdProjekat) 
        {
            List<ProgramerBasic> programeri = new List<ProgramerBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                SoftverskiProjekat projekat = s.Load<SoftverskiProjekat>(IdProjekat);


                if(projekat.VremeZavrsetka.Equals(null))
                    foreach (Angazovani ang in projekat.AngazovaniProgramerNaProjektu)
                    {
                        if(ang.Kraj.Equals(null))
                            programeri.Add(new ProgramerBasic(ang.Programer));
                    }

                s.Close();

            }
            catch (Exception ec)
            {
                return null;
            }

            return programeri;
        }

        public static void OtpustiProgrameraSaProjekta(int idProg, int idProj) 
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Programer programer = s.Load<Programer>(idProg);

                foreach (Angazovani ang in programer.AngazovaniProgramer)
                {
                    if (ang.Projekat.IDProjekta == idProj && ang.Kraj.Equals(null))
                        ang.Kraj = DateTime.Now.Date;
                }

                s.Update(programer);

                s.Flush();
                s.Close();
            }

            catch (Exception ec)
            {

            }
        }

        public static List<ProjekatBasic> projektiZaposlenog(int idZaposleni)
        {
            List<ProjekatBasic> projekti = new List<ProjekatBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                Programer programer = s.Load<Programer>(idZaposleni);



                foreach (Angazovani proj in programer.AngazovaniProgramer)
                {
                    if(proj.Kraj.Equals(null))
                        projekti.Add(new ProjekatBasic(proj.Projekat));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                return null;
            }

            return projekti;
        }

        public static List<SpoljniSaradnikBasic> saradniciZaposlenog(int idZaposleni)
        {
            List<SpoljniSaradnikBasic> saradnici = new List<SpoljniSaradnikBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                Programer programer = s.Load<Programer>(idZaposleni);



                foreach (SpoljniSaradnik sar in programer.AngazujeSaradnike)
                {
                    saradnici.Add(new SpoljniSaradnikBasic(sar));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                return null;
            }

            return saradnici;
        }

        public static void ObrisiSaradnika(int idSaradnika)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SpoljniSaradnik sr = s.QueryOver<SpoljniSaradnik>().Where(x => x.IDSaradnika == idSaradnika).SingleOrDefault();

                s.Delete(sr);


                s.Flush();
                s.Close();
            }

            catch (Exception ec)
            {

            }
        }

        public static List<ProgramerBasic> UcitajSveProgramere()
        {
            List<ProgramerBasic> programeri = new List<ProgramerBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                List<Programer> prog = s.QueryOver<Programer>().List<Programer>().ToList<Programer>();

                foreach (Programer p in prog)
                {
                    programeri.Add(new ProgramerBasic(p));
                }


                s.Close();
            }

            catch (Exception ec)
            {

            }
            return programeri;
        }

        public static List<StarijiProjektantBasic> UcitajSveProjektante()
        {
            List<StarijiProjektantBasic> projektanti = new List<StarijiProjektantBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                List<StarijiProjektant> proj = s.QueryOver<StarijiProjektant>().List<StarijiProjektant>().ToList<StarijiProjektant>();

                foreach (StarijiProjektant pr in proj)
                {
                    projektanti.Add(new StarijiProjektantBasic(pr));
                }


                s.Close();
            }

            catch (Exception ec)
            {

            }
            return projektanti;
        }

        public static void ObrisiProgramera(int idProg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Programer pr = s.QueryOver<Programer>().Where(x => x.IDZaposljenog == idProg).SingleOrDefault();

                s.Delete(pr);


                s.Flush();
                s.Close();
            }

            catch (Exception ec)
            {

            }
        }

        public static void ObrisiProjektanta(int idProj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StarijiProjektant projekt = s.QueryOver<StarijiProjektant>().Where(x => x.IDZaposljenog == idProj).SingleOrDefault();

                s.Delete(projekt);


                s.Flush();
                s.Close();
            }

            catch (Exception ec)
            {

            }
        }

        public static void AzurirajProgramera(ProgramerBasic p,int ID)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Programer programer = s.Load<Programer>(ID);

                programer.Ime = p.Ime;
                programer.Prezime = p.Prezime;
                programer.JMBG = p.JMBG;
                programer.Grad = p.Grad;
                programer.NazivUlica = p.NazivUlica;
                programer.BrojKuce = p.BrojKuce;

                s.Update(programer);


                s.Flush();
                s.Close();
            }

            catch (Exception ec)
            {

            }
        }

        public static void DodajProgramera(ProgramerBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Programer programer = new Programer();

                programer.Ime = p.Ime;
                programer.Prezime = p.Prezime;
                programer.JMBG = p.JMBG;
                programer.Grad = p.Grad;
                programer.NazivUlica = p.NazivUlica;
                programer.BrojKuce = p.BrojKuce;

                s.Save(programer);

                p.IDZaposljenog = programer.IDZaposljenog;


                s.Flush();
                s.Close();
            }

            catch (Exception ec)
            {

            }
        }

        public static void DodajStarijegProjektanta(StarijiProjektantBasic ss)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StarijiProjektant projektant = new StarijiProjektant();

                projektant.Ime = ss.Ime;
                projektant.Prezime = ss.Prezime;
                projektant.JMBG = ss.JMBG;
                projektant.Grad = ss.Grad;
                projektant.NazivUlica = ss.NazivUlica;
                projektant.BrojKuce = ss.BrojKuce;

                s.Save(projektant);

                ss.IDZaposljenog = projektant.IDZaposljenog;



                s.Flush();
                s.Close();
            }

            catch (Exception ec)
            {

            }
        }

        public static void AzurirajStarijegProjektanta(StarijiProjektantBasic ss,int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StarijiProjektant projektant =s.Load<StarijiProjektant>(id);

                projektant.Ime = ss.Ime;
                projektant.Prezime = ss.Prezime;
                projektant.JMBG = ss.JMBG;
                projektant.Grad = ss.Grad;
                projektant.NazivUlica = ss.NazivUlica;
                projektant.BrojKuce = ss.BrojKuce;

                s.Update(projektant);


                s.Flush();
                s.Close();
            }

            catch (Exception ec)
            {

            }
        }

        public static List<ProjekatBasic> UcitajSveProjekte()
        {
            List<ProjekatBasic> projekti = new List<ProjekatBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                List<SoftverskiProjekat> proj = s.QueryOver<SoftverskiProjekat>().List<SoftverskiProjekat>().ToList<SoftverskiProjekat>();

                foreach (SoftverskiProjekat pr in proj)
                {
                    projekti.Add(new ProjekatBasic(pr));
                }


                s.Close();
            }

            catch (Exception ec)
            {

            }
            return projekti;
        }

        public static void ZavrsiProjekat(int idProj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SoftverskiProjekat proj = s.QueryOver<SoftverskiProjekat>().Where(x => x.IDProjekta == idProj).SingleOrDefault();

                proj.VremeZavrsetka = DateTime.Now.Date;


                s.Update(proj);

                s.Flush();
                s.Close();
            }

            catch (Exception ec)
            {

            }
        }

        public static void DodajProjekat(int broj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SoftverskiProjekat proj=null;
                if (broj == 0)
                {
                   proj = new ProjekatKojiSeRazvijaUFirmi();
                }
                else
                {
                    proj = new Outsourcing();
                }
                proj.VremePocetka = DateTime.Now.Date;

                s.Save(proj);

                s.Flush();
                s.Close();
            }

            catch (Exception ec)
            {

            }
        }

        public static void DodajSpoljnogSaradnika(int ID,SpoljniSaradnikBasic ss)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Programer zaposleni = s.Load<Programer>(ID);

                SpoljniSaradnik sar = new SpoljniSaradnik();

                sar.SIme = ss.SIme;
                sar.SPrezime = ss.SPrezime;
                sar.AngazovanOd = zaposleni;

                zaposleni.AngazujeSaradnike.Add(sar);
                s.Save(zaposleni);

                s.Flush();
                s.Close();
            }

            catch (Exception ec)
            {

            }
        }

        public static List<ProgramerBasic> UcitajNeangazovaneProgramere(int id)
        {
            List<ProgramerBasic> programeri = new List<ProgramerBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                List<Programer> prog = s.QueryOver<Programer>().List<Programer>().ToList<Programer>();
                foreach(Programer p in prog)
                {
                    int br = 0;
                    if (p.AngazovaniProgramer.Count != 0)
                    {
                        foreach (Angazovani a in p.AngazovaniProgramer)
                        {
                            if(a.Projekat.VremeZavrsetka.Equals(null))
                                if(a.Kraj.Equals(null))
                                    if (a.Projekat.IDProjekta == id)
                                        br++;
                            
                        }
                        if(br==0)
                        {
                            programeri.Add(new ProgramerBasic(p));
                        }
                    }
                    else
                    {
                        programeri.Add(new ProgramerBasic(p));
                    }
                }


                s.Close();
            }

            catch (Exception ec)
            {

            }
            return programeri;
        }

        public static void AngazujProgrameraNaProjektu(int idProj,int idProg)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Programer prog = s.Load<Programer>(idProg);
                SoftverskiProjekat proj = s.Load<SoftverskiProjekat>(idProj);

                Angazovani ang = new Angazovani();
                ang.Programer = prog;
                ang.Projekat = proj;
                ang.Pocetak = DateTime.Now.Date;

                prog.AngazovaniProgramer.Add(ang);
                s.Save(prog);
                s.Flush();


                s.Close();
            }

            catch (Exception ec)
            {

            }
        }

        public static List<TelefonBasic> UcitajTelefoneZaposlenog(int id)
        {
            List<TelefonBasic> telefoni = new List<TelefonBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                Zaposleni zaposleni = s.Load<Zaposleni>(id);
                foreach (Telefon tel in zaposleni.Telefoni)
                {
                    telefoni.Add(new TelefonBasic(tel));
                }


                s.Close();
            }

            catch (Exception ec)
            {

            }
            return telefoni;
        }

        public static void DodajTelefon(int id,TelefonBasic tel)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Zaposleni zaposleni = s.Load<Zaposleni>(id);
                Telefon t = new Telefon();
                t.Zaposleni = zaposleni;
                t.BrojTelefona = tel.BrojTelefona;
                zaposleni.Telefoni.Add(t);

                s.SaveOrUpdate(zaposleni);
                s.Flush();


                s.Close();
            }

            catch (Exception ec)
            {

            }
        }

        public static void ObrisiTelefon(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Telefon tel = s.Load<Telefon>(id);
               

                s.Delete(tel);
                s.Flush();


                s.Close();
            }

            catch (Exception ec)
            {

            }
        }

        public static void DodajSTelefon(int id, STelefonBasic tel)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpoljniSaradnik saradnik = s.Load<SpoljniSaradnik>(id);
                STelefon t = new STelefon();
                t.Saradnik = saradnik;
                t.BrojTelefona = tel.BrojTelefona;
                saradnik.Telefoni.Add(t);

                s.SaveOrUpdate(saradnik);
                s.Flush();


                s.Close();
            }

            catch (Exception ec)
            {

            }
        }

        public static void ObrisiSTelefon(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                STelefon tel = s.Load<STelefon>(id);


                s.Delete(tel);
                s.Flush();


                s.Close();
            }

            catch (Exception ec)
            {

            }
        }


        public static List<STelefonBasic> UcitajTelefoneSaradnika(int id)
        {
            List<STelefonBasic> telefoni = new List<STelefonBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                SpoljniSaradnik zaposleni = s.Load<SpoljniSaradnik>(id);
                foreach (STelefon tel in zaposleni.Telefoni)
                {
                    telefoni.Add(new STelefonBasic(tel));
                }


                s.Close();
            }

            catch (Exception ec)
            {

            }
            return telefoni;
        }

        public static List<StarijiProjektantBasic> UcitajNeangazovaneProjektante(int id)
        {
            List<StarijiProjektantBasic> projektanti = new List<StarijiProjektantBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                SoftverskiProjekat projekat = s.Load<SoftverskiProjekat>(id);
                if ((projekat.Vrati is ProjekatKojiSeRazvijaUFirmi))
                {
                    if(projekat.VremeZavrsetka.Equals(null))
                    { 
                        List<StarijiProjektant> proj = s.QueryOver<StarijiProjektant>().List<StarijiProjektant>().ToList<StarijiProjektant>();

                        foreach (StarijiProjektant p in proj)
                        {
                            int br = 0;
                            if (p.RukovodiProjektima.Count != 0)
                            {
                                foreach (Rukovodi r in p.RukovodiProjektima)
                                {
                                    if(r.Kraj.Equals(null))
                                        if (r.Projekat.IDProjekta == id)
                                        {
                                            br++;
                                            break;
                                        }

                                }
                                if (br == 0)
                                {
                                    projektanti.Add(new StarijiProjektantBasic(p));
                                }
                            }
                            else
                            {
                                projektanti.Add(new StarijiProjektantBasic(p));
                            }
                        }
                    }
                }


                s.Close();
            }

            catch (Exception ec)
            {

            }
            return projektanti;
        }

        public static void AngazujProjektantaNaProjektu(int idProj, int idProg)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StarijiProjektant projektant = s.Load<StarijiProjektant>(idProg);
                SoftverskiProjekat projekat = s.Load<SoftverskiProjekat>(idProj);

                Rukovodi rukovodi = new Rukovodi();
                rukovodi.StarijiProjektant = projektant;
                rukovodi.Projekat = projekat;
                rukovodi.Pocetak = DateTime.Now.Date;

                projektant.RukovodiProjektima.Add(rukovodi);
                s.Save(projektant);
                s.Flush();


                s.Close();
            }

            catch (Exception ec)
            {

            }
        }

        public static List<StarijiProjektantBasic> ZaposlenProjektantNaProjektu(int IdProjekat)
        {
            List<StarijiProjektantBasic> projektanti = new List<StarijiProjektantBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                ProjekatKojiSeRazvijaUFirmi projekat;

               SoftverskiProjekat proj = s.Load<SoftverskiProjekat>(IdProjekat); 
                

                if (proj.Vrati is ProjekatKojiSeRazvijaUFirmi)
                {
                    projekat = (ProjekatKojiSeRazvijaUFirmi)proj.Vrati;
                    if (projekat.VremeZavrsetka.Equals(null))
                    { 
                        foreach (Rukovodi r in projekat.AngazovaniSPNaProjektu)
                        {
                            if(r.Kraj.Equals(null))
                                projektanti.Add(new StarijiProjektantBasic(r.StarijiProjektant));
                        }
                    }
                }

                s.Close();

            }
            catch (Exception ec)
            {
                return null;
            }

            return projektanti;
        }

        public static void OtpustiProjektantaSaProjekta(int idProg, int idProj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StarijiProjektant projektant = s.Load<StarijiProjektant>(idProg);

                foreach (Rukovodi ruk in projektant.RukovodiProjektima)
                {
                    if(ruk.Projekat.IDProjekta==idProj&&ruk.Kraj.Equals(null))
                        ruk.Kraj = DateTime.Now.Date;
                }


                s.Update(projektant);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {

            }
        }
    }
}
