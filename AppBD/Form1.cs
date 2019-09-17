using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBD
{
    public partial class frmAppBD : Form
    {
        

        public frmAppBD()
        {
            
            InitializeComponent();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnLayMa.Enabled = false;
            btnTimTheoTen.Enabled = false;
            btnTimTheoGio.Enabled = false;
            btnTimTheoNgay.Enabled = false;

        }
        public void HienThi()
        {
            
            dtgvThongTin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvThongTin.DataSource = getThongTin().Tables[0];
        }
        private void BtnXem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //btnTim.Enabled = true;
            btnLayMa.Enabled = true;
            btnTimTheoTen.Enabled = true;
            btnTimTheoGio.Enabled = true;
            btnTimTheoNgay.Enabled = true;
            HienThi();
            
        }
        public static string convertToUnSign(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
        public string LayMaKH()
        {
            string layma = "", ten = " ", gio = "", ngay = "", thang = "";
            if (String.Compare("Chú Trúc", txtTenKH.Text, true) == 0) { ten = "Atr"; }
            else if (String.Compare("Chị Trúc", txtTenKH.Text, true) == 0) { ten = "Ctr"; }
            else if (String.Compare("Chị Kem", txtTenKH.Text, true) == 0) { ten = "CK"; }
            else if (String.Compare("Chị Thiêu", txtTenKH.Text, true) == 0) { ten = "CTh"; }
            else
            {
                string[] arr = txtTenKH.Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                ten = arr[arr.Length - 1];
            }
            if ((Convert.ToInt32(txtGioLay.Text) > 10)) { gio = txtGioLay.Text; }
            else { gio = "0" + txtGioLay.Text; }
            //ngay = Convert.ToString(dtpNgayLay.DataBindings.da);
            DateTime dt = dtpNgayLay.Value;
            ngay = Convert.ToString(dt.Day);
            if (dt.Month < 10) { thang = "0" + Convert.ToString(dt.Month); }
            else { thang = Convert.ToString(dt.Month); }
            layma = convertToUnSign(ten) + "_" + gio + "_" + ngay + "_" + thang;
            
            
            return layma; 
        }
        
        public int checkedIn(string CheckIn)
        {
            int temp = 0;
            if (!Int32.TryParse(CheckIn, out temp))
                return 1;
            return 0;
        }
        public void resetForm()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = " ";
            txtGhiChu.Text = "";
            //nbGioLay.Value = 1;
            txtGioLay.Text = "";
            dtpNgayLay.Value = DateTime.Now;
            txtGia.Text = "";
            txtSL.Text = "";
        }
        DataSet getThongTin()
        {
            DataSet data = new DataSet();
            string query = "SELECT MaKH, TenKH, GhiChu, GioLay, NgayLay , DonGia, SoLuong, DonGia * SoLuong AS ThanhTien FROM BD"; 
            //Sql Connection
            using (SqlConnection connection = new SqlConnection(AppBD.Connection.ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
       // public void xem() { txtMaKH.Text = LayMaKH(); MessageBox.Show(txtMaKH.Text); }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            string sqlAdd = "insert into BD values(@MaKH,@TenKH,@GhiChu,@GioLay,@NgayLay,@DonGia,@SoLuong)";

            using (SqlConnection connection = new SqlConnection(AppBD.Connection.ConnectionString.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlAdd, connection);
                    command.Parameters.AddWithValue("MaKH", txtMaKH.Text);
                    command.Parameters.AddWithValue("TenKH", txtTenKH.Text);
                    command.Parameters.AddWithValue("GhiChu", txtGhiChu.Text);
                    if (checkedIn(txtGioLay.Text) == 1) { MessageBox.Show("Vui lòng nhập lại giờ lấy"); }
                    else
                    {
                        command.Parameters.AddWithValue("GioLay", Convert.ToInt32(txtGioLay.Text));
                        if (Convert.ToInt32(txtGioLay.Text) < 1 || Convert.ToInt32(txtGioLay.Text) > 23) { MessageBox.Show("Vui lòng nhập giờ (lớn hơn 0 hoặc nhỏ hơn 24)"); }
                        else
                        {
                            command.Parameters.AddWithValue("NgayLay", dtpNgayLay.Value);
                            if (checkedIn(txtGia.Text) == 1) { MessageBox.Show("Vui lòng nhập lại đơn giá"); }
                            else
                            {
                                command.Parameters.AddWithValue("DonGia", txtGia.Text);
                                if (checkedIn(txtSL.Text) == 1) { MessageBox.Show("Vui lòng nhập lại số lượng"); }
                                else
                                {
                                    command.Parameters.AddWithValue("SoLuong", txtSL.Text);
                                    //command.Parameters.AddWithValue("DonGia*SoLuong", "@DonGia*@SoLuong"  );
                                    //if (checkedIn(txtSL.Text) == 1||checkedIn(txtGia.Text)==1) { MessageBox.Show("Vui lòng nhập lại số lượng hoặc đơn giá"); }
                                    // if (KtTrungKhoa(txtMaKH.Text, sqlAdd) == true) { MessageBox.Show("Trùng khóa chính. Vui lòng nhập lại mã KH"); }




                                    command.ExecuteNonQuery();

                                    HienThi();
                                    resetForm();
                                    btnThem.Enabled = false;
                                    connection.Close();
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Trùng khóa chính. Vui lòng nhập lại Tên KH hoặc Ngày Lấy hoặc Giờ Lấy. Nếu trùng tên thi thêm sô ở sau tên");
                    }
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnLayMa.Enabled = false;
            btnTimTheoTen.Enabled = false;
            btnTimTheoGio.Enabled = false;
            btnTimTheoNgay.Enabled = false;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string sqlDelete = "delete from BD where MaKH=@MaKH ";

            using (SqlConnection connection = new SqlConnection(AppBD.Connection.ConnectionString.connectionString))
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa !","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Error)==DialogResult.Yes) {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlDelete, connection);
                    command.Parameters.AddWithValue("MaKH", txtMaKH.Text);
                    command.ExecuteNonQuery();
                    HienThi();
                    resetForm();
                    connection.Close();
                }
            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {

            string sqlEdit = "Update BD set TenKH=@TenKH, GhiChu=@GhiChu, GioLay=@GioLay, NgayLay=@NgayLay, SoLuong=@SoLuong, DonGia=@DonGia where MaKH=@MaKH";

            using (SqlConnection connection = new SqlConnection(AppBD.Connection.ConnectionString.connectionString))
            {
                try
                {
<<<<<<< HEAD
                    if (MessageBox.Show("Bạn chắc chắn muốn xóa !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        connection.Open();
=======
                    connection.Open();
>>>>>>> 6c3278dd1e2e6a3b8441c6f4c7de1094c0ea9806
                    SqlCommand command = new SqlCommand(sqlEdit, connection);
                    command.Parameters.AddWithValue("MaKH", txtMaKH.Text);
                    command.Parameters.AddWithValue("TenKH", txtTenKH.Text);
                    command.Parameters.AddWithValue("GhiChu", txtGhiChu.Text);
                    if (checkedIn(txtGioLay.Text) == 1) { MessageBox.Show("Vui lòng nhập lại giờ lấy"); }
                    else
                    {
                        command.Parameters.AddWithValue("GioLay", Convert.ToInt32(txtGioLay.Text));
<<<<<<< HEAD
                            if (Convert.ToInt32(txtGioLay.Text) < 1 || Convert.ToInt32(txtGioLay.Text) > 23) { MessageBox.Show("Vui lòng nhập giờ (lớn hơn 0 hoặc nhỏ hơn 24)"); }
                            else
                            {
                                command.Parameters.AddWithValue("NgayLay", dtpNgayLay.Value);
                                if (checkedIn(txtGia.Text) == 1) { MessageBox.Show("Vui lòng nhập lại đơn giá"); }
                                else
                                {
                                    command.Parameters.AddWithValue("DonGia", txtGia.Text);
                                    if (checkedIn(txtSL.Text) == 1) { MessageBox.Show("Vui lòng nhập lại số lượng"); }
                                    else
                                    {
                                        command.Parameters.AddWithValue("SoLuong", txtSL.Text);
                                        //command.Parameters.AddWithValue("DonGia*SoLuong", "@DonGia*@SoLuong"  );
                                        //if (checkedIn(txtSL.Text) == 1||checkedIn(txtGia.Text)==1) { MessageBox.Show("Vui lòng nhập lại số lượng hoặc đơn giá"); }
                                        // if (KtTrungKhoa(txtMaKH.Text, sqlAdd) == true) { MessageBox.Show("Trùng khóa chính. Vui lòng nhập lại mã KH"); }




                                        command.ExecuteNonQuery();

                                        HienThi();
                                        resetForm();
                                        btnThem.Enabled = true;
                                        btnXem.Enabled = true;
                                        btnXoa.Enabled = true;
                                        btnLuu.Enabled = false;
                                        btnSua.Enabled = true;
                                        btnLayMa.Enabled = true;
                                        btnTimTheoTen.Enabled = true;
                                        btnTimTheoGio.Enabled = true;
                                        btnTimTheoNgay.Enabled = true;
                                        connection.Close();
                                    }
=======
                        if (Convert.ToInt32(txtGioLay.Text) < 1 || Convert.ToInt32(txtGioLay.Text) > 23) { MessageBox.Show("Vui lòng nhập giờ (lớn hơn 0 hoặc nhỏ hơn 24)"); }
                        else
                        {
                            command.Parameters.AddWithValue("NgayLay", dtpNgayLay.Value);
                            if (checkedIn(txtGia.Text) == 1) { MessageBox.Show("Vui lòng nhập lại đơn giá"); }
                            else
                            {
                                command.Parameters.AddWithValue("DonGia", txtGia.Text);
                                if (checkedIn(txtSL.Text) == 1) { MessageBox.Show("Vui lòng nhập lại số lượng"); }
                                else
                                {
                                    command.Parameters.AddWithValue("SoLuong", txtSL.Text);
                                    //command.Parameters.AddWithValue("DonGia*SoLuong", "@DonGia*@SoLuong"  );
                                    //if (checkedIn(txtSL.Text) == 1||checkedIn(txtGia.Text)==1) { MessageBox.Show("Vui lòng nhập lại số lượng hoặc đơn giá"); }
                                    // if (KtTrungKhoa(txtMaKH.Text, sqlAdd) == true) { MessageBox.Show("Trùng khóa chính. Vui lòng nhập lại mã KH"); }




                                    command.ExecuteNonQuery();

                                    HienThi();
                                    resetForm();
                                    btnThem.Enabled = true;
                                    btnXem.Enabled = true;
                                    btnXoa.Enabled = true;
                                    btnLuu.Enabled = false;
                                    btnSua.Enabled = true;
                                    btnLayMa.Enabled = true;
                                    btnTimTheoTen.Enabled = true;
                                    btnTimTheoGio.Enabled = true;
                                    btnTimTheoNgay.Enabled = true;
                                    connection.Close();
>>>>>>> 6c3278dd1e2e6a3b8441c6f4c7de1094c0ea9806
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Trùng khóa chính. Vui lòng nhập lại Tên KH hoặc Ngày Lấy hoặc Giờ Lấy. Nếu trùng tên thi thêm sô ở sau tên");
                    }
                }
            }
            
        }

        private void DtgvThongTin_SelectionChanged(object sender, EventArgs e)
        {
            int VT = dtgvThongTin.CurrentCell.RowIndex;
            LoadTT(VT);
        }

        private void LoadTT(int VT)
        {
            try
            {
                if (string.Compare(dtgvThongTin.Rows[VT].Cells[0].Value.ToString(), " ")==1)
                {
                    //throw new NotImplementedException();
                    txtMaKH.Text = dtgvThongTin.Rows[VT].Cells[0].Value.ToString().Trim();
                    txtTenKH.Text = dtgvThongTin.Rows[VT].Cells[1].Value.ToString().Trim();
                    txtGhiChu.Text = dtgvThongTin.Rows[VT].Cells[2].Value.ToString().Trim();
                    //nbGioLay.Value = Convert.ToDecimal(dtgvThongTin.Rows[VT].Cells[3].Value.ToString());
                    txtGioLay.Text = dtgvThongTin.Rows[VT].Cells[3].Value.ToString().Trim();
                    dtpNgayLay.Value = Convert.ToDateTime(dtgvThongTin.Rows[VT].Cells[4].Value.ToString());
                    txtGia.Text = dtgvThongTin.Rows[VT].Cells[5].Value.ToString().Trim();
                    txtSL.Text = dtgvThongTin.Rows[VT].Cells[6].Value.ToString().Trim();
                }
                else { MessageBox.Show("Vui lòng chọn dòng khác!"); }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.StackTrace);
            }
        }

        private void BtnLayMa_Click(object sender, EventArgs e)
        {
            txtMaKH.Text= LayMaKH();
            // LayMaKH() = txtMaKH.Text;
            btnThem.Enabled = true;
        }

        private void BtnDatLai_Click(object sender, EventArgs e)
        {
            
            resetForm();
            

        }

        private void BtnTimTheoTen_Click(object sender, EventArgs e)
        {
            string sqlSearchTen = "select * from BD where TenKH LIKE '%'+@TenKH + '%' ";
            using (SqlConnection connection = new SqlConnection(AppBD.Connection.ConnectionString.connectionString))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlSearchTen, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.Parameters.AddWithValue("TenKH", txtTimTheoTen.Text);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgvThongTin.DataSource = dataTable;
                resetForm();
            }
        }

        private void BtnTimTheoGio_Click(object sender, EventArgs e)
        {
            string sqlSearchGio = "select * from BD where  GioLay=@GioLay  ";
            using (SqlConnection connection = new SqlConnection(AppBD.Connection.ConnectionString.connectionString))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlSearchGio, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
               // command.Parameters.AddWithValue("TenKH", txtTenKH.Text);
                command.Parameters.AddWithValue("GioLay", nbTimTheoGio.Value);
                //command.Parameters.AddWithValue("NgayLay", dtpNgayLay.Value);
                //command.Parameters.AddWithValue("DonGia*SoLuong", "@DonGia*@SoLuong"  );
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgvThongTin.DataSource = dataTable;
                resetForm();
            }
        }

        private void BtnTimTheoNgay_Click(object sender, EventArgs e)
        {
            string sqlSearchNgay = "select * from BD where NgayLay=@NgayLay ";
            using (SqlConnection connection = new SqlConnection(AppBD.Connection.ConnectionString.connectionString))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(sqlSearchNgay, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                //command.Parameters.AddWithValue("TenKH", txtTenKH.Text);
                //command.Parameters.AddWithValue("GioLay", Convert.ToInt32(txtGioLay.Text));
                command.Parameters.AddWithValue("NgayLay", Convert.ToString( dtpTimTheoNgay.Value));
                //command.Parameters.AddWithValue("DonGia*SoLuong", "@DonGia*@SoLuong"  );
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgvThongTin.DataSource = dataTable;
                resetForm();
            }
        }











        /*private void Button1_Click(object sender, EventArgs e)
        {
            xem();
        }*/
    }
}
