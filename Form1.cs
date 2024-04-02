namespace RepasoCsharpEjercicio34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
          
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            int numero;
            
             
                do
            {
                
                if (int.TryParse(txtnumero.Text, out numero))
                {
                    
                    break;
                }
                else
                {

                    MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnumero.Clear(); 
                    txtnumero.Focus(); 
                    return; 
                }
            } while (true); 
            MessageBox.Show($"Número válido ingresado: {numero}", "Número válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }

