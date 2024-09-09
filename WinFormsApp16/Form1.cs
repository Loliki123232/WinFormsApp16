namespace WinFormsApp16
{
    public partial class Form1 : Form
    {
        private List<Button> buttons;
        public Form1()
        {
            InitializeComponent();
            buttons = new()
            {
                button1,
                button2,
                button3,
                button4,
                button5,
                button6,
                button7,
                button8,
                button9,
                button10,
                button11,
                button12,
                button13,
                button14,
                button15,
                button16
            };

        }
        private int[,] arr = new int[4, 4]
        {
            {1,2, 3, 4, },
            {5,6, 7, 8, },
            {9,10, 11, 12, },
            {13, 14, 15,16},
        };
        private void show()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    buttons[i * 4 + j].Text = arr[i, j].ToString();
                }
            }
        }
        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arr.GetLength(0) * arr.GetLength(1); i++)
            {
                int i1 = new Random().Next(arr.GetLength(0));
                int i2 = new Random().Next(arr.GetLength(0));
                int j1 = new Random().Next(arr.GetLength(1));
                int j2 = new Random().Next(arr.GetLength(1));
                (arr[i1, j1], arr[i2, j2]) = (arr[i2, j2], arr[i1, j1]);
            }
            show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < arr.GetLength(0) * arr.GetLength(1); k++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (j < arr.GetLength(1) - 1)
                        {
                            if (arr[i, j] > arr[i, j + 1])
                                (arr[i, j], arr[i, j + 1]) = (arr[i, j + 1], arr[i, j]);
                        }
                        else
                        {
                            if (i < arr.GetLength(0) - 1)
                            {
                                if (arr[i, j] > arr[i + 1, 0])
                                    (arr[i, j], arr[i + 1, 0]) = (arr[i + 1, 0], arr[i, j]);
                            }
                        }
                    }
                }
            }
            show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = i; j < arr.GetLength(1); j++)
                {
                    (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
                }
            }
            show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    bool isflag = true;
                    for (int x = 2; x < arr[i, j] - 1; x++)
                        if (arr[i,j]%x == 0)
                            isflag = false;
                        if(isflag==true)
                        {
                            if(i<arr.GetLength(0)-1)
                            {
                                arr[i + 1, j] += arr[i, j];
                            }
                            arr[i, j] = 0;
                        }
                }
            }
            for(int k =0;k<3;k++)
            {
                for(int i =arr.GetLength(0)-1;i>0 ;i--)
                {
                    for(int j=0; j<arr.GetLength(1);j++)
                    {
                        if (arr[i,j]==0)
                            (arr[i, j], arr[i-1, j]) = (arr[i-1, j], arr[i, j]);
                    }
                }
            }
            show();
            buttons[15].Size = new(4*50, 4*50);
        }
    }
}
