namespace KarakterDekodoloGUI
{
    public partial class Form1 : Form
    {
        public Form1()
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
                    textboxes[x, y].Enabled = false;
                    textboxes[x, y].MaxLength = 1;
                    Controls.Add(textboxes[x, y]);
                }
            }

            
        }
    }
}