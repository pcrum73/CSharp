using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HumanSimulator
{
    public partial class HumanInteract : System.Web.UI.Page
    {
        private Human Human = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                for (int i = 0; i < 7; i++)
                {
                    ddlFeet.Items.Add((i + 1).ToString());
                }

                for (int i = 0; i < 12; i++)
                {
                    ddlInches.Items.Add((i + 1).ToString().PadLeft(2, '0'));
                }
            }

        }

        

        protected void btnCreateHuman_Click(object sender, EventArgs e)
        {
            Human = CreateHuman(txtName.Text);
            DisplayHuman();
        }





        public Human CreateHuman(string name)
        {
            Human newHuman = new Human(name);
            if (rbFemale.Checked)
            {
                newHuman.Gender = Human.GenderType.Female;
            }
            else
            {
                newHuman.Gender = Human.GenderType.Male;
            }
            decimal age = 0;
            decimal.TryParse(txtAge.Text, out age);
            newHuman.Age = age;

            newHuman.EyeColor = txtEyeColor.Text;
            newHuman.Hair = ckHair.Checked;
            if (newHuman.Hair)
            {
                newHuman.HairColor = txtHairColor.Text;
            }
            string totalHeight = ddlFeet.SelectedValue + ddlInches.SelectedValue;
            newHuman.Height = decimal.Parse(totalHeight);

            decimal.TryParse(txtWeight.Text, out age);
            newHuman.Weight = age;

            return newHuman;

        }

        private void DisplayHuman()
        {
            liName.InnerText = Human.Name;

            liAge.InnerText = Human.Age.ToString();

            liHeight.InnerText = string.Format("{0}' {1}\"", Human.Height.ToString().Substring(0, 1), Human.Height.ToString().Substring(1, 2));

            liWeight.InnerText = Human.Weight.ToString();

            liGender.InnerText = Human.Gender.ToString();

            liHairColor.InnerText = Human.Hair ? Human.HairColor : "Bald";

            liEyeColor.InnerText = Human.EyeColor;

        }

        protected void ckHair_CheckedChanged(object sender, EventArgs e)
        {
            lblHairColor.Style.Clear();
            if (ckHair.Checked)
            {
                lblHairColor.Style.Remove("display");
                txtHairColor.Visible = true;
            }
            else
            {
                lblHairColor.Style.Add("display", "none");
                txtHairColor.Visible = false;
            }
        }

        protected void btnDyeHair_Click(object sender, EventArgs e)
        {
            Human = CreateHuman(txtName.Text);
            Human.DyeHair(txtNewHairColor.Text);
            DisplayHuman();

        }
    }
}