using Entities.Dtos.UserDtos;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebAPIWithWindowsForm
{
    public partial class kullanici : Form
    {
        #region Defines
        private string url = "http://localhost:61695/api";
        private int selectedId = 0;
        #endregion

        public kullanici()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            //Grid listeleyen custom method
            await DataGridWiewFill();
        }

        private void ClearForm()
        {
            cmbGender.SelectedValue = 1;

            txtAddress.Text = String.Empty;
            txtUserName.Text = String.Empty;
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtEmail.Text = String.Empty;
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            dtpDateOfBirth.Value = DateTime.Now;
            cmbGender.SelectedValue = 1;
        }

        private async Task DataGridWiewFill()
        {
            //HttpClient, Projemizin bir başka uç noktayla (endpoint) iletişim kurması ve bu noktaya
            //Http istekleri atabilmesini sağlayan bir sınıftır. Http isteklerimizi
            //Get, Put, Delete veya Post olarak asenkron olarak yapmamızı sağlamaktadır. 
            using (HttpClient httpClient = new HttpClient())
            {
                var users = await httpClient.GetFromJsonAsync<List<UserDetailDto>>(new Uri(url + "/Users/GetList"));
                dataGridView1.DataSource = users;
            }
        }

        #region CREATE
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                UserAddDto userAddDto = new UserAddDto()
                {
                    UserName = txtUserName.Text,
                    Address = txtAddress.Text,
                    DateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Text),
                    Email = txtEmail.Text,
                    Gender = cmbGender.Text == "Erkek" ? true : false,
                    LastName = txtLastName.Text,
                    FirstName = txtFirstName.Text,
                    Password = txtPassword.Text,
                };

                //HttpResponseMessage, istekten dönen durum kodu ve verileri içeren bir HTTP yanıt iletisini temsil eder.
                //PostAsJsonAsync, istek gövdesinde seri hale GETIRILMIŞ JSON olarak içeren belirtilen URI 'ye BIR post isteği gönderir.
                HttpResponseMessage response = await httpClient.PostAsJsonAsync(url + "/Users/Add", userAddDto);

                //IsSuccessStatusCode, bool değerdir. responsun durumuna göre true veya false olarak gelir.
                if (response.IsSuccessStatusCode)
                {
                    await DataGridWiewFill();

                    //MessageBox, mesaj kutusu açar. MessageBoxButtons buttton çağırma.
                    MessageBox.Show("Ekleme İşemi Başarılı!");

                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Ekleme İşemi Başarılı!");
                }
            }
        }

        #endregion

        #region Gender Method
        void CmbGenderFill()
        {
            List<Gender> genders = new List<Gender>();

            genders.Add(new Gender()
            {
                Id = 1,
                GenderName = "Erkek"
            });
            genders.Add(new Gender()
            {
                Id = 2,
                GenderName = "Kadın"
            });
            cmbGender.DataSource = genders;
            cmbGender.DisplayMember = "GenderName";
            cmbGender.ValueMember = "Id";
        }

        class Gender
        {
            public int Id { get; set; }
            public string GenderName { get; set; }
        }
        #endregion

        #region DOUBLE CLİCK
        private async void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //CurrentRow, seçilen satır. 
            //cell, seçilen hücre[index]
            selectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            using (HttpClient httpClient = new HttpClient())
            {
                var user = await httpClient.GetFromJsonAsync<UserDto>(new Uri(url + "/Users/GetById/" + selectedId));

                txtAddress.Text = user.Address;
                //int respGender = user.Gender == true ? (int)Genders.Male : (int)Genders.Famele;
                cmbGender.SelectedValue = user.Gender == true ? 1 : 2; //TODO: burada problem var
                txtUserName.Text = user.UserName;
                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtPassword.Text = user.Password;
                txtEmail.Text = user.Email;
                dtpDateOfBirth.Value = user.DateOfBirth;
            }
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }
        #endregion

        #region UPDATE
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                UserUpdateDto userUpdateDto = new UserUpdateDto()
                {
                    Id = selectedId,
                    UserName = txtUserName.Text,
                    Address = txtAddress.Text,
                    DateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Text),
                    Email = txtEmail.Text,
                    Gender = cmbGender.Text == "Erkek" ? true : false,
                    LastName = txtLastName.Text,
                    FirstName = txtFirstName.Text,
                    Password = txtPassword.Text,
                };

                HttpResponseMessage response = await httpClient.PutAsJsonAsync(url + "/Users/Update", userUpdateDto);

                if (response.IsSuccessStatusCode)
                {
                    await DataGridWiewFill();

                    //MessageBox, mesaj kutusu açar. MessageBoxButtons buttton çağırma.
                    MessageBox.Show("Düzenleme İşemi Başarılı!");

                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Düzenleme İşemi Başarılı!");
                }
            }
        }
        #endregion

        #region DELETE
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                HttpResponseMessage response = await httpClient.DeleteAsync(url + "/Users/delete/" + selectedId);

                if (response.IsSuccessStatusCode)
                {
                    await DataGridWiewFill();

                    MessageBox.Show("Silme İşemi Başarılı!");

                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Silme İşemi Başarılı!");
                }
            }
        }

        #endregion

    }
}
