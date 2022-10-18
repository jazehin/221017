namespace KarakterDekodoloGUI
{
    public partial class FormKarakterDekodoloGUI : Form
    {
        public FormKarakterDekodoloGUI()
        {
            InitializeComponent();
            DynamicAdd();
        }

        private void DynamicAdd()
        {
            TextBox[,] textboxes = new TextBox[7, 4];
            Point startPoint = new Point(50, 50);

            for (int x = 0; x < textboxes.GetLength(0); x++)
            {
                for (int y = 0; y < textboxes.GetLength(1); y++)
                {
                    textboxes[x, y] = new TextBox();
                    textboxes[x, y].Size = new Size(23, 23);
                    textboxes[x, y].Location = new Point(startPoint.X + y * 30, startPoint.Y + x * 30);
                    textboxes[x, y].MaxLength = 1;
                    textboxes[x, y].Text = "0";
                    textboxes[x, y].TextAlign = HorizontalAlignment.Center;
                    textboxes[x, y].TextChanged += new EventHandler(OnTextChanged);
                    textboxes[x, y].Click += new EventHandler(OnClick);
                    textboxes[x, y].Name = $"tb[{x}:{y}]";
                    tlpBottomRow.Controls.Add(textboxes[x, y]);
                }
            }
            

            
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (sender is not TextBox) return;

            if ((sender as TextBox).Text == "1")
                (sender as TextBox).BackColor = Color.LightGray;
            else
                (sender as TextBox).BackColor = Color.White;
        }

        private void OnClick(object sender, EventArgs e)
        {
            if (sender is not TextBox) return;

            if ((sender as TextBox).Text == "1")
                (sender as TextBox).Text = "0";
            else
                (sender as TextBox).Text = "1";
        }

        
    }
}