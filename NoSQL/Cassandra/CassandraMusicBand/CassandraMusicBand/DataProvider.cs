using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CassandraMusicBand.Entiteti;
using CassandraMusicBand.Konekcija;
using Cassandra;
using System.Globalization;

namespace CassandraMusicBand    
{
    public static class DataProvider
    {
        private static int brojMuzicara;
        private static int brojPevaca;
        private static int brojMenadzera;
        public static int brojAlbuma;
        private static int brojBendova;
        private static int brojKoncerata;
        private static int brojPesama1;
        public static int brojPesama2;

        #region Bend

        public static List<Bend> VratiBendove()
        {
            ISession session = DataLayer.GetSession();
            List<Bend> bendovi = new List<Bend>();


            if (session == null)
            {
                return null;
            }
            else
            {

                var bendData = session.Execute("select * from \"Bend\"");


                foreach (var bend in bendData)
                {
                    Bend bend1 = new Bend();
                    bend1.BendID = bend["BendID"] != null ? bend["BendID"].ToString() : string.Empty;
                    bend1.ime = bend["ime"] != null ? bend["ime"].ToString() : string.Empty;
                    bend1.stil = bend["stil"] != null ? bend["stil"].ToString() : string.Empty;
                    bend1.datumosnivanja = bend["datumosnivanja"] != null ? bend["datumosnivanja"].ToString() : string.Empty;
                    bendovi.Add(bend1);
                }

               return bendovi;
            }

        }

        public static Bend VratiBend(String BendID)
        {
            ISession session = DataLayer.GetSession();
            Bend bend = new Bend();


            if (session == null)
            {
                return null;
            }
            else
            {

                var bendData = session.Execute("select * from \"Bend\" where \"BendID\" = '" + BendID + "'").FirstOrDefault() ;


               if(bendData!=null)
                {
                    bend.BendID = bendData["BendID"] != null ? bendData["BendID"].ToString() : string.Empty;
                    bend.ime = bendData["ime"] != null ? bendData["ime"].ToString() : string.Empty;
                    bend.stil = bendData["stil"] != null ? bendData["stil"].ToString() : string.Empty;
                    bend.datumosnivanja = bendData["datumosnivanja"] != null ? bendData["datumosnivanja"].ToString() : string.Empty;
                }
                return bend;

            }
        }

        public static void VratiBrojBendova()
        {
            ISession session = DataLayer.GetSession();


            if (session == null)
            {
                return;
            }
            else
            {

                var muzicarData = session.Execute("select * from \"Bend\"");
                brojBendova = muzicarData.GetRows().Count();
                brojBendova++;
            }
        }

        public static bool DodajBend(String ime, String stil, String datumOsnivanja)
        {
            ISession session = DataLayer.GetSession();

            if (session == null)
                return false;
            VratiBrojBendova();
            RowSet bendData = session.Execute("insert into \"Bend\"(\"BendID\", ime, stil, datumosnivanja) values ('" + brojBendova.ToString() + "', '" + ime + "', '" + stil + "', '" + datumOsnivanja + "')");
            return true;
        }

        public static bool updateBend(String ime, String BendID)
        {
            ISession session = DataLayer.GetSession();
            if (session == null)
                return false;

            var bendData = session.Execute("update \"Bend\" set ime = '" + ime + "' where \"BendID\" = '" + BendID + "'");
            return true;
        }

        #endregion

        #region Muzicar

        public static void vratiBrojMuzicara()
        {
            ISession session = DataLayer.GetSession();


            if (session == null)
            {
                return;
            }
            else
            {

                var muzicarData = session.Execute("select * from \"Muzicar\"");
                brojMuzicara= muzicarData.GetRows().Count();
                brojMuzicara++;
            }
        }

