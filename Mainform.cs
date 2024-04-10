namespace _24PointGame
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void button_about_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            CalculateMode cal = new CalculateMode();
            cal.ShowDialog();
        }

        private void button_trick_Click(object sender, EventArgs e)
        {
            GameMode game = new GameMode();
            game.ShowDialog();
        }

        private void button_data_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            record.ShowDialog();
        }
    }
}