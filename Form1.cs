namespace CSharp_TinhLaiNganHang
{
    public partial class Form1 : Form
    {
        int Gui;
        int Lai;
        int TienLai;
        int Tiennhan;
        public Form1()
        {
            InitializeComponent();
        }
        private void LayThongTin()
        {
            try
            {
                Gui = Convert.ToInt32(txtGui.Text);
                Lai = Convert.ToInt32(txtLai.Text);
            }
            catch
            {
                MessageBox.Show("Phải nhập số thập phân hoặc số nguyên", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGui.Clear();
                txtLai.Clear();
            } 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
