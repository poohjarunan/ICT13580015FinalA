using ICT13580015FinalA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace ICT13580015FinalA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PoohNewPage : ContentPage
    {
        Pooh pooh;
        public PoohNewPage()
        {
            InitializeComponent();

            saveButton.Clicked += SaveButton_Clicked;
            cancelButton.Clicked += CancelButton_Clicked;

            departmentPicker.Items.Add("ไอที");

            departmentPicker.Items.Add("บัญชี");

            departmentPicker.Items.Add("การตลาด");

            departmentPicker.Items.Add("ผล");

            genderPicker.Items.Add("ชาย");
            genderPicker.Items.Add("หญิง");

            statusPicker.Items.Add("โสด");
            statusPicker.Items.Add("แต่งงานแล้ว");


            if (pooh != null)
            {
                nameEntry.Text = pooh.Name;
                lastnameEntry.Text = pooh.Lastname;



            }
        

		}



		async void SaveButton_Clicked(object sender, EventArgs e)
		{
			var isOk = await DisplayAlert("ยืนยัน", "คุณต้องการบันทึกใช่หรือไม่", "ใช่", "ไม่ใช่");

			if (isOk)
			{
				if (pooh == null)
				{
                    var product = new Pooh();
					product.Name = nameEntry.Text;
					product.Lastname = lastnameEntry.Text;
					product.Age = int.Parse(ageEntry.Text);
                    genderPicker.SelectedItem = product.Sex;
					departmentPicker.SelectedItem = product.Department;
					product.Phone = int.Parse(phoneEntry.Text);
					product.Email = emailEntry.Text;
					product.Address = addressEditor.Text;
					statusPicker.SelectedItem = product.Status;

					var id = App.DbHelper.Addproduct(product);
					await DisplayAlert("บันทึกสำเร็จ", "รหัสสินค้าของท่านคือ" + id, "ตกลง");

				}

				else
				{
                    pooh.Name = nameEntry.Text;
                    pooh.Lastname = lastnameEntry.Text;
                    pooh.Age = int.Parse(ageEntry.Text);
                    pooh.Sex = genderPicker.SelectedItem.ToString();
                    pooh.Department = departmentPicker.SelectedItem.ToString();
                    pooh.Phone = int.Parse(phoneEntry.Text);
                    pooh.Email = emailEntry.Text;
                    pooh.Status = statusPicker.SelectedItem.ToString();
                    pooh.Children = chlidLabel.ToString();
                    pooh.Address = addressEditor.Text;
                    pooh.Salary = decimal.Parse(salaryLabel.Text);


                    var id = App.DbHelper.UpdateProduct(pooh);
					await DisplayAlert("บันทึกสำเร็จ", "แก้ไขข้อมูลสินค้า" + id, "ตกลง");
				}
				await Navigation.PopModalAsync();
			}
		}



		private void CancelButton_Clicked(object sender, EventArgs e)
		{

		}
	}
}