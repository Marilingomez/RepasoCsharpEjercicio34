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

                    MessageBox.Show("Por favor, ingrese un n�mero v�lido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnumero.Clear(); 
                    txtnumero.Focus(); 
                    return; 
                }
            } while (true); 
            MessageBox.Show($"N�mero v�lido ingresado: {numero}", "N�mero v�lido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }

