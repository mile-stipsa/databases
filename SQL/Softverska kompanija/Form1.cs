using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Softverska_kompanija.Entiteti;
using System.Windows.Forms;

namespace Softverska_kompanija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ucitajZaposlenog_Click(object sender, EventArgs e)
        {
            ISession s=null;
            try
            {
                s = DataLayer.GetSession();
                Programer zaposleni = s.Load<Programer>(4);

                MessageBox.Show(zaposleni.Ime + " " + zaposleni.Prezime + " ");

                foreach(Angazovani an in zaposleni.AngazovaniProgramer)
                {
                    MessageBox.Show(an.Projekat.IDProjekta.ToString());
                }
               

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
            finally
            {
                s.Close();
            }
        }

        private void ucitajProjekat_Click(object sender, EventArgs e)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                //ovde ne radi a kad umesto dvojke stavis keca radi
                ProjekatKojiSeRazvijaUFirmi projekat = s.Load<ProjekatKojiSeRazvijaUFirmi>(2);
                MessageBox.Show(projekat.VremePocetka + " " + projekat.VremeZavrsetka);

                foreach(Angazovani ang in projekat.AngazovaniProgramerNaProjektu)
                {
                    MessageBox.Show(ang.Projekat.IDProjekta.ToString());
                }
               

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Close();
            }

        }

        private void oneToMany_Click(object sender, EventArgs e)
        {
            ISession s = null;
            try
            {
                 s = DataLayer.GetSession();
                Programer zaposleni = s.Load<Programer>(2);

               foreach(SpoljniSaradnik sar in zaposleni.AngazujeSaradnike)
                {
                    MessageBox.Show(sar.SIme + " " + sar.SPrezime);
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Close();
            }
        }

        private void manyToOne_Click(object sender, EventArgs e)
        {
            ISession s = null;
            try
            {
                 s = DataLayer.GetSession();
                SpoljniSaradnik sSaradnik = s.Load<SpoljniSaradnik>(2);

                Zaposleni zap = sSaradnik.AngazovanOd;

                MessageBox.Show(zap.Ime + " " + zap.Prezime+" "+zap.Telefoni[0].BrojTelefona);


                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Close();
            }
        }

        private void zaposleniZna_Click(object sender, EventArgs e)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                Programer zaposleni = s.Load<Programer>(2);

                foreach (Zna zna in zaposleni.ZnaProgramskiJezik)
                {
                    MessageBox.Show(zna.ImeProgramskogJezika.ImeProgramskogJezika);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Close();
            }
        }

        private void programskiJezikZna_Click(object sender, EventArgs e)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                ProgramskiJezik jezik = s.Load<ProgramskiJezik>(2);

                foreach (Zna zna in jezik.Zna)
                {
                    MessageBox.Show(zna.Programer.Ime+" "+zna.Programer.Prezime);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Close();
            }
        }

        private void zaposleniAngazovani_Click(object sender, EventArgs e)
        {
            ISession s = null;
            try
            {
                 s = DataLayer.GetSession();
                Programer zaposleni = s.Load<Programer>(5);

                //a ovde pronalazi na kom je projektu angazovan ID=2

                foreach (Angazovani angazovani in zaposleni.AngazovaniProgramer)
                {
                    MessageBox.Show("Angazovan je na projektu ciji je ID="+angazovani.Projekat.IDProjekta.ToString()+" od "+angazovani.Pocetak);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Close();
            }
        }

        private void projekatAngazovani_Click(object sender, EventArgs e)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                SoftverskiProjekat projekat = s.Load<SoftverskiProjekat>(2);
                //ovde nece da ucita ko je angazovan na tom projektu
                foreach (Angazovani angazovani in projekat.AngazovaniProgramerNaProjektu)
                {
                    MessageBox.Show(angazovani.Programer.Ime+" "+angazovani.Programer.Prezime);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Close();
            }
        }

        private void zaposleniRukovodi_Click(object sender, EventArgs e)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                StarijiProjektant zaposleni = s.Load<StarijiProjektant>(3);
                //ovde ucitava na kom projektu rukovodi Projekat je sa ID=2
                foreach (Rukovodi rukovodi in zaposleni.RukovodiProjektima)
                {
                    MessageBox.Show("Rukovodi projektom ciji je ID=" + rukovodi.Projekat.IDProjekta.ToString() + " od " + rukovodi.Pocetak);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Close();
            }
        }

        private void projekatRukovodi_Click(object sender, EventArgs e)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                //ovde ucitava a kad stavis umesto jedinice dvojku nece
                ProjekatKojiSeRazvijaUFirmi projekat = s.Load<ProjekatKojiSeRazvijaUFirmi>(1);

                foreach (Rukovodi rukovodi in projekat.AngazovaniSPNaProjektu)
                {
                    MessageBox.Show(rukovodi.StarijiProjektant.Ime + " " + rukovodi.StarijiProjektant.Prezime);

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Close();
            }
        }

        private void dodajProgramera_Click(object sender, EventArgs e)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();


                Programer programer = new Programer();

                programer.Ime = "Dimitrije";
                programer.Prezime = "Jovic";
                programer.JMBG = 0811996740070;
                programer.NazivUlica = "Vojvode Tankosica";
                programer.Grad = "Nis";
                programer.BrojKuce = 6;

                s.Save(programer);

                Telefon t = new Telefon();
                t.BrojTelefona = "065-8554599";
                t.Zaposleni = programer;

                

                Zna zna1 = new Zna();
                zna1.Programer = programer;
                zna1.ImeProgramskogJezika = s.Load<ProgramskiJezik>(2);

                s.Save(zna1);


                Zna zna2 = new Zna();
                zna2.Programer = programer;
                zna2.ImeProgramskogJezika = s.Load<ProgramskiJezik>(4);

               s.Save(zna2);
                

                Angazovani a = new Angazovani();
                a.Programer = programer;
                a.Projekat = s.Load<SoftverskiProjekat>(2);
                a.Pocetak = DateTime.Now;
                
               s.Save(a);


                SpoljniSaradnik ss= new SpoljniSaradnik();
                ss.SIme = "Predrag";
                ss.SPrezime = "Cvetkovic";
                ss.AngazovanOd = programer;

                s.Save(ss);

                STelefon st = new STelefon();
                st.BrojTelefona = "064-2589712";
                st.Saradnik = ss;

              

                ss.Telefoni.Add(st);

                s.Save(ss);

                programer.Telefoni.Add(t);
                programer.AngazovaniProgramer.Add(a);
                programer.AngazujeSaradnike.Add(ss);
               


                s.Save(programer);
               

                

                s.Flush();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                s.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn a = new LogIn();
            this.Hide();

            if(a.ShowDialog()==DialogResult.OK)
            {
                a.Show();
            }
            this.Show();
        }
    }
}
