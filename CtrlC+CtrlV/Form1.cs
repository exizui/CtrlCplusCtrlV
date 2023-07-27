using System.Windows.Forms;

namespace CtrlC_CtrlV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; //позволяем работать клавишам
        }

        private void button1_Click(object sender,EventArgs e)
        {
            string symbolToCopy = textBox1.Text;  //создаем строку и присваеваем ей поле для текста в форме
            Clipboard.SetText(symbolToCopy); //при нажатии кнопки копируеться текст который в поле
            MessageBox.Show($"Текст '{symbolToCopy}' успешно скопирован в буфер обмена."); //отображение сообщения о том что текст скопирован в буфер обмена  
        }
   
        protected override void OnKeyDown(KeyEventArgs e)
        {   
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Z && e.Alt) 
            {              
                button1_Click(null, null); // вызываем метод нажатии кнопки если нажаты заданные клавиши, а также ставим значение null чтобы не было ошибки
            }
        }
    }
}