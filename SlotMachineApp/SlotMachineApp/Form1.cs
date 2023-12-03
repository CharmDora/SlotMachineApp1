using System;
using System.Windows.Forms;

namespace SlotMachineApp
{
    partial class Form1 : Form
    {
        // Slot makinesi sembolleri (örneğin, harfler)
        private string[] symbols = { "A", "B", "C", "D", "E", "F" };

        // Rastgele sayı üretici
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            SpinSlotMachine();
        }

        private void SpinSlotMachine()
        {
            // Her Slotta rastgele bir sembol seç
            string symbol1 = GetRandomSymbol();
            string symbol2 = GetRandomSymbol();
            string symbol3 = GetRandomSymbol();

            // Slotlara sembolleri yerleştir
            lblSlot1.Text = symbol1;
            lblSlot2.Text = symbol2;
            lblSlot3.Text = symbol3;

            // Kazanıp kazanmadığını kontrol et
            CheckForWin(symbol1, symbol2, symbol3);
        }

        private string GetRandomSymbol()
        {
            // Rastgele bir sembol seç
            int index = random.Next(symbols.Length);
            return symbols[index];
        }

        private void CheckForWin(string symbol1, string symbol2, string symbol3)
        {
            // Üç sembol de aynıysa kazanmıştır
            if (symbol1 == symbol2 && symbol2 == symbol3)
            {
                MessageBox.Show("Tebrikler! Kazandınız!", "Slot Makinesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Üzgünüz, bu sefer kazanamadınız. Tekrar deneyin!", "Slot Makinesi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSpin_Click_1(object sender, EventArgs e)
        {
            SpinSlotMachine();
        }
    }
}
