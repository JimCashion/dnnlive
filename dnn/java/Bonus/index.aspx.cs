using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dnn.java.Bonus
{
    public partial class index : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Page.ClientScript.GetPostBackEventReference(tbcontrol, string.Empty);
            tbprize.Text = "bleh!!";
            if (Page.IsPostBack)
            {
                string arg = Request["__EVENTARGUMENT"];

                string func = arg.Split(',')[0];
                string parm = arg.Split(',')[1];

                switch (func)
                {
                    case "play2":
                        //  checksum passed so do full check
                       
                        int i = 1;
                        int g = 1;
                        int u = 1;
                        int a = 1;
                        int n = 2;
                        int o = 2;
                        int d = 1;

                        for (int j = 0; j < parm.Length; j++)
                        {
                            if (parm.Substring(j, 1) == "I")
                                i--;
                            if (parm.Substring(j, 1) == "G")
                                g--;

                            if (parm.Substring(j, 1) == "U")
                                u--;

                            if (parm.Substring(j, 1) == "A")
                                a--;

                            if (parm.Substring(j, 1) == "N")
                                n--;

                            if (parm.Substring(j, 1) == "O")
                                o--;

                            if (parm.Substring(j, 1) == "D")
                                d--;
                        }

                        if (i == 0 && g == 0 && u == 0 && a == 0 && n == 0 && o == 0 && d == 0)
                        {
                            tbprize.Text = "good";

                        }
                        else
                        {
                            tbprize.Text = "bad";

                        }
                        tbdata.Text = parm;
                        tbcontrol.Text = "play1";
                        break;
                    case "sort":
                        // we have the right letters s lets sort them
                        tbcontrol.Text = "play2";
                        tbdata.Text = "IGUANODON";
                        break;
                    case "win":
                        // we have the right letters s lets sort them
                        var ap = dnn.SecureStuff.GetCoords("Bonus");
                        tbcontrol.Text = func;

                       
                            tbprize.Text = ap;
                            break;
                    case "lose":
                          
                            tbcontrol.Text = "play";


                            tbdata.Text = "";
                            break;
                    default:
                        tbcontrol.Text = func;
                        break;

                }
                /*
                var a = dnn.SecureStuff.GetCoords("Bonus");


                if (arg == "win")
                    tbprize.Text = a;
                else
                    tbprize.Text = "bleh!!";
                tbcontrol.Text = arg;
                 */ 
            }

        }

        protected void bpostback_Click(object sender, EventArgs e)
        {

        }
    }
}
