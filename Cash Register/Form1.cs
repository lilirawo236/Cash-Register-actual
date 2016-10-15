using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cash_Register
{
    public partial class window1 : Form
    {

        //creating the constants for each purchasable item
        const double PUMPKIN_COST = 7.50;
        const double EYE_COST = 19.95;
        const int COOKIE_COST = 2;
        const double BONE_COST = 8.20;
        const double CANDY_CORN_COST = 0.75;
        const int PRESENT_COST = 250;
        const double TAX = 0.13;

        //creating variables to store the amount of each item purchased
        int pumpkinsPurchased;
        int eyesPurchased;
        int cookiesPurchased;
        int bonesPurchased;
        int candyCornPurchased;
        int presentsPurchased;
        double totalPrice;

        //creating variables to hold the calculated cost of 'n' number of each items together
        double totalItemsPurchasedCost;
        double totalPumpkinCost;
        double totalEyeCost;
        double totalCookieCost;
        double totalBoneCost;
        double totalCandyCornCost;
        double totalPresentCost;
 
        SolidBrush fontBrush = new SolidBrush(Color.AntiqueWhite); //creating a brush
        Font receiptFont = new Font("Georgia", 12, FontStyle.Regular); //creating font


        public window1()
        {
            InitializeComponent();
        }

        //changing all of the text colours when the mouse scrolls over the labels
        private void pumpkinLabel_MouseEnter(object sender, EventArgs e)
        {
            pumpkinLabel.ForeColor = Color.DarkOrange;
        }

        private void pumpkinLabel_MouseLeave(object sender, EventArgs e)
        {
            pumpkinLabel.ForeColor = Color.White;
        }

        private void eyeLabel_MouseEnter(object sender, EventArgs e)
        {
            eyeLabel.ForeColor = Color.DarkOrange;
        }

        private void eyeLabel_MouseLeave(object sender, EventArgs e)
        {
            eyeLabel.ForeColor = Color.White;
        }

        private void cookieLabel_MouseEnter(object sender, EventArgs e)
        {
            cookieLabel.ForeColor = Color.DarkOrange;
        }

        private void cookieLabel_MouseLeave(object sender, EventArgs e)
        {
            cookieLabel.ForeColor = Color.White;
        }

        private void boneLabel_MouseEnter(object sender, EventArgs e)
        {
            boneLabel.ForeColor = Color.DarkOrange;
        }

        private void boneLabel_MouseLeave(object sender, EventArgs e)
        {
            boneLabel.ForeColor = Color.White;
        }

        private void candyCornLabel_MouseEnter(object sender, EventArgs e)
        {
            candyCornLabel.ForeColor = Color.DarkOrange;
        }

        private void candyCornLabel_MouseLeave(object sender, EventArgs e)
        {
            candyCornLabel.ForeColor = Color.White;
        }

        private void presentLabel_MouseEnter(object sender, EventArgs e)
        {
            presentLabel.ForeColor = Color.Red;
            presentLabel.BackColor = Color.Green;
        }

        private void presentLabel_MouseLeave(object sender, EventArgs e)
        {
            presentLabel.ForeColor = Color.White;
            presentLabel.BackColor = Color.Black;
        }

        private void pumpkinPriceButton_Click(object sender, EventArgs e)
        {
            pumpkinsPurchased = ++pumpkinsPurchased;
        }

        private void eyePriceButton_Click(object sender, EventArgs e)
        {
            eyesPurchased = ++eyesPurchased;
        }

        private void cookiePriceButton_Click(object sender, EventArgs e)
        {
            cookiesPurchased = ++cookiesPurchased;
        }

        private void bonePriceButton_Click(object sender, EventArgs e)
        {
            bonesPurchased = ++bonesPurchased;
        }

        private void candyCornPriceButton_Click(object sender, EventArgs e)
        {
            candyCornPurchased = ++candyCornPurchased;
        }

        private void presentPriceButton_Click(object sender, EventArgs e)
        {
            presentsPurchased = ++presentsPurchased;
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics(); //setting up graphics

            //when the button is clicked to calculate, the screen clears for the receipt
            pumpkin.Visible = false;
            pumpkinLabel.Visible = false;
            pumpkinPriceButton.Visible = false;
            eyeBall.Visible = false;
            eyeLabel.Visible = false;
            eyePriceButton.Visible = false;
            cookie.Visible = false;
            cookieLabel.Visible = false;
            cookiePriceButton.Visible = false;
            bone.Visible = false;
            boneLabel.Visible = false;
            bonePriceButton.Visible = false;
            candyCorn.Visible = false;
            candyCornLabel.Visible = false;
            candyCornPriceButton.Visible = false;
            present.Visible = false;
            presentLabel.Visible = false;
            presentPriceButton.Visible = false;
            checkoutButton.Visible = false;

            Thread.Sleep(1000);

            //when the button is clicked, all of the total costs for each item are calculated
            totalPumpkinCost = PUMPKIN_COST * pumpkinsPurchased;
            formGraphics.DrawString("Jack O'Lanterns:", receiptFont, fontBrush, 20, 50);
            formGraphics.DrawString(totalPumpkinCost.ToString("C"), receiptFont, fontBrush, 300, 50);
            Thread.Sleep(1000);
            totalEyeCost = EYE_COST * eyesPurchased;
            formGraphics.DrawString("Lost Eyeballs:", receiptFont, fontBrush, 20, 100);
            formGraphics.DrawString(totalEyeCost.ToString("C"), receiptFont, fontBrush, 300, 100);
            Thread.Sleep(1000);
            totalCookieCost = COOKIE_COST * cookiesPurchased;
            formGraphics.DrawString("Giant Cookies:", receiptFont, fontBrush, 20, 150);
            formGraphics.DrawString(totalCookieCost.ToString("C"), receiptFont, fontBrush, 300, 150);
            Thread.Sleep(1000);
            totalBoneCost = BONE_COST * bonesPurchased;
            formGraphics.DrawString("Spare Bones:", receiptFont, fontBrush, 20, 200);
            formGraphics.DrawString(totalBoneCost.ToString("C"), receiptFont, fontBrush, 300, 200);
            Thread.Sleep(1000);
            totalCandyCornCost = CANDY_CORN_COST * candyCornPurchased;
            formGraphics.DrawString("Candy Corn Pieces:", receiptFont, fontBrush, 20, 250);
            formGraphics.DrawString(totalCandyCornCost.ToString("C"), receiptFont, fontBrush, 300, 250);
            Thread.Sleep(1000);
            totalPresentCost = PRESENT_COST * presentsPurchased;
            formGraphics.DrawString("Wrong Holiday Presents:", receiptFont, fontBrush, 20, 300);
            formGraphics.DrawString(totalPresentCost.ToString("C"), receiptFont, fontBrush, 300, 300);
            Thread.Sleep(1000);

            totalItemsPurchasedCost = totalPumpkinCost + totalEyeCost + totalCookieCost
            + totalBoneCost + totalCandyCornCost + totalPresentCost; //calculating the total cost of all items before taxes

            totalPrice = totalItemsPurchasedCost + totalItemsPurchasedCost * TAX;
            formGraphics.DrawString("Total:", receiptFont, fontBrush, 20, 350);
            formGraphics.DrawString(totalPrice.ToString("C"), receiptFont, fontBrush, 300, 350);
            Thread.Sleep(1000);

            formGraphics.DrawString("Enter amount paid:", receiptFont, fontBrush, 20, 450);
            paymentInput.Visible = true;
        }
    }
}