        public static List<Muzicar> VratiMuzicare(String BendID)
        {
            ISession session = DataLayer.GetSession();
            List<Muzicar> muzicari = new List<Muzicar>();


            if (session == null)
            {
                return null;
            }
            else
            {

                var muzicarData = session.Execute("select * from \"Muzicar\" where \"BendID\" = '" + BendID + "' allow filtering");


                foreach (var muz in muzicarData)
                {
                    Muzicar muzicar = new Muzicar();
                    muzicar.MuzicarID = muz["MuzicarID"] != null ? muz["MuzicarID"].ToString() : string.Empty;
                    muzicar.BendID = muz["BendID"] != null ? muz["BendID"].ToString() : string.Empty;
                    muzicar.ime = muz["ime"] != null ? muz["ime"].ToString() : string.Empty;
                    muzicar.prezime = muz["prezime"] != null ? muz["prezime"].ToString() : string.Empty;
                    muzicar.nadimak = muz["nadimak"] != null ? muz["nadimak"].ToString() : string.Empty;
                    muzicar.instrument = muz["instrument"] != null ? muz["instrument"].ToString() : string.Empty;
                    muzicari.Add(muzicar);
                }

                return muzicari;
            }

        }

        public static bool dodajMuzicara(String ime, String prezime,String nadimak, String instrument, String bendID)
        {
            ISession session = DataLayer.GetSession();

            if (session == null)
                return false;
            vratiBrojMuzicara();
            RowSet muzicarData = session.Execute("insert into \"Muzicar\"(\"MuzicarID\", \"BendID\", ime, prezime, nadimak, instrument) values ('"+brojMuzicara.ToString()+"', '"+bendID+"', '"+ime+"', '"+prezime+"', '"+nadimak+"', '"+instrument+"')");
            return true;
        }

        public static bool obrisiMuzicara(String muzicarID)
        {
            ISession session = DataLayer.GetSession();

            if (session == null)
                return false;

            RowSet muzicar = session.Execute("delete from \"Muzicar\" where \"MuzicarID\" = '" + muzicarID + "'");
            return true;
        }

        #endregion

        #region Pevac

        public static void vratiBrojPevaca()
        {
            ISession session = DataLayer.GetSession();


            if (session == null)
            {
                return;
            }
            else
            {

                var pevacData = session.Execute("select * from \"Pevac\"");
                brojPevaca = pevacData.GetRows().Count();
                brojPevaca++;
            }
        }

        public static List<Pevac> VratiPevace(String BendID)
        {
            ISession session = DataLayer.GetSession();
            List<Pevac> pevaci = new List<Pevac>();


            if (session == null)
            {
                return null;
            }
            else
            {

                var pevacData = session.Execute("select * from \"Pevac\" where \"BendID\" = '" + BendID + "' allow filtering");


                foreach (var pev in pevacData)
                {
                    Pevac pevac = new Pevac();
                    pevac.PevacID = pev["PevacID"] != null ? pev["PevacID"].ToString() : string.Empty;
                    pevac.BendID = pev["BendID"] != null ? pev["BendID"].ToString() : string.Empty;
                    pevac.ime = pev["ime"] != null ? pev["ime"].ToString() : string.Empty;
                    pevac.prezime = pev["prezime"] != null ? pev["prezime"].ToString() : string.Empty;
                    pevac.nadimak = pev["nadimak"] != null ? pev["nadimak"].ToString() : string.Empty;
                    pevaci.Add(pevac);
                }

                return pevaci;
            }

        }

        public static bool dodajPevaca(String ime, String prezime, String nadimak, String bendID)
        {
            ISession session = DataLayer.GetSession();

            if (session == null)
                return false;
            vratiBrojPevaca();
            RowSet pevacData = session.Execute("insert into \"Pevac\"(\"PevacID\", \"BendID\", ime, prezime, nadimak) values ('" + brojPevaca.ToString() + "', '" + bendID + "', '" + ime + "', '" + prezime + "', '" + nadimak + "')");
            return true;
        }

        public static bool obrisiPevaca(String pevacID)
        {
            ISession session = DataLayer.GetSession();

            if (session == null)
                return false;

            RowSet muzicar = session.Execute("delete from \"Pevac\" where \"PevacID\" = '" + pevacID + "'");
            return true;
        }

        #endregion

        #region Album

        public static void vratiBrojAlbuma()
        {
            ISession session = DataLayer.GetSession();


            if (session == null)
            {
                return;
            }
            else
            {

                var albumData = session.Execute("select * from \"Album\"");
                brojAlbuma = albumData.GetRows().Count();
                brojAlbuma++;
            }
        }

