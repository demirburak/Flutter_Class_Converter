using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flutter_Class_Converter
{
    public partial class Form1 : Form
    {
        bool JsonParametresiEklensinmi = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYardim_Click(object sender, EventArgs e)
        {
            string bilgi = "(EN) You can copy/paste properties from c# model (class) to table below. Write to model (class) name and click convert button.\n\n";
            bilgi += "(TR) Sadece class taki propertyleri aşağıdaki tabloya yapıştır. Model in isminide textbox a  yaz ve dönüştür tıkla.\n\n";
            bilgi += "Burak D.";
            MessageBox.Show(bilgi);
        }

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n');
                int row = dgv.CurrentCell.RowIndex;
                int col = dgv.CurrentCell.ColumnIndex;
                foreach (string line in lines)
                {
                    if (row < dgv.RowCount && line.Length > 0)
                    {
                        if (dgv.Rows.Count - 1 == row) dgv.Rows.Add();

                        string[] cells = line.Split('\t');
                        for (int i = 0; i < cells.GetLength(0); ++i)
                        {
                            if (col + i < this.dgv.ColumnCount)
                            {
                                dgv[col + i, row].Value = (Convert.ChangeType(cells[i], dgv[col + i, row].ValueType)).ToString().Replace("\n", "").Replace("\r", "").Replace("\t", "").Replace((char)160, (char)32);
                            }
                            else
                            {
                                break;
                            }
                        }

                        row++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }

        private void btnDonustur_Click(object sender, EventArgs e)
        {
            List<string> isimler = new List<string>();
            string model = txtModel.Text;
            string metin = "part '" + model.ToLower() + ".g.dart'; \n\n";

            metin += "@JsonSerializable()\n";
            metin += "class " + model + " { \n\n";

            foreach (DataGridViewRow row in dgv.Rows)
            {
                
                kelimeDonustur(row.Cells[0].Value, out string isim, out string ozellik);
                if(!string.IsNullOrEmpty(isim)&& !string.IsNullOrEmpty(isim))
                {
                    isimler.Add(isim);

                    metin += ozellik + " " + isim + ";\n";
                }
            }

            metin += "\n\n";

            metin += model + "({ ";
            foreach (var isim in isimler)
            {
                metin += "this." + isim + " ,\n";
            }
            metin = metin.Substring(0, metin.Length - 2) + "}); \n\n";

            metin += "factory " + model + ".fromJson(Map<String, dynamic> jsonData) => " +
                " _$" + model + "FromJson(jsonData);\n\n";

            metin += "Map<String, dynamic> toJson() => _$"+model+"ToJson(this);\n\n";

            metin += model + ".clone(" + model + " source): \n";
            foreach (var isim in isimler)
            {
                metin += "this." + isim + " = source." + isim + " ,\n";
            }
            metin = metin.Substring(0, metin.Length - 2) + ";";

            metin += " } \n";

            //json parametresi
            if (JsonParametresiEklensinmi)
            {
                metin = metin.Replace("@JsonSerializable()", "@JsonSerializable(explicitToJson: true)");
            }

            txtMetin.Text = metin;


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtModel.Text = string.Empty;
            txtMetin.Text = string.Empty;
            JsonParametresiEklensinmi = false;
            dgv.Rows.Clear();
        }

        private void kelimeDonustur(object value, out string isim, out string ozellik)
        {
            isim = string.Empty;
            ozellik = string.Empty;
            if (value != null)
            {
                try
                {
                    string satir = value.ToString();
                    satir = satir.Replace("public", "");
                    string[] temp = satir.Split(" ".ToCharArray());
                    string[] bilgiler = temp.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    if (bilgiler.Length > 2)
                    {
                        ozellik = bilgiler[0];
                        isim = bilgiler[1];
                    }

                    if(!string.IsNullOrEmpty(ozellik) && !string.IsNullOrEmpty(isim))                        
                    {
                        ozellik = ozellikDonusum(ozellik);
                        isim = isimDonusum(isim);
                    }

                }
                catch (Exception s)
                {

                }
            }
        }

        private string isimDonusum(string isim)
        {
            isim = isim.Replace(" ", "");
            int usindex = isim.IndexOf("_");
            if (usindex == -1 || usindex == 0)
                isim = isim.ToLower();
            else
            {
                if (usindex == 1)
                {
                    string ilk = isim.Substring(0, 1);
                    string son = isim.Replace(ilk, "");
                    isim = ilk.ToLower() + son;
                }
                else
                {
                    string ilk = isim.Substring(0, usindex - 1);
                    string son = isim.Replace(ilk, "");
                    isim = ilk.ToLower() + son;
                }
            }

            isim = isim.Replace("ı", "i").Replace("İ", "I");


            return isim;
        }

        private string ozellikDonusum(string ozellik)
        {
            ozellik = ozellik.Replace(" ", "");
            switch (ozellik)
            {
                case "int":
                    ozellik = "int";
                    break;
                case "double":
                    ozellik = "double";
                    break;
                case "string":
                    ozellik = "String";
                    break;
                case "decimal":
                    ozellik = "double";
                    break;
                case "bool":
                    ozellik = "bool";
                    break;
                case "DateTime":
                    ozellik = "DateTime";
                    break;
                default:
                    {
                        List<string> anaOzellikler = new List<string>() { "int",
                        "double","decimal","string","bool","DateTime"};

                        if (ozellik.IndexOf("<") > -1)
                        {
                            string[] temp1 = ozellik.Split("<".ToCharArray());
                            string birinciOzellik = temp1[0];
                            string isim = ozellik.Replace(birinciOzellik, "").Replace("<", "").Replace(">", "");
                            if(!anaOzellikler.Contains(isim) && !JsonParametresiEklensinmi)
                            {
                                JsonParametresiEklensinmi = true;
                            }

                            //ozellik = birinciOzellik + "<" + isimDonusum(isim) + ">";
                        }
                        else
                        {
                            if (!anaOzellikler.Contains(ozellik) && !JsonParametresiEklensinmi)
                            {
                                JsonParametresiEklensinmi = true;
                            }
                        }

                    }
                    break;
            }

            return ozellik;
        }
    }
}
