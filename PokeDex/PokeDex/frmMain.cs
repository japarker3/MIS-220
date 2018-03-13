using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeDex
{
    // MIS-220-002
    // Jon-Alec Parker
    public partial class frmMain : Form
    {
        const int pokeDexSize = 10;
        string[] _pokemonName = new string[pokeDexSize];
        int[] _hp = new int[pokeDexSize];
        string[] _pokemonType = new string[pokeDexSize];
        double[] _weight = new double[pokeDexSize];
        double[] _height = new double[pokeDexSize];
        int numOfPokemon = 0;
        string currentSort = "name";

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            FillData();
            DisplayData();
        }

        public void FillData()
        {
            _pokemonName[numOfPokemon] = "Pikachu";
            _hp[numOfPokemon] = 1;
            _pokemonType[numOfPokemon] = "Electric";
            _weight[numOfPokemon] = 55.4;
            _height[numOfPokemon] = 4.3;
            numOfPokemon++;

            _pokemonName[numOfPokemon] = "Zendryu";
            _hp[numOfPokemon] = 13;
            _pokemonType[numOfPokemon] = "Fairy";
            _weight[numOfPokemon] = 0.002;
            _height[numOfPokemon] = 1000;
            numOfPokemon++;

            _pokemonName[numOfPokemon] = "Charizard";
            _hp[numOfPokemon] = 2;
            _pokemonType[numOfPokemon] = "Fire";
            _weight[numOfPokemon] = 130;
            _height[numOfPokemon] = 8.3;
            numOfPokemon++;

            _pokemonName[numOfPokemon] = "Aligator";
            _hp[numOfPokemon] = 3;
            _pokemonType[numOfPokemon] = "Water";
            _weight[numOfPokemon] = 45;
            _height[numOfPokemon] = 9.7;
            numOfPokemon++;
        }

        public void DisplayData()
        {
            txtDisplay.Clear();
            txtDisplay.AppendText("--PokeDex--" + Environment.NewLine);
            txtDisplay.AppendText("(Sorted by " + currentSort + ")" + Environment.NewLine);

            for (int i = 0; i < numOfPokemon; i++)
            {
                txtDisplay.AppendText("Pokemon[" + (i+1) + "]: " + _pokemonName[i] + Environment.NewLine);
                txtDisplay.AppendText("HP: " + _hp[i] + Environment.NewLine);
                txtDisplay.AppendText("Type: " + _pokemonType[i] + Environment.NewLine);
                txtDisplay.AppendText("Weight: " + _weight[i] + Environment.NewLine);
                txtDisplay.AppendText("Height: " + _height[i] + Environment.NewLine);
                txtDisplay.AppendText(Environment.NewLine);
            }

            lblPokeDexSize.Text = (numOfPokemon+1) + " of 10 Pokemon";

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            btnDisplay.Enabled = false;

            DisplayData();

            btnDisplay.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnDisplay.Enabled = false;

            if (!CheckForValidInput())
            {
                return;
            }

            if (numOfPokemon < 9)
            {
                numOfPokemon++;
                _pokemonName[numOfPokemon] = txtName.Text.ToString();
                _hp[numOfPokemon] = int.Parse(txtHp.Text);
                _pokemonType[numOfPokemon] = cbType.Text.ToString();
                _weight[numOfPokemon] = double.Parse(txtWeight.Text);
                _height[numOfPokemon] = double.Parse(txtHeight.Text);

                DisplayData();
            }
            ClearControls();

            btnDisplay.Enabled = true;
        }

        private void ClearControls()
        {
            txtName.Clear();
            txtHp.Clear();
            //cbType.Clear();
            txtWeight.Clear();
            txtHeight.Clear();
        }

        private bool CheckForValidInput()
        {
            // Test valid input for name - any letter shorter than 50 chars
            if (txtName.Text.Length > 2)
            {
                MessageBox.Show("Please enter a shorter name.", "Invlaid Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Clear();
                return false;
            }

            // Test valid input for hp - any positive int
            try
            {
                int num = int.Parse(txtHp.Text);
                if (num <= 0) {
                    MessageBox.Show("Please enter a positive number.", "Invalid HP",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHp.Clear();
                    return false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter numbers only.", "Invalid HP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHp.Clear();
                return false;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please enter a lower number", "Invalid HP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHp.Clear();
                return false;
            }

            // Type will always be valid

            // Test Valid input for Weight


            // Test valid input for height


            return true;
        }

        public void SortPokemon(string sortBy)
        {
            switch (sortBy)
            {
                case "name":
                    currentSort = "Name";
                    Array.Sort(_pokemonName.ToArray(), _hp, 0, numOfPokemon);
                    Array.Sort(_pokemonName.ToArray(), _pokemonType, 0, numOfPokemon);
                    Array.Sort(_pokemonName.ToArray(), _weight, 0, numOfPokemon);
                    Array.Sort(_pokemonName, _height, 0, numOfPokemon);
                    break;
                case "hp":
                    currentSort = "HP";
                    Array.Sort(_hp.ToArray(), _pokemonName, 0, numOfPokemon);
                    Array.Sort(_hp.ToArray(), _pokemonType, 0, numOfPokemon);
                    Array.Sort(_hp.ToArray(), _weight, 0, numOfPokemon);
                    Array.Sort(_hp, _height, 0, numOfPokemon);
                    break;
                case "type":
                    currentSort = "Type";
                    Array.Sort(_pokemonType.ToArray(), _pokemonName, 0, numOfPokemon);
                    Array.Sort(_pokemonType.ToArray(), _hp, 0, numOfPokemon);
                    Array.Sort(_pokemonType.ToArray(), _weight, 0, numOfPokemon);
                    Array.Sort(_pokemonType, _height, 0, numOfPokemon);
                    break;
                case "weight":
                    currentSort = "Weight";
                    Array.Sort(_weight.ToArray(), _pokemonName, 0, numOfPokemon);
                    Array.Sort(_weight.ToArray(), _hp, 0, numOfPokemon);
                    Array.Sort(_weight.ToArray(), _pokemonType, 0, numOfPokemon);
                    Array.Sort(_weight, _height, 0, numOfPokemon);
                    break;
                case "height":
                    currentSort = "Height";
                    Array.Sort(_height.ToArray(), _pokemonName, 0, numOfPokemon);
                    Array.Sort(_height.ToArray(), _hp, 0, numOfPokemon);
                    Array.Sort(_height.ToArray(), _pokemonType, 0, numOfPokemon);
                    Array.Sort(_height, _weight, 0, numOfPokemon);
                    break;
            }
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            SortPokemon("name");
        }

        private void btnSortHp_Click(object sender, EventArgs e)
        {
            SortPokemon("hp");
        }

        private void btnSortType_Click(object sender, EventArgs e)
        {
            SortPokemon("type");
        }

        private void btnSortWeight_Click(object sender, EventArgs e)
        {
            SortPokemon("weight");

        }

        private void btnSortHeight_Click(object sender, EventArgs e)
        {
            SortPokemon("height");

        }
    }
}
