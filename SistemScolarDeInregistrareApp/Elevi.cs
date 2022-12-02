using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemScolarDeInregistrareApp
{
    public partial class FrmElevi : MaterialSkin.Controls.MaterialForm
    {
        SqlDataAdapter dataAdpt;
        DataTable dt;
        SqlCommand cmd;
        Conectare conectare = new Conectare();

        public FrmElevi()
        {
            InitializeComponent();
            AfisareJudetelsd();
            Clase();
            btnActualizare.Enabled = false;
            btnStergere.Enabled = false;
        }

        public void AfisareJudetelsd()
        {
            dataAdpt = new SqlDataAdapter("select * from Judet", conectare.DeschidereConectare());
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmbJudet.DataSource = dt;
            cmbJudet.DisplayMember = "numeJudet";
            cmbJudet.ValueMember = "judetID";

            conectare.InchidereConectare();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbJudet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valoare;

            try
            {
                int.TryParse(cmbJudet.SelectedValue.ToString(), out valoare);
                dataAdpt = new SqlDataAdapter("select * from Municipiu where judetID='" + 
                    valoare + "'" , conectare.DeschidereConectare());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cbmMunicipiu.DataSource = dt;
                cbmMunicipiu.DisplayMember = "numeMunicipiu";
                cbmMunicipiu.ValueMember = "municipiuID";
            }
            catch (Exception)
            {

            }

            conectare.InchidereConectare();
        }

        private void cbmMunicipiu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valoare;

            try
            {
                int.TryParse(cbmMunicipiu.SelectedValue.ToString(), out valoare);
                dataAdpt = new SqlDataAdapter("select * from Oras where municipiuID='" +
                    valoare + "'", conectare.DeschidereConectare());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmbOras.DataSource = dt;
                cmbOras.DisplayMember = "numeOras";
                cmbOras.ValueMember = "orasID";
            }
            catch (Exception)
            {

            }

            conectare.InchidereConectare();
        }

        public void Clase()
        {
            try
            {
                dataAdpt = new SqlDataAdapter("select * from Clase", conectare.DeschidereConectare());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmbClasa.DataSource = dt;
                cmbClasa.DisplayMember = "numeClasa";
                cmbClasa.ValueMember = "clasaID";
            }
            catch (Exception)
            {

            }

            conectare.InchidereConectare();
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            int clasaID = Convert.ToInt32(cmbClasa.SelectedValue);
            int judetID = Convert.ToInt32(cmbJudet.SelectedValue);
            int municipiuID = Convert.ToInt32(cbmMunicipiu.SelectedValue);
            int orasID = Convert.ToInt32(cmbOras.SelectedValue);

            try
            {
                string sex = "Feminin";

                if (rdMasculin.Checked)
                {
                    sex = "Masculin";
                }

                if (txtNume.Text != "" && txtPrenume.Text != "" && txtAdresa.Text != "" 
                    && txtTelefon.Text != "" && txtEmail.Text != "" && cmbJudet.Text != "" 
                    && cbmMunicipiu.Text != "" && cmbOras.Text != "")
                {
        
 cmd = new SqlCommand(" INSERT INTO[dbo].[Elevi]([sex],[nume],[prenume],[adresa],[telefon],[email],[dataNasterii],[dataInregistrarii],[judetID],[municipiuID],[orasID],[clasaID])VALUES('" 
                    + sex + "', '" + txtNume.Text + "', '" +
                        txtPrenume.Text + "','" + txtAdresa.Text + "','" + txtTelefon.Text + "', '" +
                        txtEmail.Text + "', '" + dtDataNasterii.Text + "','" + dtDataInregistrarii.Text +
                        "', '" + judetID  + "','" + municipiuID + "','" + orasID + "', '" + clasaID  +
                        "')", conectare.DeschidereConectare());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost salvate");
                    /*
                    cmd = new SqlCommand("insert into Elevi values('"+sex+ "', '" + txtNume.Text + "', '" + 
                        txtPrenume.Text + "','"+ txtAdresa.Text + "','" + txtTelefon.Text + "', '" + 
                        txtEmail.Text +"', '" + dtDataNasterii.Text + "','" + dtDataInregistrarii.Text +
                        "', '" + clasaID + "','" + judetID + "','" + municipiuID + "', '" + orasID + 
                        "')", conectare.DeschidereConectare());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost salvate");
                    */


                }
                else
                {
                    MessageBox.Show("Va rog completati toate campurile");
                }

                conectare.InchidereConectare();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            cmbClasa.Text = "";
            txtNume.Clear();
            txtPrenume.Clear();
            txtAdresa.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            cmbJudet.Text = "";
            cmbOras.Text = "";
            cbmMunicipiu.Text = "";
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            FrmAfisareDateElevi elevi = new FrmAfisareDateElevi();
            elevi.Show();
            Hide();
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            string sex = "";

            if (rdMasculin.Checked)
            {
                sex = "Masculin";
            }
            else
            {
                sex = "Feminin";
            }

            try
            {

                string DN = dtDataNasterii.Value.ToString("dd-MM-yyyy");
                string DI = dtDataInregistrarii.Value.ToString("dd-MM-yyyy");
                int judetID = Convert.ToInt32(cmbJudet.SelectedValue);
                int municipiuID = Convert.ToInt32(cbmMunicipiu.SelectedValue);
                int orasID = Convert.ToInt32(cmbOras.SelectedValue);
                int clasaID = Convert.ToInt32(cmbClasa.SelectedValue);

                if (txtNume.Text != "" && txtPrenume.Text != "" && txtAdresa.Text != ""
                    && txtTelefon.Text != "" && txtEmail.Text != "" && cmbJudet.Text != ""
                    && cbmMunicipiu.Text != "" && cmbOras.Text != "")
                {
                    cmd = new SqlCommand("update elevi set sex='" + sex + "',nume='" + txtNume.Text +
                        "',prenume='" + txtPrenume.Text + "', adresa='" + txtAdresa.Text + "', telefon='" + txtTelefon.Text + "', email='" + txtEmail.Text +
                        "',dataNasterii='" + DN + "', dataInregistrarii='" + DI + "',clasaID='" + clasaID + "',judetID='" +
                        judetID + "',municipiuID='" + municipiuID + "', orasID='" + orasID +
                        "' where EleviID='" + FrmAfisareDateElevi.elevID + "'", conectare.DeschidereConectare());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Datele au fost actualizate cu succes! ");
                }
                else
                {
                    MessageBox.Show(" Te rog completeaza randurile goale");
                }

                conectare.InchidereConectare();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("delete from elevi where eleviID = '" + FrmAfisareDateElevi.elevID + "'", conectare.DeschidereConectare());
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Datele au fost sterse cu succes! ");
                
                conectare.InchidereConectare();
            }
            catch (Exception)
            {

            }

            
        }

        private void cmbClasa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
