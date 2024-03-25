namespace Prova2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IniciaLista();

        }



        /*===================================== LISTVIEW ============================================*/
        private void IniciaLista()
        {
            listView1.Columns.Add("Placa", 120).TextAlign = HorizontalAlignment.Left;
            listView1.Columns.Add("Ano", 120).TextAlign = HorizontalAlignment.Left;
            listView1.Columns.Add("Assentos", 120).TextAlign = HorizontalAlignment.Left;
            listView1.Columns.Add("Eixos", 120).TextAlign = HorizontalAlignment.Left;
            listView1.Columns.Add("Diária", 120).TextAlign = HorizontalAlignment.Left;
            listView1.View = View.Details;
        }


        /*=================================== Radio Butons ===========================================*/
        private void RB_onibus_CheckedChanged(object sender, EventArgs e)
        {
            lb_assentos.Text = "Qtd Assentos";
            mtb_placa.Mask = "LLL-0000";
            pic_imagem.ImageLocation = "https://i.pinimg.com/474x/9a/b3/9d/9ab39d426efd9948a1b203e75b6e0ee0.jpg";
        }

        private void RB_caminhao_CheckedChanged(object sender, EventArgs e)
        {
            lb_assentos.Text = "Qtd Eixos";
            mtb_placa.Mask = "LLL-0000";
            pic_imagem.ImageLocation = "https://www.revistacaminhoneiro.com.br/uploads/img/noticias/5528/thumb-300-230/10bed2395319de8ee897352c0f9c8929.jpg";
        }


        /*================================== Botão Cadastrar =========================================*/
        private void B_cadastrar_Click(object sender, EventArgs e)
        {
            bool check = checktext();

            /* Se caminhão estiver selecionado e os campos preenhidos corretamente: */
            if (RB_caminhao.Checked == true && check == true)
            {
                checktext(); //Verifica se as text box estão com informação

                Caminhao cam = new Caminhao(mtb_placa.Text, Convert.ToInt32(mtb_ano.Text),
                                        Convert.ToInt32(mtb_assentos.Text));


                /* Cria uma lista com informações do veículo a ser adicionado */
                string[] veiculo_cam = new string[5];
                veiculo_cam[0] = cam.Placa;
                veiculo_cam[1] = Convert.ToString(cam.Ano);
                veiculo_cam[2] = string.Empty;
                veiculo_cam[3] = Convert.ToString(cam.Eixos);
                veiculo_cam[4] = Convert.ToString(cam.Alugar());

                listView1.Items.Add(new ListViewItem(veiculo_cam)); //Adiciona no ListView
                clear();
                MensagemCadastro(cam.Alugar());

            }

            /* Se ônibus estiver selecionado e os campos preenhidos corretamente: */
            else if (RB_onibus.Checked == true && check == true)
            {
                checktext(); //Verifica se as text box estão com informação

                Onibus bus = new Onibus(mtb_placa.Text, Convert.ToInt32(mtb_ano.Text),
                                        Convert.ToInt32(mtb_assentos.Text));


                /* Cria uma lista com informações do veículo a ser adicionado */
                string[] veiculo_bus = new string[5];
                veiculo_bus[0] = bus.Placa;
                veiculo_bus[1] = Convert.ToString(bus.Ano);
                veiculo_bus[2] = Convert.ToString(bus.Assentos);
                veiculo_bus[3] = string.Empty;
                veiculo_bus[4] = "R$ " + Convert.ToString(bus.Alugar());

                listView1.Items.Add(new ListViewItem(veiculo_bus));//Adiciona no ListView
                clear();
                MensagemCadastro(bus.Alugar());
            }
        }

        /*==================================== Botão Limpar ==========================================*/
        private void B_limpar_Click(object sender, EventArgs e)
        {
            clear();
        }

        /*================================ Funções Secundárias =======================================*/
        void clear()
        {
            mtb_placa.Text = string.Empty;
            mtb_ano.Text = string.Empty;
            mtb_assentos.Text = string.Empty;
        }

        private void MensagemErro(string label)
        {
            MessageBox.Show("Você deve preencher o campo: " + label);
        }

        private void MensagemCadastro(double aluguel)
        {
            MessageBox.Show("O valor diário do aluguel será de: " + aluguel);
        }

        private bool checktext()
        {
            bool verify = true;

            if (mtb_placa.MaskCompleted == false)
            {
                MensagemErro(lb_placa.Text);
                verify = false;
            }

            else if (mtb_ano.Text.Trim() == string.Empty)
            {
                MensagemErro(lb_ano.Text);
                verify = false;
            }

            else if (mtb_assentos.Text.Trim() == string.Empty)
            {
                MensagemErro(lb_assentos.Text);
                verify = false;
            }

            return verify;
        }
    }
}
