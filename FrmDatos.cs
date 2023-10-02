namespace G16_medicamentos
{
    public partial class FrmDatos : Form
    {
        List<ClsLista> MiLista = new List<ClsLista>();
        public FrmDatos()
        {
            InitializeComponent();

            // Agregar algunas entradas a la lista antes de que se cargue el proyecto
            AgregarEntradasIniciales();

        }

        private void AgregarEntradasIniciales()
        //Medicamentos Precargados de ejemplo
        {
            ClsLista medicamento1 = new ClsLista();
            medicamento1.Codigo = "001";
            medicamento1.Nombre = "Panadol";
            medicamento1.Cantidad = "10";
            medicamento1.Precio = "5";
            medicamento1.MontoInvertido = 10 * 5;

            ClsLista medicamento2 = new ClsLista();
            medicamento2.Codigo = "002";
            medicamento2.Nombre = "Apronax";
            medicamento2.Cantidad = "20";
            medicamento2.Precio = "7.3";
            medicamento2.MontoInvertido = 20 * 7;

            ClsLista medicamento3 = new ClsLista();
            medicamento3.Codigo = "003";
            medicamento3.Nombre = "Vitamina C";
            medicamento3.Cantidad = "5";
            medicamento3.Precio = "10.5";
            medicamento3.MontoInvertido = 10.5f * 5;

            // Agregar los objetos a la lista
            MiLista.Add(medicamento1);
            MiLista.Add(medicamento2);
            MiLista.Add(medicamento3);

            // Actualizar el DataGridView
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = MiLista;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void tslBuscar_Click(object sender, EventArgs e)
        {

        }
        private void tslRegistrar_Click(object sender, EventArgs e)
        {

            if (ValidarCodigo() == false) { return; }
            if (ValidarNombre() == false) { return; }
            if (ValidarCantidad() == false) { return; }
            if (ValidarPrecio() == false) { return; }

            //Creamos el objeto G16_miMedicamento de la clase lists
            ClsLista G16_miMedicamento = new ClsLista();
            G16_miMedicamento.Codigo = textBox1.Text;
            G16_miMedicamento.Nombre = textBox2.Text;
            G16_miMedicamento.Cantidad = textBox3.Text;
            G16_miMedicamento.Precio = textBox4.Text;
            //Para operar numericamente las entradas creamos las variables G16_Cantidad,G16_Precio y G16_MontoInvertido
            float G16_Cantidad = int.Parse(textBox3.Text);
            float G16_Precio = float.Parse(textBox4.Text); ;
            float G16_MontoInvertido;
            G16_MontoInvertido = G16_Cantidad * G16_Precio;
            G16_miMedicamento.MontoInvertido = G16_MontoInvertido;
            MiLista.Add(G16_miMedicamento);
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = MiLista;
            LimpiarControles();
            textBox1.Focus();

        }

        private bool ValidarPrecio()//Validar el precio del medicamento "Debe ser un numero y no debe estar vacio"
        {
            float G16_ValidarPrecio;//Se crea variable int
            if (!float.TryParse(textBox4.Text, out G16_ValidarPrecio) || textBox4.Text == "")
            {
                erpError.SetError(textBox4, "Debe Ingresar un valor numerico para el precio");
                MessageBox.Show("Debe Ingresar un valor numerico para el precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else
                erpError.SetError(textBox4, "");
            return true;
        }

        private bool ValidarCantidad() //Validar la cantidad del medicamento "Debe ser un numero y no debe estar vacio"
        {
            int G16_cantidad;//Se crea variable int
            if (!int.TryParse(textBox3.Text, out G16_cantidad) || textBox3.Text == "")
            {
                erpError.SetError(textBox3, "Debe Ingresar un valor numerico para la cantidad");
                MessageBox.Show("Debe Ingresar un valor numerico para la cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); return false;
            }

            else
                erpError.SetError(textBox3, "");
            return true;
        }

        //Validar el Codigo del medicamento "No debe estar vacio"
        private bool ValidarCodigo()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {

                erpError.SetError(textBox1, "Debe ingresar el codigo");
                MessageBox.Show("Debe Ingresar un codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                erpError.SetError(textBox1, "");
                return true;
            }
        }

        //Validar el nombre del medicamento "No debe estar vacio"
        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {

                erpError.SetError(textBox2, "Debe ingresar el nombre");
                MessageBox.Show("Debe Ingresar el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                erpError.SetError(textBox2, "");
                return true;
            }
        }
        private void LimpiarControles()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tlsBuscar_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false)
            {
                return;
            }//Creamos em metodo G16_GetMedicamento
            ClsLista G16_miMedicamento = G16_GetMedicamento(textBox2.Text);
            if (G16_miMedicamento == null)
            {
                erpError.SetError(textBox2, "El medicamento no está registrado en la lista");
                MessageBox.Show("Nombre no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControles();
                textBox1.Focus();
                return;

            }
            else
            {
                erpError.SetError(textBox1, "");
                textBox1.Text = G16_miMedicamento.Codigo;
                textBox2.Text = G16_miMedicamento.Nombre;
                textBox3.Text = G16_miMedicamento.Cantidad.ToString();
                textBox4.Text = G16_miMedicamento.Precio.ToString();
                MessageBox.Show("Nombre encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        //Metodo obtener o consultar medicamento
        private ClsLista G16_GetMedicamento(string nombre)
        {
            return MiLista.Find(medicamento => medicamento.Nombre == nombre);
        }

        private void tlsEliminar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                erpError.SetError(textBox1, "Debe consultar el codigo a eliminar");
                LimpiarControles();
                textBox1.Focus();

                return;
            }
            else
            {
                erpError.SetError(textBox1, "");
                DialogResult Respuesta = MessageBox.Show("Está seguro de elimnar el registro?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Respuesta == DialogResult.Yes)
                {
                    foreach (ClsLista G16_miMedicamento in MiLista)
                    {
                        if (G16_miMedicamento.Codigo == textBox1.Text)
                        {
                            MiLista.Remove(G16_miMedicamento);
                            break;
                        }
                    }
                    LimpiarControles();
                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = MiLista;
                }


            }
        }

        private void tslOrdenar_Click(object sender, EventArgs e)
        {
            // Ordenar la lista MiLista por el campo Nombre
            MiLista = MiLista.OrderBy(medicamento => medicamento.Nombre).ToList();

            // Actualizar el DataGridView con la lista ordenada
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = MiLista;
            //Ornda alfabeticamente
            MessageBox.Show("Lista Ordenada Alfabeticamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {

            // Ordenar la lista MiLista por el campo Nombre
            MiLista = MiLista.OrderBy(medicamento => medicamento.Nombre).ToList();

            // Actualizar el DataGridView con la lista ordenada
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = MiLista;
            //Ornda alfabeticamente
            MessageBox.Show("Funcionamiento:\n \nAgregar: Deben estar todos los campos llenos, cantidad y precio deben ser numeros. Precio puede ser un decimal.\n \nBuscar: Se debe buscar un medicamento utilizando su nombre completo y respetando las mayusculas.\n \nEliminar: Elimina un elemento siempre y cuando se proporcione su codigo.\n \nOrdenar: Ordena los elementos en la tabla de forma alfabetica por su Nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tlsBuscar_Click_1(object sender, EventArgs e)
        {

            if (ValidarNombre() == false)
            {
                return;
            }//Creamos em metodo G16_GetMedicamento
            ClsLista G16_miMedicamento = G16_GetMedicamento(textBox2.Text);
            if (G16_miMedicamento == null)
            {
                erpError.SetError(textBox2, "El medicamento no está registrado en la lista");
                MessageBox.Show("Nombre no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControles();
                textBox1.Focus();
                return;

            }
            else
            {
                erpError.SetError(textBox1, "");
                textBox1.Text = G16_miMedicamento.Codigo;
                textBox2.Text = G16_miMedicamento.Nombre;
                textBox3.Text = G16_miMedicamento.Cantidad.ToString();
                textBox4.Text = G16_miMedicamento.Precio.ToString();
                MessageBox.Show("Nombre encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void tlsEliminar_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                erpError.SetError(textBox1, "Debe consultar el codigo a eliminar");
                MessageBox.Show("Debe consultar el codigo a eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControles();
                textBox1.Focus();

                return;
            }
            else
            {
                erpError.SetError(textBox1, "");
                DialogResult Respuesta = MessageBox.Show("Está seguro de elimnar el registro?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Respuesta == DialogResult.Yes)
                {
                    foreach (ClsLista G16_miMedicamento in MiLista)
                    {
                        if (G16_miMedicamento.Codigo == textBox1.Text)
                        {
                            MiLista.Remove(G16_miMedicamento);
                            break;
                        }
                    }
                    LimpiarControles();
                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = MiLista;
                }


            }
        }

        private void tslOrdenar_Click_1(object sender, EventArgs e)
        {

            // Ordenar la lista MiLista por el campo Nombre
            MiLista = MiLista.OrderBy(medicamento => medicamento.Nombre).ToList();

            // Actualizar el DataGridView con la lista ordenada
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = MiLista;
            //Ornda alfabeticamente
            MessageBox.Show("Lista Ordenada Alfabeticamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tslSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}