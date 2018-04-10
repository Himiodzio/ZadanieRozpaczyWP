using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bazadanychcalosc
{
    public partial class Form1 : Form
    {
        #region Zmienne

        MySqlConnection polaczenie = new MySqlConnection("server=localhost; user=root; database=bazadanych");
        MySqlCommand komenda;
        MySqlDataReader czytnik;
        string zapytanie = "";
        List<Postac> listaPostaci = new List<Postac>();
        Postac wybranaPostac = null;

        #endregion Zmienne

        #region Konstruktory



        public Form1()
        {
            InitializeComponent();
        }

        #endregion Konstruktory

        #region Metody
        #region Ogólne

        private void Form1_Load(object sender, EventArgs e)
        {
            InicjalizacjaDanych();
        }

        private void lista_lisb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lista_lisb.SelectedIndex == -1)
                {
                    name_texb.Text = "";
                    age_numUD.Value = 0;
                    wybranaPostac = null;
                }
                else
                {
                    string[] tab = lista_lisb.Text.Split('.');
                    Postac p = listaPostaci.FirstOrDefault(x => x.Name.Equals(tab[1].Trim()));
                    wybranaPostac = p;

                    if (p != null)
                    {
                        name_texb.Text = p.Name;
                        age_numUD.Value = p.Age;
                    }
                }
            }
            catch (Exception ex)
            {
                string byk = string.Format("Problem podczas wybierania postaci:\n{0}", ex.Message);
                MessageBox.Show(byk, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void InicjalizacjaDanych()
        {
            try
            {
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                zapytanie = "select * from users";
                komenda = new MySqlCommand(zapytanie, polaczenie);
                czytnik = komenda.ExecuteReader();

                listaPostaci.Clear();
                lista_lisb.Items.Clear();
                int licznik = 1;

                if (czytnik.HasRows)
                {
                    while (czytnik.Read())
                    {
                        listaPostaci.Add(new Postac(czytnik.GetInt32("id"), czytnik["name"].ToString(), czytnik.GetInt32("age")));
                        lista_lisb.Items.Add(string.Format("{0}. {1}", licznik++, czytnik["name"].ToString()));
                    }
                }

            }
            catch (Exception ex)
            {
                string byk = string.Format("Problem podczas inicjalizacji danych:\n{0}", ex.Message);
                MessageBox.Show(byk, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();

                if (czytnik != null)
                {
                    czytnik.Dispose();
                    czytnik = null;
                }
            }
        }

        void WyczyscListe()
        {
            listaPostaci.Clear();
            lista_lisb.SelectedIndex = -1;
            lista_lisb.Items.Clear();
        }
        #endregion Ogólne

        private void pobierz_btn_Click(object sender, EventArgs e)
        {
            InicjalizacjaDanych();
        }

        private void aktualizuj_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int IndeksWybranejPostaci = lista_lisb.SelectedIndex;
                if (wybranaPostac != null)
                {
                    if (polaczenie.State == ConnectionState.Closed)
                        polaczenie.Open();

                    zapytanie = string.Format("update users set name = '{0}', age = {1} where id = {2}", name_texb.Text, age_numUD.Value, wybranaPostac.Id);
                    komenda = new MySqlCommand(zapytanie, polaczenie);
                    komenda.ExecuteNonQuery();

                    MessageBox.Show("Postać zaktualizowana.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InicjalizacjaDanych();
                    lista_lisb.SelectedIndex = IndeksWybranejPostaci;
                }
                else
                {
                    MessageBox.Show("Wybierz postać którą chcesz zaktualizować.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string byk = string.Format("", ex.Message);
                MessageBox.Show(byk, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wyczysc_btn_Click(object sender, EventArgs e)
        {
            WyczyscListe();
        }

        private void wyjscie_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion Metody

        private void dodaj_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //int IndeksWybranejPostaci = lista_lisb.SelectedIndex;
                //if (wybranaPostac == null)
                //{
                if (polaczenie.State == ConnectionState.Closed)
                    polaczenie.Open();

                zapytanie = string.Format("insert into users(name, age) values ('{0}', {1})", name_texb.Text, age_numUD.Value);
                komenda = new MySqlCommand(zapytanie, polaczenie);
                komenda.ExecuteNonQuery();

                MessageBox.Show("Postać dodana.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InicjalizacjaDanych();
                //    lista_lisb.SelectedIndex = IndeksWybranejPostaci;
                //}
                //else
                //{
                //    MessageBox.Show("Wybierz postać którą chcesz zaktualizować.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }
            catch (Exception ex)
            {
                string byk = string.Format("", ex.Message);
                MessageBox.Show(byk, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usun_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (lista_lisb.SelectedIndex != -1)
                {
                    if (polaczenie.State == ConnectionState.Closed)
                        polaczenie.Open();


                    int IndeksWybranejPostaci = lista_lisb.SelectedIndex;
                    if (wybranaPostac != null)
                    {
                        zapytanie = string.Format("delete from users where id = {0}", wybranaPostac.Id);
                        komenda = new MySqlCommand(zapytanie, polaczenie);
                        komenda.ExecuteNonQuery();

                        MessageBox.Show("Postać usunięta.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        InicjalizacjaDanych();

                    }
                }
                else
                {
                    MessageBox.Show("Wybierz postać którą chcesz usunąć.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                string byk = string.Format("Problem podczas usuwania postaci:\n{0}", ex.Message);
                MessageBox.Show(byk, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }
        }


      


    }
}