using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_1214056_New
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(700, 250);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonMatkul_Click(object sender, EventArgs e)
        {
            if (tbNim.Text != "")
            {
                if (tbNama.Text != "")
                {
                    if (rbLk.Checked || rbPr.Checked)
                    {
                        if (tbAlamat.Text != "")
                        {
                            if (cbProdi.Text != "")
                            {
                                if (tbTahun.Text != "")
                                {
                                    if (tbSemester.Text != "")
                                    {
                                        MessageBox.Show
                                        ("Data Lengkap !!!",
                                        "Informasi Data Submit",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Size = new Size(700, 450);
                                    }
                                    else
                                    {
                                        MessageBox.Show
                                        ("Semester Belum Diisi !!!",
                                        "Informasi Data Submit",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show
                                    ("Tahun Akademik Belum Diisi !!!",
                                    "Informasi Data Submit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show
                                ("Program Studi Belum Diisi !!!",
                                "Informasi Data Submit",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show
                            ("Alamat Belum Diisi !!!",
                            "Informasi Data Submit",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show
                        ("Jenis Kelamin Belum Diisi !!!",
                        "Informasi Data Submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show
                    ("Nama Belum Diisi !!!",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show
                ("NIM Belum Diisi !!!",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbTahun_TextChanged(object sender, EventArgs e)
        {
            if (tbTahun.Text == "")
            {
                epWrong.SetError(tbTahun, "");
            }
            else
            {
                if (Regex.IsMatch(tbTahun.Text, @"^\d{4}/\d{4}$"))
                {
                    epWrong.SetError(tbTahun, "");
                }
                else
                {
                    epWrong.SetError(tbTahun, "Format Tahun Akademik Salah!");
                }
            }
        }

        private void tbSemester_TextChanged(object sender, EventArgs e)
        {
            if (tbSemester.Text == "")
            {
                epWrong.SetError(tbSemester, "");
            }
            else
            {
                if ((tbSemester.Text).All(Char.IsNumber))
                {
                    epWrong.SetError(tbSemester, "");
                }
                else
                {
                    epWrong.SetError(tbSemester, "Inputan Semester Hanya Boleh Angka!");
                    MessageBox.Show
                    ("Inputan semester hanya boleh angka",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void rbKurikulum1_CheckedChanged(object sender, EventArgs e)
        {
            cb1.Enabled = true; cb1.Checked = false;
            cb2.Enabled = true; cb2.Checked = false;
            cb3.Enabled = true; cb3.Checked = false;
            cb4.Enabled = true; cb4.Checked = false;
            cb5.Enabled = true; cb5.Checked = false;
            cb6.Enabled = true; cb6.Checked = false;
            cb7.Enabled = true; cb7.Checked = false;
            cb8.Enabled = true; cb8.Checked = false;
            cb9.Enabled = false; cb9.Checked = false;
            cb10.Enabled = true; cb10.Checked = false;
            cb11.Enabled = true; cb11.Checked = false;
            cb12.Enabled = false; cb12.Checked = false;
        }

        private void rbKurikulum2_CheckedChanged(object sender, EventArgs e)
        {
            cb1.Enabled = false; cb1.Checked = false;
            cb2.Enabled = true; cb2.Checked = false;
            cb3.Enabled = true; cb3.Checked = false;
            cb4.Enabled = true; cb4.Checked = false;
            cb5.Enabled = true; cb5.Checked = false;
            cb6.Enabled = true; cb6.Checked = false;
            cb7.Enabled = true; cb7.Checked = false;
            cb8.Enabled = true; cb8.Checked = false;
            cb9.Enabled = false; cb9.Checked = false;
            cb10.Enabled = true; cb10.Checked = false;
            cb11.Enabled = true; cb11.Checked = false;
            cb12.Enabled = true; cb12.Checked = false;
        }

        private void rbKurikulum3_CheckedChanged(object sender, EventArgs e)
        {
            cb1.Enabled = false; cb1.Checked = false;
            cb2.Enabled = true; cb2.Checked = false;
            cb3.Enabled = true; cb3.Checked = false;
            cb4.Enabled = true; cb4.Checked = false;
            cb5.Enabled = true; cb5.Checked = false;
            cb6.Enabled = true; cb6.Checked = false;
            cb7.Enabled = true; cb7.Checked = false;
            cb8.Enabled = true; cb8.Checked = false;
            cb9.Enabled = true; cb9.Checked = false;
            cb10.Enabled = true; cb10.Checked = false;
            cb11.Enabled = true; cb11.Checked = false;
            cb12.Enabled = false; cb12.Checked = false;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            String jeniskelamin = null;
            if (rbLk.Checked)
            {
                jeniskelamin = rbLk.Text;
            }
            else
            {
                jeniskelamin = rbPr.Text;
            }

            String tahunajar = null;
            if (rbKurikulum1.Checked)
            {
                tahunajar = rbKurikulum1.Text;
            }
            else if (rbKurikulum2.Checked)
            {
                tahunajar = rbKurikulum2.Text;
            }
            else
            {
                tahunajar = rbKurikulum3.Text;
            }

            String matkul = null;
            if (cb1.Checked)
            {
                matkul += cb1.Text + ", ";
            }

            if (cb10.Checked)
            {
                matkul += cb10.Text + ", ";
            }

            if (cb2.Checked)
            {
                matkul += cb2.Text + ", ";
            }

            if (cb3.Checked)
            {
                matkul += cb3.Text + ", ";
            }

            if (cb4.Checked)
            {
                matkul += cb4.Text + ", ";
            }

            if (cb5.Checked)
            {
                matkul += cb5.Text + ", ";
            }

            if (cb6.Checked)
            {
                matkul += cb6.Text + ", ";
            }

            if (cb7.Checked)
            {
                matkul += cb7.Text + ", ";
            }

            if (cb8.Checked)
            {
                matkul += cb8.Text + ", ";
            }

            if (cb11.Checked)
            {
                matkul += cb11.Text + ", ";
            }

            if (cb12.Checked)
            {
                matkul += cb12.Text + ", ";
            }

            if (cb9.Checked)
            {
                matkul += cb9.Text + ", ";
            }


            MessageBox.Show
            ("Nama : " + tbNama.Text +
            "\nNIM: " + tbNim.Text +
            "\nJenis Kelamin: " + jeniskelamin +
            "\nAlamat: " + tbAlamat.Text +
            "\nProgram Studi: " + cbProdi.Text +
            "\nTahun Akademik: " + tbTahun.Text +
            "\nSemester: " + tbSemester.Text +
            "\n" + "\n" +
            "\nTahun Akademik: " + tahunajar +
            "\nMata kuliah: " + matkul,
            "Terima kasih telah menggunakan aplikasi kami",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            tbNim.Clear();
            tbNama.Clear();
            tbAlamat.Clear();
            rbLk.Checked = false;
            rbPr.Checked = false;
            cbProdi.ResetText();
            tbTahun.Clear();
            tbSemester.Clear();
            cb10.Checked = false;
            cb11.Checked = false;
            cb2.Checked = false;
            cb3.Checked = false;
            cb4.Checked = false;
            cb5.Checked = false;
            cb6.Checked = false;
            cb7.Checked = false;
            cb8.Checked = false;
            cb12.Checked = false;
            cb9.Checked = false;
            rbKurikulum1.Checked = false;
            rbKurikulum2.Checked = false;
            rbKurikulum3.Checked = false;

            this.Size = new Size(700, 250);
        }
    }
}
