using System.Linq.Expressions;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private Model model;
        int countStartProgramm = 0;
        public Form1()
        {
            InitializeComponent();
            model = new Model();
            model.observers += update_from_model;
            this.update_from_model(this, null);

        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            int previous_number = model.getB();
            if (e.KeyCode == Keys.Enter)
                if (sender == textBox_A)
                    model.setA(int.Parse(textBox_A.Text));
                else if (sender == textBox_B)
                    model.setB(int.Parse(textBox_B.Text), previous_number);
                else
                    model.setC(int.Parse(textBox_C.Text));
        }

        private void numericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            int previous_number = model.getB();
            if (e.KeyCode == Keys.Enter)
                if (sender == numericUpDown_A)
                    model.setA(Decimal.ToInt32(numericUpDown_A.Value));
                else if (sender == numericUpDown_B)
                    model.setB(Decimal.ToInt32(numericUpDown_B.Value), previous_number);
                else
                    model.setC(Decimal.ToInt32(numericUpDown_C.Value));
        }
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            int previous_number = model.getB();
            if (sender == trackBar_A)
                model.setA(Decimal.ToInt32(trackBar_A.Value) * 10);
            else if (sender == trackBar_B)
                model.setB(Decimal.ToInt32(trackBar_B.Value) * 10, previous_number);
            else
                model.setC(Decimal.ToInt32(trackBar_C.Value) * 10);
        }

        public void update_from_model(object sender, EventArgs e)
        {

            delete_or_add_func(true);
            textBox_A.Text = model.getA().ToString();
            textBox_B.Text = model.getB().ToString();
            textBox_C.Text = model.getC().ToString();
            numericUpDown_A.Value = model.getA();
            numericUpDown_A.Text = model.getA().ToString();
            numericUpDown_B.Value = model.getB();
            numericUpDown_B.Text = model.getB().ToString();
            numericUpDown_C.Value = model.getC();
            numericUpDown_C.Text = model.getC().ToString();
            trackBar_A.Value = model.getA() / 10;
            trackBar_B.Value = model.getB() / 10;
            trackBar_C.Value = model.getC() / 10;
            model.save();
            delete_or_add_func(false);

        }

        public void delete_or_add_func(bool option) 
        {
            if (option)
            {
                numericUpDown_A.ValueChanged -= numericUpDown_ValueChanged;
                numericUpDown_B.ValueChanged -= numericUpDown_ValueChanged;
                numericUpDown_C.ValueChanged -= numericUpDown_ValueChanged;
            }
            else
            {
                numericUpDown_A.ValueChanged += numericUpDown_ValueChanged;
                numericUpDown_B.ValueChanged += numericUpDown_ValueChanged;
                numericUpDown_C.ValueChanged += numericUpDown_ValueChanged;
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int previous_number = model.getB();
            if (sender == numericUpDown_A)
                model.setA(Decimal.ToInt32(numericUpDown_A.Value));
            else if (sender == numericUpDown_B)
                model.setB(Decimal.ToInt32(numericUpDown_B.Value), previous_number);
            else
                model.setC(Decimal.ToInt32(numericUpDown_C.Value));

        }

        private void element_Leave(object sender, EventArgs e)
        {
            this.update_from_model(this, null);
        }
    }

    class Model
    {
        private int A;
        private int B;
        private int C;
        public System.EventHandler? observers;

        public Model()
        {
            A = Properties.Settings.Default.a_value;
            B = Properties.Settings.Default.b_value;
            C = Properties.Settings.Default.c_value;
        }

        public void change_value(ref int value)
        {
            if (value > 100) value = 100;
            else if (value < 0) value = 0;
        }
        public void setA(int value)
        {
            change_value(ref value);
            if (value > B)
            {
                B = value;
                if (B > C) C = B;
            }
            A = value;
            observers.Invoke(this, null);
        }

        public void setC(int value)
        {
            change_value(ref value);
            if (value < B)
            {
                B = value;
                if (B<A)  A = value;
            }
            C = value;
            observers.Invoke(this, null);
        }

        public void setB(int value, int previous_number)
        {
            change_value(ref value);
            if (value > C || value < A) B = previous_number;
            else B = value;
            observers.Invoke(this, null);
        }

        public void save()
        {
            Properties.Settings.Default.a_value = A;
            Properties.Settings.Default.b_value = B;
            Properties.Settings.Default.c_value = C;
            Properties.Settings.Default.Save();

        }

        public int getA() { return A; }
        public int getB() { return B; }
        public int getC() { return C; }
    }
}
