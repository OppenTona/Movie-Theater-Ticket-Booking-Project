using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlCommand check;
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-DL8NHCA\TOANNT204; Database=QLXemPhim; Trusted_Connection= true");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select Ten from info",conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    comboBox1.Items.Add(reader["Ten"].ToString());
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được với SQL");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void C1_Click(object sender, EventArgs e)
        {

        }

        private void C2_Click(object sender, EventArgs e)
        {

        }

        private void C3_Click(object sender, EventArgs e)
        {

        }

        private void C4_Click(object sender, EventArgs e)
        {

        }

        private void C5_Click(object sender, EventArgs e)
        {

        }

        private void C6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void A3_Click(object sender, EventArgs e)
        {
            {
                Button row = sender as Button;
                int a;
                if (row.BackColor == Color.FromArgb(255, 192, 255))
                {
                    a = int.Parse(DonGia.Text) + 25000;
                    DonGia.Text = a.ToString();
                    row.BackColor = Color.Blue;
                    check = new SqlCommand("update info set " + row.Text + "= '1' where Ten = '" + comboBox1.Text + "'",conn);
                    check.ExecuteNonQuery();
                }
                else
                {
                    a = int.Parse(DonGia.Text) - 25000;
                    DonGia.Text = a.ToString();
                    row.BackColor = Color.FromArgb(255, 192, 255);
                    check = new SqlCommand("update info set " + row.Text + "= NULL where Ten = '" + comboBox1.Text + "'", conn);
                    check.ExecuteNonQuery();
                }
                
            }
        }

        private void A4_Click(object sender, EventArgs e)
        {

        }

        private void B1_Click(object sender, EventArgs e)
        {
            {
                Button row = sender as Button;
                int a;
                if (row.BackColor == Color.FromArgb(192, 192, 255))
                {
                    a = int.Parse(DonGia.Text) + 30000;
                    DonGia.Text = a.ToString();
                    row.BackColor = Color.Blue;
                    check = new SqlCommand("update info set " + row.Text + "= '1' where Ten = '" + comboBox1.Text + "'", conn);
                    check.ExecuteNonQuery();
                }
                else
                {
                    a = int.Parse(DonGia.Text) - 30000;
                    DonGia.Text = a.ToString();
                    row.BackColor = Color.FromArgb(192, 192, 255);
                    check = new SqlCommand("update info set " + row.Text + "= NULL where Ten = '" + comboBox1.Text + "'", conn);
                    check.ExecuteNonQuery();
                }

            }
        }

        private void C1_Click_1(object sender, EventArgs e)
        {
            {
                Button row = sender as Button;
                int a;
                if (row.BackColor == Color.FromArgb(192, 255, 255))
                {
                    a = int.Parse(DonGia.Text) + 35000;
                    DonGia.Text = a.ToString();
                    row.BackColor = Color.Blue;
                    check = new SqlCommand("update info set " + row.Text + "= '1' where Ten = '" + comboBox1.Text + "'", conn);
                    check.ExecuteNonQuery();
                }
                else
                {
                    a = int.Parse(DonGia.Text) - 35000;
                    DonGia.Text = a.ToString();
                    row.BackColor = Color.FromArgb(192, 255, 255);
                    check = new SqlCommand("update info set " + row.Text + "= NULL where Ten = '" + comboBox1.Text + "'", conn);
                    check.ExecuteNonQuery();
                }

            }
        }

        private void D1_Click(object sender, EventArgs e)
        {
                {
                Button row = sender as Button;
                int a;
                if (row.BackColor == Color.FromArgb(192, 255, 192))
                {
                    a = int.Parse(DonGia.Text) + 40000;
                    DonGia.Text = a.ToString();
                    row.BackColor = Color.Blue;
                    check = new SqlCommand("update info set " + row.Text + "= '1' where Ten = '" + comboBox1.Text + "'", conn);
                    check.ExecuteNonQuery();
                }
                else
                {
                    a = int.Parse(DonGia.Text) - 40000;
                    DonGia.Text = a.ToString();
                    row.BackColor = Color.FromArgb(192, 255, 192);
                    check = new SqlCommand("update info set " + row.Text + "= NULL where Ten = '" + comboBox1.Text + "'", conn);
                    check.ExecuteNonQuery();
                }

            }
        }

        private void E1_Click(object sender, EventArgs e)
        {
            {
                Button row = sender as Button;
                int a;
                if (row.BackColor == Color.FromArgb(255, 255, 192))
                {
                    a = int.Parse(DonGia.Text) + 50000;
                    DonGia.Text = a.ToString();
                    row.BackColor = Color.Blue;
                    check = new SqlCommand("update info set " + row.Text + "= '1' where Ten = '" + comboBox1.Text + "'", conn);
                    check.ExecuteNonQuery();
                }
                else
                {
                    a = int.Parse(DonGia.Text) - 50000;
                    DonGia.Text = a.ToString();
                    row.BackColor = Color.FromArgb(255, 255, 192);
                    check = new SqlCommand("update info set " + row.Text + "= NULL where Ten = '" + comboBox1.Text + "'", conn);
                    check.ExecuteNonQuery();
                }

            }
        }

        private void F1_Click(object sender, EventArgs e)
        {
            {
                Button row = sender as Button;
                int a;
                if (row.BackColor == Color.FromArgb(255, 192, 192))
                {
                    a = int.Parse(DonGia.Text) + 45000;
                    DonGia.Text = a.ToString();
                    row.BackColor = Color.Blue;
                    check = new SqlCommand("update info set " + row.Text + "= '1' where Ten = '" + comboBox1.Text + "'", conn);
                    check.ExecuteNonQuery();
                }
                else
                {
                    a = int.Parse(DonGia.Text) - 45000;
                    DonGia.Text = a.ToString();
                    row.BackColor = Color.FromArgb(255, 192, 192);
                    check = new SqlCommand("update info set " + row.Text + "= NULL where Ten = '" + comboBox1.Text + "'", conn);
                    check.ExecuteNonQuery();
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = "Mời bạn chọn ghế trong phòng chiếu phim: " + comboBox1.Text;
            foreach (Control Button in tableLayoutPanel1.Controls)
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select " + Button.Text + " from info where Ten = '" + comboBox1.Text + "'", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                string a = dt.Rows[0][0].ToString();
                if (a == "1")
                {
                    Button.BackColor = Color.Blue;
                }
                else
                {
                    if (a == "2")
                    {
                        Button.BackColor = Color.Red;
                        Button.Enabled = false;
                    }
                    else
                    {
                        Button.Enabled = true;
                        if(Button.Text == "A1" || Button.Text == "A2" || Button.Text == "A3" || Button.Text == "A4" || Button.Text == "A5" || Button.Text == "A6")
                        {
                            Button.BackColor= Color.FromArgb(255, 192, 255);
                        }
                        if (Button.Text == "B1" || Button.Text == "B2" || Button.Text == "B3" || Button.Text == "B4" || Button.Text == "B5" || Button.Text == "B6")
                        {
                            Button.BackColor = Color.FromArgb(192, 192, 255);
                        }
                        if (Button.Text == "C1" || Button.Text == "C2" || Button.Text == "C3" || Button.Text == "C4" || Button.Text == "C5" || Button.Text == "C6")
                        {
                            Button.BackColor = Color.FromArgb(192, 255, 255);
                        }
                        if (Button.Text == "D1" || Button.Text == "D2" || Button.Text == "D3" || Button.Text == "D4" || Button.Text == "D5" || Button.Text == "D6")
                        {
                            Button.BackColor = Color.FromArgb(192, 255, 192);
                        }
                        if (Button.Text == "E1" || Button.Text == "E2" || Button.Text == "E3" || Button.Text == "E4" || Button.Text == "E5" || Button.Text == "E6")
                        {
                            Button.BackColor = Color.FromArgb(255, 255, 192);
                        }
                        if (Button.Text == "F1" || Button.Text == "F2" || Button.Text == "F3" || Button.Text == "F4" || Button.Text == "F5" || Button.Text == "F6")
                        {
                            Button.BackColor = Color.FromArgb(255, 192, 192);
                        }
                    }
                }
            }
        }

        private void ThanhToan_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn chọn những chiếc ghế này không?","Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DonGia.Text = "0";
                foreach(Control button in tableLayoutPanel1.Controls)
                {
                    if(button.BackColor == Color.Blue)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                        check = new SqlCommand("update info set " + button.Text + "= '2' where Ten = '" + comboBox1.Text + "'", conn);
                        check.ExecuteNonQuery();
                    }
                    
                }
            }
            
        }
    }
}
