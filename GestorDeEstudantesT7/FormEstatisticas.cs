using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7
{
    public partial class FormEstatisticas : Form
    {
        public FormEstatisticas()
        {
            InitializeComponent();
        }

        Color corPainelTotal;
        Color corPainelMeninos;
        Color corPainelMeninas;


        private void FormEstatisticas_Load(object sender, EventArgs e)
        {
            corPainelTotal = panelTotalDeEstudantes.BackColor;
            corPainelMeninos = panelMeninos.BackColor;
            corPainelMeninas = panelMeninas.BackColor;

            //Exibir os valores (total geral, total de meninos, meninas e etc
            Estudante estudante = new Estudante();
            double totalEstudantes = Convert.ToDouble(estudante.totalDeEstudantes());
            double totalMeninos = Convert.ToDouble(estudante.totalDeEstudantesMeninos());
            double totalMeninas = Convert.ToDouble(estudante.totalDeEstudantesMeninas());

            double porcentagemDeMeninos
                = totalMeninos * 100 / totalEstudantes; 
            double porcentagemDeMeninas
                   = totalMeninas * 100 / totalEstudantes;

            labelTotalDeEstudantes.Text = "Total de Estudantes: "
                + totalEstudantes.ToString();
            
            labelMeninos.Text = "Total de Meninos: " 
                + porcentagemDeMeninos.ToString("0.00") + "%";

            labelMeninas.Text = "Total de Meninas: "
                + porcentagemDeMeninas.ToString("0.00") + "%";
        }

        private void labelTotalDeEstudantes_Click(object sender, EventArgs e)
        {
            panelTotalDeEstudantes.BackColor = Color.Black;
            labelTotalDeEstudantes.ForeColor = corPainelTotal;
        }

        private void labelTotalDeEstudantes_MouseLeave(object sender, EventArgs e)
        {
            panelTotalDeEstudantes.BackColor = corPainelTotal;
            labelTotalDeEstudantes.ForeColor = Color.Black;
        }

        private void labelTotalDeEstudantes_MouseEnter(object sender, EventArgs e)
        {
            panelTotalDeEstudantes.BackColor = Color.Black;
            labelTotalDeEstudantes.ForeColor = corPainelTotal;
        }

        private void labelMeninos_Click(object sender, EventArgs e)
        {
            panelMeninos.BackColor = Color.Black;
            labelMeninos.ForeColor = corPainelTotal;
        }

        private void labelMeninas_Click(object sender, EventArgs e)
        {
            panelMeninas.BackColor = Color.Black;
            labelMeninas.ForeColor = corPainelTotal;
        }

        private void labelTotalDeEstudantes_DoubleClick(object sender, EventArgs e)
        {

        }

        private void labelMeninas_MouseEnter(object sender, EventArgs e)
        {
            panelMeninas.BackColor = Color.Black;
            labelMeninas.ForeColor = corPainelTotal;
        }

        private void labelMeninas_MouseLeave(object sender, EventArgs e)
        {
            panelMeninas.BackColor = Color.Black;
            labelMeninas.ForeColor = corPainelTotal;
        }

        private void labelMeninos_MouseEnter(object sender, EventArgs e)
        {
            panelMeninos.BackColor = Color.Black;
            labelMeninos.ForeColor = corPainelTotal;
        }

        private void labelMeninos_MouseLeave(object sender, EventArgs e)
        {
            panelMeninos.BackColor = Color.Black;
            labelMeninos.ForeColor = corPainelTotal;
        }
    }
}
