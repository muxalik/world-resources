using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using world_resources.models;
using Syncfusion.WinForms.DataGridConverter;

namespace world_resources
{
    public partial class ResourcePage : Form
    {
        public ResourcePage()
        {
            InitializeComponent();

            sfDataGrid1.AllowDeleting = true;
            sfDataGrid1.AllowEditing = true;
            sfDataGrid1.AllowSorting = true;
            sfDataGrid1.AllowFiltering = true;
            sfDataGrid1.AllowResizingColumns = true;
            sfDataGrid1.AddNewRowPosition = RowPosition.Top;
            sfDataGrid1.AutoGenerateColumns = false;

            initButtons();

            this.fillResources();
        }

        private void initButtons()
        {
            resourcesButton.BackColor = Color.Wheat;
            usersButton.BackColor = Color.Wheat;
            historyButton.BackColor = Color.Wheat;
            countriesButton.BackColor = Color.Wheat;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fillResources()
        {
            this.sfDataGrid1.DataSource = Resource.getAll();
            resourcesButton.BackColor = Color.LightSkyBlue;
            this.sfDataGrid1.Columns.Clear();
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "id", HeaderText = "ID" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "name", HeaderText = "Название" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "unit", HeaderText = "Eд. измерения" });
        }

        Point lastPoint;

        private void ResourcePage_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ResourcePage_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            sfDataGrid1.DataSource = User.getAll();
            initButtons();
            usersButton.BackColor = Color.LightSkyBlue;
            this.sfDataGrid1.Columns.Clear();
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "id", HeaderText = "ID" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "login", HeaderText = "Логин" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "password", HeaderText = "Пароль" });
        }

        private void resourcesButton_Click(object sender, EventArgs e)
        {
            initButtons();
            fillResources();
        }

        private void countriesButton_Click(object sender, EventArgs e)
        {
            sfDataGrid1.DataSource = Country.getAll();
            initButtons();
            countriesButton.BackColor = Color.LightSkyBlue;
            this.sfDataGrid1.Columns.Clear();
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "id", HeaderText = "ID" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "name", HeaderText = "Название" });
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            sfDataGrid1.DataSource = Consumption.getAll();
            initButtons();
            historyButton.BackColor = Color.LightSkyBlue;
            this.sfDataGrid1.Columns.Clear();
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "countryName", HeaderText = "Страна" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "resourceName", HeaderText = "Ресурс" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "resourceUnit", HeaderText = "Ед. измерения" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "amount", HeaderText = "Количество" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "periodStart", HeaderText = "Начало периода" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "periodEnd", HeaderText = "Конец периода" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var options = new ExcelExportingOptions();
            var excelEngine = sfDataGrid1.ExportToExcel(sfDataGrid1.View, options);
            var workBook = excelEngine.Excel.Workbooks[0];
            workBook.SaveAs("C:\\Users\\Миша\\Downloads\\data.xlsx");
            MessageBox.Show("Успешно сохранено!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var document = this.sfDataGrid1.ExportToPdf();
            document.Save("C:\\Users\\Миша\\Downloads\\data.pdf");
            MessageBox.Show("Успешно сохранено!");
        }
    }
}
