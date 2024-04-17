using AC3___AlarconMarta;

namespace AC3___AlarconMarta
{
    public partial class Form1 : Form
    {
        private int lineaActual = 0;
        private List<Comarca> comarcas;

        public Form1()
        {
            InitializeComponent();
            LBLPoblacio.Text = "";
            LBLCM.Text = "";
            LBLCMA.Text = "";
            LBLCMB.Text = "";
            CargarDatosCSV();
            string rutaXML = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402 (1).xml";
            if (!File.Exists(rutaXML))
            {
                CreateXML();
            }
            ChargeComboBoxComarca();
            Cuadro.CellClick += DataGridView1_CellClick;

        }

        private void CargarDatosCSV()
        {

            string rutaArchivo = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402 (1).csv";
            comarcas = Helper.LlegirDadesCSV(rutaArchivo);
            MostrarSiguientes10Lineas();

        }

        private void CreateXML()
        {
            string rutaXML = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402 (1).xml";
            string rutaArchivo = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402 (1).csv";
            Helper.CrearXmlDesdeCsv(rutaArchivo, rutaXML);
        }

        private void ChargeComboBoxComarca()
        {
            string rutaXML = @"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402 (1).xml";
            Helper.CargarXmlEnComboBox(rutaXML, ComarcaText);


        }


        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                DataGridViewRow row = Cuadro.Rows[n];
                List<Comarca> comarcas = Helper.LlegirDadesCSV(@"..\..\..\Consum_d_aigua_a_Catalunya_per_comarques_20240402 (1).csv");

                int poblacio = Convert.ToInt32(row.Cells[3].Value);
                LBLPoblacio.Text = (poblacio > 20000) ? "SI" : "NO";

                string comarca = row.Cells[2].Value.ToString();
                var filterComarcasName = comarcas.Where(c => c.NomComarca == comarca);
                double consum = filterComarcasName.Average(c => c.ConsumDomesticPerCapita);
                LBLCM.Text = $"{consum:N0}";

                double consumDomesticPerCapita = Convert.ToDouble(row.Cells[7].Value);
                var filterComarcaALT = filterComarcasName.OrderByDescending(c => c.ConsumDomesticPerCapita).First();
                LBLCMA.Text = filterComarcaALT.ConsumDomesticPerCapita == consumDomesticPerCapita ? "SI" : "NO";

                var filterComarcaBAX = filterComarcasName.OrderByDescending(c => c.ConsumDomesticPerCapita).Last();
                LBLCMB.Text = filterComarcaBAX.ConsumDomesticPerCapita == consumDomesticPerCapita ? "SI" : "NO";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PoblacióText.Text = "";
            AnyText.Text = "";
            ComarcaText.Text = "";
            DomésticText.Text = "";
            ActivitatsText.Text = "";
            TotalText.Text = "";
            ConsumText.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                List<Comarca> comarques = new List<Comarca>() {
                    new Comarca
                    {
                        Any = Convert.ToInt32(AnyText.Text),
                        CodiComarca = Convert.ToInt32(ComarcaText.SelectedValue),
                        NomComarca = ComarcaText.Text,
                        Poblacio = Convert.ToInt32(PoblacióText.Text),
                        DomesticXarxa = Convert.ToInt32(DomésticText.Text),
                        ActivitatsEconomiques = Convert.ToInt32(ActivitatsText.Text),
                        Total = Convert.ToInt32(TotalText.Text),
                        ConsumDomesticPerCapita = Convert.ToDouble(ConsumText.Text)
                    }
                };

                Helper.AppendCsv(comarques);

