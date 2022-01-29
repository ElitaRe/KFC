using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFC_management1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double fingersp = 4.0, burgerp = 2.5, twisterp = 2.0, tacop = 2.0, popcornp = 2.0, friesp= 2.0, qurritop = 2.5;
        double cokep = 1.0, spritep = 1.0, chocoshakep = 1.5, cherryshakep = 1.5, donutp = 1.0, icecreamp = 2.0, cookiesp = 0.8;
        double fingerstp, burgertp, twistertp, tacotp, popcorntp, friestp, qurritotp, coketp, spritetp, chocoshaketp, cherryshaketp, donuttp, icecreamtp, cookiestp,tax,total;

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(receiptTextbox.Text + " Subtotal: " + subTotallbl.Text + "; VAT: " + vatlbl.Text + "; Total: " + totallbl.Text, new Font("Century Gothic", 17, FontStyle.Regular), Brushes.Blue, new Point(130));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        double subtotal = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            fingersCheck.Checked = false;
            burgerCheck.Checked = false;
            twisterCheck.Checked = false;
            tacoCheck.Checked = false;
            popcornCheck.Checked = false;
            friesCHeck.Checked = false;
            qurritoCheck.Checked = false;
            cokeCheck.Checked = false;
            spriteCheck.Checked = false;
            chocoShakeCheck.Checked = false;
            cherryShakeCheck.Checked = false;
            donutCheck.Checked = false;
            icecreamCheck.Checked = false;
            cookiesCheck.Checked = false;
            receiptTextbox.Clear();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var dt1 = DateTime.Now;
            string dates = dt1.ToString("dddd, dd MMMM yyyy");
            fingerstp = fingersp * Convert.ToDouble(fingersTextbox.Text);
            burgertp = burgerp * Convert.ToDouble(burgerTextbox.Text);
            twistertp = twisterp * Convert.ToDouble(twisterTextbox.Text);
            tacotp = tacop * Convert.ToDouble(tacoTextbox.Text);
            popcorntp = popcornp * Convert.ToDouble(popcornTextbox.Text);
            friestp = friesp * Convert.ToDouble(friesTextbox.Text);
            qurritotp = qurritop * Convert.ToDouble(qurritoTextbox.Text);
            coketp = cokep * Convert.ToDouble(cokeTextbox.Text);
            spritetp = spritep * Convert.ToDouble(spriteTextbox.Text);
            chocoshaketp = chocoshakep * Convert.ToDouble(chocoshakeTextbox.Text);
            cherryshaketp = cherryshakep * Convert.ToDouble(cherryshakeTextbox.Text);
            donuttp = donutp * Convert.ToDouble(donutTextbox.Text);
            icecreamtp = icecreamp * Convert.ToDouble(icecreamTexbox.Text);
            cookiestp = cookiesp * Convert.ToDouble(cookiesTextbox.Text);
            receiptTextbox.Clear();
            receiptTextbox.AppendText(Environment.NewLine);
            receiptTextbox.AppendText("\t\t\t\t            KFC" + Environment.NewLine);
            receiptTextbox.AppendText("\t\t\t\t*****************" + Environment.NewLine);
            receiptTextbox.AppendText("\t\t\t" + dates + "\t" + Datelbl.Text + Environment.NewLine);
            receiptTextbox.AppendText(Environment.NewLine);
            receiptTextbox.AppendText(Environment.NewLine);
            int count = 0;
            if (fingersCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Fingers:" + fingerstp + " Euro" + Environment.NewLine);
                subtotal = subtotal + fingerstp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Euro/-";
            }
            if (burgerCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Burger:" + burgertp + " Euro" + Environment.NewLine);
                subtotal = subtotal + burgertp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Euro/-";
            }
            if (twisterCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Twister:" + twistertp + " Euro" + Environment.NewLine);
                subtotal = subtotal + twistertp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Euro/-";
            }
            if (tacoCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Taco:" + tacotp + " Euro" + Environment.NewLine);
                subtotal = subtotal + tacotp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Euro/-";
            }
            if (popcornCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Popcorn:" + popcorntp + " Euro" + Environment.NewLine);
                subtotal = subtotal + popcorntp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Euro/-";
            }
            if (friesCHeck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Fries:" + friestp + " Euro" + Environment.NewLine);
                subtotal = subtotal + friestp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Euro/-";
            }
            if (qurritoCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Qurrito:" + qurritotp + " Euro" + Environment.NewLine);
                subtotal = subtotal + qurritotp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Euro/-";
            }
            if (cokeCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Coca-Cola:" + coketp + " Euro" + Environment.NewLine);
                subtotal = subtotal + coketp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Euro/-";
            }
            if (spriteCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Sprite:" + spritetp + " Euro" + Environment.NewLine);
                subtotal = subtotal + spritetp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Euro/-";
            }
            if (chocoShakeCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  ChocoShake:" + chocoshaketp + " Euro" + Environment.NewLine);
                subtotal = subtotal + chocoshaketp;
                subTotallbl.Text ="" + Convert.ToString(subtotal) + " Euro/-";
            }
            if (cherryShakeCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  CherryShake:" + cherryshakep + " Euro" + Environment.NewLine);
                subtotal = subtotal + cherryshakep;
                subTotallbl.Text = "" + Convert.ToString(subtotal) + " Euro/-";
            }
            if (donutCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Donut:" + donutp + " Euro" + Environment.NewLine);
                subtotal = subtotal + donutp;
                subTotallbl.Text =""+ Convert.ToString(subtotal) + " Euro/-";
            }
            if (icecreamCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t" + Convert.ToString(count) + ".  Ice-Cream:" + icecreamtp + " Euro" + Environment.NewLine);
                subtotal = subtotal + icecreamtp;
                subTotallbl.Text = "" + Convert.ToString(subtotal) + " Euro/-";
            }
            if (cookiesCheck.Checked == true)
            {
                count++;
                receiptTextbox.AppendText("\t"+Convert.ToString(count) +".  Cookies:" + cookiestp + " Euro" + Environment.NewLine);
                subtotal = subtotal + cookiestp;
                subTotallbl.Text =  "" + Convert.ToString(subtotal) + " Euro/-";
            }
            tax = subtotal * 0.10;
            total = subtotal + tax;
            vatlbl.Text = Convert.ToString(tax) + " Euro/-";
            totallbl.Text = Convert.ToString(total) + " Euro/-";
            receiptTextbox.AppendText(Environment.NewLine);
            receiptTextbox.AppendText(Environment.NewLine);
 
        }
            

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            var dt1 = DateTime.Now;
            string dates = dt1.ToString("dddd, dd MMMM yyyy");
            label1.Text = dates;
        }

        private void fingersCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (fingersCheck.Checked == true)
            {
                fingersTextbox.Enabled = true;
            }
            if (fingersCheck.Checked == false)
            {
                fingersTextbox.Enabled = false;
                fingersTextbox.Text = "0";
            }
        }

        private void burgerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (burgerCheck.Checked == true)
            {
                burgerTextbox.Enabled = true;
            }
            if (burgerCheck.Checked == false)
            {
                burgerTextbox.Enabled = false;
                burgerTextbox.Text = "0";
            }
        }

        private void twisterCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (twisterCheck.Checked == true)
            {
                twisterTextbox.Enabled = true;
            }
            if (twisterCheck.Checked == false)
            {
                twisterTextbox.Enabled = false;
                twisterTextbox.Text = "0";
            }
        }

        private void tacoCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (tacoCheck.Checked == true)
            {
                tacoTextbox.Enabled = true;
            }
            if (tacoCheck.Checked == false)
            {
                tacoTextbox.Enabled = false;
                tacoTextbox.Text = "0";
            }
        }

        private void popcornCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (popcornCheck.Checked == true)
            {
                popcornTextbox.Enabled = true;
            }
            if (popcornCheck.Checked == false)
            {
                popcornTextbox.Enabled = false;
                popcornTextbox.Text = "0";
            }
        }

        private void friesCHeck_CheckedChanged(object sender, EventArgs e)
        {
            if (friesCHeck.Checked == true)
            {
                friesTextbox.Enabled = true;
            }
            if (friesCHeck.Checked == false)
            {
                friesTextbox.Enabled = false;
                friesTextbox.Text = "0";
            }
        }

        private void qurritoCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (qurritoCheck.Checked == true)
            {
                qurritoTextbox.Enabled = true;
            }
            if (qurritoCheck.Checked == false)
            {
                qurritoTextbox.Enabled = false;
                qurritoTextbox.Text = "0";
            }
        }

        private void cokeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cokeCheck.Checked == true)
            {
                cokeTextbox.Enabled = true;
            }
            if (cokeCheck.Checked == false)
            {
                cokeTextbox.Enabled = false;
                cokeTextbox.Text = "0";
            }
        }

        private void spriteCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (spriteCheck.Checked == true)
            {
                spriteTextbox.Enabled = true;
            }
            if (spriteCheck.Checked == false)
            {
                spriteTextbox.Enabled = false;
                spriteTextbox.Text = "0";
            }
        }

        private void chocoShakeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chocoShakeCheck.Checked == true)
            {
                chocoshakeTextbox.Enabled = true;
            }
            if (chocoShakeCheck.Checked == false)
            {
                chocoshakeTextbox.Enabled = false;
                chocoshakeTextbox.Text = "0";
            }
        }

        private void cherryShakeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cherryShakeCheck.Checked == true)
            {
                cherryshakeTextbox.Enabled = true;
            }
            if (cherryShakeCheck.Checked == false)
            {
                cherryshakeTextbox.Enabled = false;
                cherryshakeTextbox.Text = "0";
            }
        }

        private void donutCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (donutCheck.Checked == true)
            {
                donutTextbox.Enabled = true;
            }
            if (donutCheck.Checked == false)
            {
                donutTextbox.Enabled = false;
                donutTextbox.Text = "0";
            }
        }

        private void icecreamCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (icecreamCheck.Checked == true)
            {
                icecreamTexbox.Enabled = true;
            }
            if (icecreamCheck.Checked == false)
            {
                icecreamTexbox.Enabled = false;
                icecreamTexbox.Text = "0";
            }
        }

        private void cookiesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cookiesCheck.Checked == true)
            {
                cookiesTextbox.Enabled = true;
            }
            if (cookiesCheck.Checked == false)
            {
                cookiesTextbox.Enabled = false;
                cookiesTextbox.Text = "0";
            }
        }

        private void closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