        public static List<Album> VratiAlbume(String BendID)
        {
            ISession session = DataLayer.GetSession();
            List<Album> albumi = new List<Album>();


            if (session == null)
            {
                return null;
            }
            else
            {

                var albumData = session.Execute("select * from \"Album\" where \"BendID\" = '" + BendID + "' allow filtering");


                foreach (var alb in albumData)
                {
                    Album album = new Album();
                    album.AlbumID = alb["AlbumID"] != null ? alb["AlbumID"].ToString() : string.Empty;
                    album.BendID = alb["BendID"] != null ? alb["BendID"].ToString() : string.Empty;
                    album.naziv = alb["naziv"] != null ? alb["naziv"].ToString() : string.Empty;
                    album.datumizlaska = alb["datumizlaska"] != null ? alb["datumizlaska"].ToString() : string.Empty;
                    album.brojpesama = alb["brojpesama"] != null ? alb["brojpesama"].ToString() : string.Empty;
                    albumi.Add(album);
                }

                return albumi;
            }

        }

        public static bool dodajAlbum(String naziv, String datumIzlaska, String bendID)
        {
            ISession session = DataLayer.GetSession();

            if (session == null)
                return false;
            vratiBrojAlbuma();
            RowSet albumData = session.Execute("insert into \"Album\"(\"AlbumID\", \"BendID\", naziv, datumizlaska, brojpesama) values ('" + brojAlbuma.ToString() + "', '" + bendID + "', '" + naziv + "', '" + datumIzlaska + "', '0')");
            return true;
        }

        public static bool updateAlbum(String AlbumID,String brojPesama,String bendID)
        {
            ISession session = DataLayer.GetSession();
            if (session == null)
                return false;

            var bendData = session.Execute("update \"Album\" set brojpesama = '" + brojPesama + "' where \"AlbumID\" = '" + AlbumID + "' and \"BendID\" = '"+bendID+"'");
            return true;
        }

        #endregion

        #region Koncert

        public static void vratiBrojKoncerata()
        {
            ISession session = DataLayer.GetSession();


            if (session == null)
            {
                return;
            }
            else
            {

                var koncertData = session.Execute("select * from \"Koncert\"");
                brojKoncerata = koncertData.GetRows().Count();
                brojKoncerata++;
            }
        }

        public static List<Koncert> VratiKoncerte(String BendID)
        {
            ISession session = DataLayer.GetSession();
            List<Koncert> koncerti = new List<Koncert>();


            if (session == null)
            {
                return null;
            }
            else
            {

                var koncertData = session.Execute("select * from \"Koncert\" where \"BendID\" = '" + BendID + "' allow filtering");


                foreach (var konc in koncertData)
                {
                    Koncert koncert = new Koncert();
                    koncert.KoncertID = konc["KoncertID"] != null ? konc["KoncertID"].ToString() : string.Empty;
                    koncert.BendID = konc["BendID"] != null ? konc["BendID"].ToString() : string.Empty;
                    koncert.grad = konc["grad"] != null ? konc["grad"].ToString() : string.Empty;
                    koncert.datum = konc["datum"] != null ? konc["datum"].ToString() : string.Empty;
                    koncerti.Add(koncert);
                }

                return koncerti;
            }

        }

        public static bool dodajKoncert(String grad, String datum, String bendID)
        {
            ISession session = DataLayer.GetSession();

            if (session == null)
                return false;
            vratiBrojKoncerata();
            RowSet albumData = session.Execute("insert into \"Koncert\"(\"KoncertID\", \"BendID\", grad, datum) values ('" + brojKoncerata.ToString() + "', '" + bendID + "', '" + grad + "', '" + datum + "')");
            return true;
        }

        #endregion  

        #region Menadzer

        public static void vratiBrojMenadzera()
        {
            ISession session = DataLayer.GetSession();


            if (session == null)
            {
                return;
            }
            else
            {

                var menadzerData = session.Execute("select * from \"Menadzer\"");
                brojMenadzera = menadzerData.GetRows().Count();
                brojMenadzera++;
            }
        }

