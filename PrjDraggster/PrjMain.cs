using System.Diagnostics;
using System.Text.Json;

namespace PrjDraggster
{
    public partial class PrjMain : Form
    {

        bool acelerando = false;
        float velocidade = 0f;
        int marcha = 1;
        float rpm = 0f;
        float tempo = 0f;
        System.Windows.Forms.Timer timer;
        Stopwatch cronometro = new Stopwatch();

        public class TempoRecorde
        {
            public string Nome { get; set; } = "Anônimo";
            public float Tempo { get; set; }
        }

        List<TempoRecorde> placar = new List<TempoRecorde>();
        string caminhoArquivo = "placar.json";


        public PrjMain()
        {
            InitializeComponent();

            this.KeyPreview = true;

            this.KeyDown += PrjMain_KeyDown;
            this.KeyUp += PrjMain_KeyUp;

            lblRPMBarFill.Width = 0;

            if (File.Exists(caminhoArquivo))
            {
                string json = File.ReadAllText(caminhoArquivo);
                placar = JsonSerializer.Deserialize<List<TempoRecorde>>(json) ?? new List<TempoRecorde>();
            }

        }

        private void PrjMain_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 50; // 20 updates por segundo
            timer.Tick += Timer_Tick;
        }

        private string PromptNome()
        {
            string nome = Microsoft.VisualBasic.Interaction.InputBox("Digite seu nome:", "Novo Recorde", "Anônimo");
            return string.IsNullOrWhiteSpace(nome) ? "Anônimo" : nome;
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            if (rpm < 7f)
                lblRPMBarFill.BackColor = Color.LimeGreen;
            else if (rpm < 9f)
                lblRPMBarFill.BackColor = Color.Gold;
            else
                lblRPMBarFill.BackColor = Color.Red;

            if (acelerando)
            {
                rpm += 1f / marcha; // Simula RPM subindo
                velocidade += 0.1f * marcha;

                if (rpm > 10f)
                {
                    rpm = 10f; // Limita para não passar do visual
                    AtualizarRPMBarra(); // Atualiza visual antes de resetar
                    timer.Stop();
                    MessageBox.Show("Motor explodiu! 😵", "Game Over");
                    Resetar();
                    return;
                }
            }

        
            else
            {
                rpm -= 0.5f;
                if (rpm < 0) rpm = 0;
            }

            tempo = (float)cronometro.Elapsed.TotalSeconds;

            // Mover o carro (simplificado)
            pnlCar1.Left += (int)(velocidade);

            if (pnlCar1.Left >= this.Width - pnlCar1.Width - 50)
            {
                timer.Stop();
                cronometro.Stop();
                bool novoRecorde = false;

                // Verifica se é um dos 5 melhores tempos
                if (placar.Count < 5 || tempo < placar.Max(r => r.Tempo))
                {
                    string nome = PromptNome();
                    placar.Add(new TempoRecorde { Nome = nome, Tempo = tempo });
                    placar = placar.OrderBy(r => r.Tempo).Take(5).ToList();

                    File.WriteAllText(caminhoArquivo, JsonSerializer.Serialize(placar, new JsonSerializerOptions { WriteIndented = true }));
                    novoRecorde = true;
                }

                if (novoRecorde)
                {
                    string ranking = string.Join("\n", placar.Select((r, i) => $"{i + 1}º - {r.Nome}: {r.Tempo:F2}s"));
                    MessageBox.Show($"🏁 Novo recorde!\n\n{ranking}", "Placar");
                }
                else
                {
                    MessageBox.Show($"🏁 Finalizado em {tempo:F2} segundos!");
                }

                Resetar();
            }

            // Atualizar UI
            lblRPM.Text = $"RPM: {rpm:F1}";
            lblVelocidade.Text = $"Velocidade: {velocidade:F1}";
            lblMarcha.Text = $"Marcha: {marcha}";
            lblTempo.Text = $"Tempo: {tempo:F2}";
        }

        private void AtualizarRPMBarra()
        {
            int maxWidth = lblRPMBarBack.Width;
            int fillWidth = (int)(Math.Min(rpm / 10f, 1f) * maxWidth);
            lblRPMBarFill.Width = fillWidth;

            if (rpm < 7f)
                lblRPMBarFill.BackColor = Color.LimeGreen;
            else if (rpm < 9f)
                lblRPMBarFill.BackColor = Color.Gold;
            else
                lblRPMBarFill.BackColor = Color.Red;
        }


        private void btnAccelerate_MouseDown(object sender, MouseEventArgs e)
        {
            acelerando = true;
            if (!timer.Enabled)
            {
                cronometro.Restart();
                timer.Start();
            }
        }

        private void btnAccelerate_MouseUp(object sender, MouseEventArgs e)
        {
            acelerando = false;
        }


        private void Resetar()
        {
            acelerando = false;
            velocidade = 0;
            marcha = 1;
            rpm = 0;
            tempo = 0;
            pnlCar1.Left = 10;
            lblRPM.Text = "RPM: 0";
            lblVelocidade.Text = "Velocidade: 0";
            lblMarcha.Text = "Marcha: 1";
            lblTempo.Text = "Tempo: 0";
            cronometro.Reset();
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {

        }

        private void btnMarcha_Click(object sender, EventArgs e)
        {
            if (rpm >= 2f)
            {
                marcha++;
                rpm = rpm / 2;
                if (marcha > 5)
                    marcha = 5;
            }
        }

        private void PrjMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                acelerando = true;
                if (!timer.Enabled)
                {
                    cronometro.Restart();
                    timer.Start();
                }
            }

            if (e.KeyCode == Keys.C)
            {
                if (rpm >= 2f)
                {
                    marcha++;
                    rpm = rpm / 2;
                    if (marcha > 5)
                        marcha = 5;
                }
            }
        }

        private void PrjMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                acelerando = false;
            }
        }


    }
}