                CargarDatosCSV();

            }
        }

        private void AnyText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(AnyText.Text))
            {
                e.Cancel = true;
                AnyText.Focus();
                Void.SetError(AnyText, "Slecciona un año");
            }
            else
            {
                e.Cancel = false;
                Void.SetError(AnyText, null);
            }
        }

        private void ComarcaText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(AnyText.Text))
            {
                e.Cancel = true;
                AnyText.Focus();
                Void.SetError(AnyText, "Selecciona una Comarca");
            }
            else
            {
                e.Cancel = false;
                Void.SetError(AnyText, null);
            }

        }

        private void PoblacióText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(PoblacióText.Text))
            {
                e.Cancel = true;
                PoblacióText.Focus();
                Void.SetError(PoblacióText, "Introduce una población");
            }
            else if (!int.TryParse(PoblacióText.Text, out int result))
            {
                e.Cancel = true;
                PoblacióText.Focus();
                Void.SetError(PoblacióText, "Introduce un número");
            }
            else if (int.Parse(PoblacióText.Text) < 0)
            {
                e.Cancel = true;
                PoblacióText.Focus();
                Void.SetError(PoblacióText, "Introduce un número positivo");
            }
            else
            {
                e.Cancel = false;
                Void.SetError(PoblacióText, null);
            }
        }

        private void DomésticText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(DomésticText.Text))
            {
                e.Cancel = true;
                DomésticText.Focus();
                Void.SetError(DomésticText, "Introduce un número");
            }
            else if (!int.TryParse(DomésticText.Text, out int result))
            {
                e.Cancel = true;
                DomésticText.Focus();
                Void.SetError(DomésticText, "Introduce un número");
            }
            else if (int.Parse(DomésticText.Text) < 0)
            {
                e.Cancel = true;
                DomésticText.Focus();
                Void.SetError(DomésticText, "Introduce un número positivo");
            }
            else
            {
                e.Cancel = false;
                Void.SetError(DomésticText, null);
            }
        }

        private void ActivitatsText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ActivitatsText.Text))
            {
                e.Cancel = true;
                ActivitatsText.Focus();
                Void.SetError(ActivitatsText, "Introduce un número");
            }
            else if (!int.TryParse(ActivitatsText.Text, out int result))
            {
                e.Cancel = true;
                ActivitatsText.Focus();
                Void.SetError(ActivitatsText, "Introduce un número");
            }
            else if (int.Parse(ActivitatsText.Text) < 0)
            {
                e.Cancel = true;
                ActivitatsText.Focus();
                Void.SetError(ActivitatsText, "Introduce un número positivo");
            }
            else
            {
                e.Cancel = false;
                Void.SetError(ActivitatsText, null);
            }
        }

        private void ConsumText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ConsumText.Text))
            {
                e.Cancel = true;
                ConsumText.Focus();
                Void.SetError(ConsumText, "Introduce un número");
            }
            else if (!double.TryParse(ConsumText.Text, out double result))
            {
                e.Cancel = true;
                ConsumText.Focus();
                Void.SetError(ConsumText, "Introduce un número");
            }
            else if (double.Parse(ConsumText.Text) < 0)
            {
                e.Cancel = true;
                ConsumText.Focus();
                Void.SetError(ConsumText, "Introduce un número positivo");
            }
            else
            {
                e.Cancel = false;
                Void.SetError(ConsumText, null);
            }
        }

        private void TotalText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TotalText.Text))
            {
                e.Cancel = true;
                TotalText.Focus();
                Void.SetError(TotalText, "Introduce un número");
            }
            else if (!int.TryParse(TotalText.Text, out int result))
            {
                e.Cancel = true;
                TotalText.Focus();
                Void.SetError(TotalText, "Introduce un número");
            }
            else if (int.Parse(TotalText.Text) < 0)
            {
                e.Cancel = true;
                TotalText.Focus();
                Void.SetError(TotalText, "Introduce un número positivo");
            }
            else
            {
                e.Cancel = false;
                Void.SetError(TotalText, null);
            }
        }

        private void MostrarSiguientes10Lineas()
        {
            int lineasAMostrar = 10;
            var lineasRestantes = comarcas.Skip(lineaActual).Take(lineasAMostrar).ToList();
            Cuadro.DataSource = lineasRestantes;
            Cuadro.Columns[1].Visible = false;
            lineaActual += lineasAMostrar;
        }


        private void BTNAfter_Click_1(object sender, EventArgs e)
        {
            if (lineaActual >= 10)
            {
                lineaActual -= 10;
                MostrarSiguientes10Lineas();
            }

        }

        private void BTNNext_Click_1(object sender, EventArgs e)
        {
            MostrarSiguientes10Lineas();
        }
    }
}