        public static Menadzer VratiMenadzera(String BendID)
        {
            ISession session = DataLayer.GetSession();
            Menadzer menadzer = new Menadzer();


            if (session == null)
            {
                return null;
            }
            else
            {

                var menadzerData = session.Execute("select * from \"Menadzer\" where \"BendID\" = '" + BendID + "' allow filtering").FirstOrDefault();


                if (menadzerData != null)
                {
                    menadzer.BendID = menadzerData["BendID"] != null ? menadzerData["BendID"].ToString() : string.Empty;
                    menadzer.ime = menadzerData["ime"] != null ? menadzerData["ime"].ToString() : string.Empty;
                    menadzer.MenadzerID = menadzerData["MenadzerID"] != null ? menadzerData["MenadzerID"].ToString() : string.Empty;
                    menadzer.prezime = menadzerData["prezime"] != null ? menadzerData["prezime"].ToString() : string.Empty;
                    menadzer.brojtelefona = menadzerData["brojtelefona"] != null ? menadzerData["brojtelefona"].ToString() : string.Empty;
                    menadzer.email = menadzerData["email"] != null ? menadzerData["email"].ToString() : string.Empty;
                }
                return menadzer;

            }
        }

        public static bool dodajMenadzera(String ime, String prezime, String brojTelefona, String email, String bendID)
        {
            ISession session = DataLayer.GetSession();

            if (session == null)
                return false;
            vratiBrojMenadzera();
            RowSet menadzerData = session.Execute("insert into \"Menadzer\"(\"MenadzerID\", \"BendID\", ime, prezime, brojtelefona, email) values ('" + brojPevaca.ToString() + "', '" + bendID + "', '" + ime + "', '" + prezime + "', '" + brojTelefona + "', '"+email+"')");
            return true;
        }

        public static bool obrisiMenadzera(String MenadzerID)
        {
            ISession session = DataLayer.GetSession();

            if (session == null)
                return false;

            RowSet menadzer = session.Execute("delete from \"Menadzer\" where \"MenadzerID\" = '" + MenadzerID + "'");
            return true;
        }

        #endregion

        #region Pesma

        public static void vratiBrojPesama()
        {
            ISession session = DataLayer.GetSession();


            if (session == null)
            {
                return;
            }
            else
            {

                var pesmeData = session.Execute("select * from \"Pesma\"");
                brojPesama1 = pesmeData.GetRows().Count();
                brojPesama1++;
            }
        }

        public static void vratiBrojPesama(String albumID)
        {
            ISession session = DataLayer.GetSession();


            if (session == null)
            {
                return;
            }
            else
            {

                var pesmeData = session.Execute("select * from \"Pesma\" where \"AlbumID\" = '" + albumID+"' allow filtering ");
                brojPesama2 = pesmeData.GetRows().Count();
            }
        }
        
        public static List<Pesma> VratiPesme(String AlbumID)
        {
            ISession session = DataLayer.GetSession();
            List<Pesma> pesme = new List<Pesma>();


            if (session == null)
            {
                return null;
            }
            else
            {

                var pesmeData = session.Execute("select * from \"Pesma\" where \"AlbumID\" = '" + AlbumID + "' allow filtering");


                foreach (var pes in pesmeData)
                {
                    Pesma pesma = new Pesma();
                    pesma.PesmaID = pes["PesmaID"] != null ? pes["PesmaID"].ToString() : string.Empty;
                    pesma.AlbumID = pes["AlbumID"] != null ? pes["AlbumID"].ToString() : string.Empty;
                    pesma.naziv = pes["naziv"] != null ? pes["naziv"].ToString() : string.Empty;
                    pesma.datumizlaska = pes["datumizlaska"] != null ? pes["datumizlaska"].ToString() : string.Empty;
                    pesma.trajanje = pes["trajanje"] != null ? pes["trajanje"].ToString() : string.Empty;
                    pesme.Add(pesma);
                }

                return pesme;
            }

        }

        public static bool dodajPesmu(String naziv, String trajanje, String datum,String AlbumID)
        {
            ISession session = DataLayer.GetSession();

            if (session == null)
                return false;
            vratiBrojPesama();
            RowSet muzicarData = session.Execute("insert into \"Pesma\"(\"PesmaID\", \"AlbumID\", naziv, trajanje, datumizlaska) values ('" + brojPesama1.ToString() + "', '" + AlbumID + "', '" + naziv + "', '" + trajanje + "', '" + datum + "')");
            vratiBrojPesama(AlbumID);
            return true;
        }

        #endregion

    }
}
