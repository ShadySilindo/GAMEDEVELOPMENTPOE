using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Gade6122_Part1_corrected
{
    [System.Serializable]
    public partial class Form1 : Form
    {
        GameEngine gameEngine;
        Enemy enemy;
        Leader leader;
        Shop Shop;
        public Form1()
        {
            this.KeyPreview = true;
            InitializeComponent();
            gameEngine = new GameEngine();
            lblMap.Text = gameEngine.Display;
            UpdateDisplay();
            this.Focus();
        }

        private void lblMap_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            CheckMove(e.KeyCode);
            CheckAttack(e.KeyCode);
            //lblAttackInfo.Text = "";
            UpdateDisplay();
        }
        private void CheckMove(Keys keyCode)
        {
            Debug.WriteLine(keyCode);
            if (keyCode == Keys.W)
            {
                gameEngine.MovePlayer(Movement.Up);
            }
            else if (keyCode == Keys.S)
            {
                gameEngine.MovePlayer(Movement.Down);
            }
            else if (keyCode == Keys.D)
            {
                gameEngine.MovePlayer(Movement.Right);
            }
            else if (keyCode == Keys.A)
            {
                gameEngine.MovePlayer(Movement.Left);
            }
            
        }
        private void CheckAttack(Keys keyCode)
        {
            string attackInfo = "";
            Debug.WriteLine(keyCode);
            if (keyCode == Keys.I)
            {
                attackInfo = gameEngine.PlayerAttack(Movement.Up);
            }
            else if (keyCode == Keys.K)
            {
                attackInfo = gameEngine.PlayerAttack(Movement.Down);
            }
            else if (keyCode == Keys.L)
            {
                attackInfo = gameEngine.PlayerAttack(Movement.Right);
            }
            else if (keyCode == Keys.J)
            {
                attackInfo = gameEngine.PlayerAttack(Movement.Left);
            }
            if (attackInfo != "")
            {
                lblAttackInfo.Text = attackInfo;
            }
        }

        private void lblAttackInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblHeroStats_Click(object sender, EventArgs e)
        {

        }
        private void UpdateDisplay()
        {
            lblHeroStats.Text = gameEngine.HeroStats;
            lblMap.Text = gameEngine.Display;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            gameEngine.Save();
            this.Focus();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            gameEngine.Load();
            this.Focus();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
