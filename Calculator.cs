using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Redhwan
{
    /// <summary>
    /// This is a simple calculator program.
    /// Author: Redhwan Ghailan
    ///	Date: 20.01.2023 Sweden
    ///	Email: redhwan.ghailan@gmail.com
    ///	YouTube: itsredhwan
    /// Redhwan Ghailan
    /// 
    /// </summary>
    public class Calculator : System.Windows.Forms.Form
    {
        #region Constructor
        public Calculator()
        {
            InitializeComponent();
        }
        #endregion

        #region Global Variables for UI
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Label label;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        /// <summary>
        ///  These are global variables defined for use in the calculator
        /// </summary>
        private int opMain = 0; /// Stores the value of the operation (1-4)
		private double mainNum1 = 0; ///Stores the value of the first number
		private double mainNum2 = 0; ///Stores the value of the second number
		private bool isSecond = false; //Boolean value used to determine if input is the second or first number.
        private bool isDone = false; ///Boolean value used to determine if the equals key was pressed.
		private bool isDecimal = false; //Boolean value used to determine if there is a decimal in the number.
        #endregion

        #region Dispose
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Set the controls and the properties for them. 
        /// </summary>
        private void InitializeComponent()
        {
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn2.Location = new System.Drawing.Point(164, 74);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(137, 59);
            this.btn2.TabIndex = 13;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn3.Location = new System.Drawing.Point(300, 74);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(137, 59);
            this.btn3.TabIndex = 12;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn0.Location = new System.Drawing.Point(164, 254);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(137, 59);
            this.btn0.TabIndex = 5;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn1.Location = new System.Drawing.Point(29, 74);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(137, 59);
            this.btn1.TabIndex = 14;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn6.Location = new System.Drawing.Point(300, 134);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(137, 59);
            this.btn6.TabIndex = 9;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn7.Location = new System.Drawing.Point(29, 195);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(137, 59);
            this.btn7.TabIndex = 8;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn4.Location = new System.Drawing.Point(29, 134);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(137, 59);
            this.btn4.TabIndex = 11;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(474, 252);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(137, 59);
            this.btnDivide.TabIndex = 2;
            this.btnDivide.TabStop = false;
            this.btnDivide.Text = "/";
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn9.Location = new System.Drawing.Point(300, 195);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(137, 59);
            this.btn9.TabIndex = 6;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(474, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 59);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(474, 133);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(137, 59);
            this.btnSubtract.TabIndex = 4;
            this.btnSubtract.TabStop = false;
            this.btnSubtract.Text = "-";
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(316, 316);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(137, 59);
            this.btnDecimal.TabIndex = 17;
            this.btnDecimal.TabStop = false;
            this.btnDecimal.Text = ".";
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(16, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(137, 59);
            this.btnClear.TabIndex = 0;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "C";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(16, 15);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtResult.Size = new System.Drawing.Size(595, 44);
            this.txtResult.TabIndex = 15;
            this.txtResult.TabStop = false;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(474, 193);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(137, 59);
            this.btnMultiply.TabIndex = 3;
            this.btnMultiply.TabStop = false;
            this.btnMultiply.Text = "*";
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn5.Location = new System.Drawing.Point(164, 134);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(137, 59);
            this.btn5.TabIndex = 10;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn8.Location = new System.Drawing.Point(164, 195);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(137, 59);
            this.btn8.TabIndex = 7;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(474, 316);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(137, 59);
            this.btnEquals.TabIndex = 1;
            this.btnEquals.TabStop = false;
            this.btnEquals.Text = "=";
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegative.Location = new System.Drawing.Point(164, 316);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(137, 59);
            this.btnNegative.TabIndex = 16;
            this.btnNegative.TabStop = false;
            this.btnNegative.Text = "+/-";
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Gold;
            this.label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(84, 395);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(369, 42);
            this.label.TabIndex = 1;
            this.label.Text = "Calculator @itsredhwan";
            // 
            // Calculator
            // 
            this.AcceptButton = this.btnEquals;
            this.AutoScaleBaseSize = new System.Drawing.Size(15, 37);
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(632, 447);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.Text = "Calculator ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Btn_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        ///Custom Methods

        #region setText(String textset)
        /// <summary>
        /// Method to set the text in the textbox to the number entered by the user.
        /// </summary>
        /// <param name="textset"></param>
        public void setText(String textset)
        {
            if (textset.Equals("clear")) //clear button
            {
                txtResult.Text = ""; //Clear the text and reset the boolean variables.
                isDone = false;
                isSecond = false;
                isDecimal = false;

            }
            else
            {
                if (isSecond) //Determine if the number being entered is the begining of the second number. If it is:
                {
                    txtResult.Text = textset; //Start the text over and set the first # to what the user enters
                    isSecond = false; //So Calculator knows to continue the # rather than making a new one.
                    isDecimal = false;
                }
                else
                {
                    if (isDone) //isDone lets the program know that the user just hit "=" and if they press another Number to start a new number.
                    {
                        txtResult.Text = textset;
                        isDone = false; //Set isDone to false so that the number just started is added on to and a new # is not started.

                    }
                    else
                        txtResult.Text += textset; //Simply add on to the existing vlue.

                }
            }

            btnEquals.Select(); //Set the focus back to the "=" button.
        }
        #endregion

        #region Calc(double num1, double num2, int op)
        /// <summary>
        /// Calc takes the 2 numbers and the operation and calcualtes the answer.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="op"></param>
        public void Calc(double num1, double num2, int op)
        {
            double answer = 0;//Initialize answer to 0;
            switch (op)     //Determine which operation to perform depending on the value of "op"
            {
                case 1:
                    answer = num1 + num2;
                    break;
                case 2:
                    answer = num1 - num2;
                    break;
                case 3:
                    answer = num1 * num2;
                    break;
                case 4:
                    answer = num1 / num2;
                    break;
            }

            setText(answer.ToString()); //Show the answer in the textbox;
        }
        #endregion

        #region doEquals()
        /// <summary>
        ///  This method stores the second number, clears the textbox and calls the Calc method
        /// </summary>
        private void doEquals()
        {
            mainNum2 = double.Parse(txtResult.Text);    //Set the value of the second number
            setText("clear"); //Clear the textbox
            Calc(mainNum1, mainNum2, opMain); //Call the Calc method
            isDone = true; //Set isDone to true so that if another # is pressed, the program will begin a new number
        }
        #endregion

        #region changeSign()
        /// <summary>
        /// This method changes the sign of the number.  If the number is positive
        /// it makes it negative and vice versa.
        /// </summary>
        private void changeSign()
        {
            double storNum; //Variable to store value of number
            if (txtResult.Text.Length > 0) //If there is a number...
            {
                storNum = double.Parse(txtResult.Text); //Store its value
                storNum *= -1; //multiply by negative 1
                txtResult.Text = storNum.ToString(); //put it in the textbox.
            }
            btnEquals.Select(); //Set focus to "=" button
        }
        #endregion

        #region setOperator(int operation) 
        /// <summary>
        /// The method is used to store the first number and the operation being performed.
        /// </summary>
        /// <param name="operation"></param>
        private void setOperator(int operation)
        {
            if (txtResult.Text.Length > 0)//Make sure that the user entered a number
            {
                opMain = operation; //Store the operation
                mainNum1 = double.Parse(txtResult.Text); //Store the value of the first number
                isSecond = true; //Let the program know to begin the second number
                isDone = false; //If a operator button is pressed before a new number, let the program know to start a new number.
                btnEquals.Select(); //Set the focus to the equals button.
            }
        }
        #endregion

        #region setDecimal()
        /// <summary>
        /// This method checks to see if the # has a decimal in it.  If not, it
        /// puts one in.  If it does, no decimal is entered.
        /// </summary>
        private void setDecimal()
        {
            if (!isDecimal)//Check for existing decimal
            {
                setText("."); //Add decimal
                isDecimal = true; //Let program know decimal has been added
            }
            btnEquals.Select(); //Set focus to "=" button
        }
        #endregion

        #region KeyBoard Events
        /// <summary>
        /// This method simply determines which key is being pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Btn_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyValue.ToString());
            filterKeys(e.KeyValue);
        }

        /// <summary>
        /// This method accepts the value of the key and calls the corresponding methods.
        /// It is pretty self-explanatory.
        /// </summary>
        /// <param name="keyCode"></param>
        public void filterKeys(int keyCode)
        {
            switch (keyCode)
            {
                case 96:
                    setText("0");
                    break;
                case 97:
                    setText("1");
                    break;
                case 98:
                    setText("2");
                    break;
                case 99:
                    setText("3");
                    break;
                case 100:
                    setText("4");
                    break;
                case 101:
                    setText("5");
                    break;
                case 102:
                    setText("6");
                    break;
                case 103:
                    setText("7");
                    break;
                case 104:
                    setText("8");
                    break;
                case 105:
                    setText("9");
                    break;
                case 67:
                    setText("clear");
                    break;
                case 107:
                    setOperator(1);
                    break;
                case 109:
                    setOperator(2);
                    break;
                case 106:
                    setOperator(3);
                    break;
                case 111:
                    setOperator(4);
                    break;
                case 110:
                    setDecimal();
                    break;
            }
        }
        #endregion

        #region Button Functions
        ///These methods do the same as when a key is pressed except the respond to the 
        ///mouse clicks on the different controls.  These are the methods that were mapped to 
        ///the controls up top.

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            setOperator(1);
        }

        private void btn1_Click_1(object sender, System.EventArgs e)
        {
            setText("1");
        }

        private void btn2_Click(object sender, System.EventArgs e)
        {
            setText("2");
        }

        private void btn3_Click(object sender, System.EventArgs e)
        {
            setText("3");
        }

        private void btn4_Click(object sender, System.EventArgs e)
        {
            setText("4");
        }

        private void btn5_Click(object sender, System.EventArgs e)
        {
            setText("5");
        }

        private void btn6_Click(object sender, System.EventArgs e)
        {
            setText("6");
        }

        private void btn7_Click(object sender, System.EventArgs e)
        {
            setText("7");
        }

        private void btn8_Click(object sender, System.EventArgs e)
        {
            setText("8");
        }

        private void btn9_Click(object sender, System.EventArgs e)
        {
            setText("9");
        }

        private void btn0_Click(object sender, System.EventArgs e)
        {
            setText("0");
        }

        private void btnEquals_Click(object sender, System.EventArgs e)
        {
            doEquals();
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            isSecond = false;
            setText("clear");
        }


        private void btnSubtract_Click(object sender, System.EventArgs e)
        {
            setOperator(2);
        }

        private void btnMultiply_Click(object sender, System.EventArgs e)
        {
            setOperator(3);
        }

        private void btnDivide_Click(object sender, System.EventArgs e)
        {
            setOperator(4);
        }

        private void btnNegative_Click(object sender, System.EventArgs e)
        {
            changeSign();
        }

        private void btnDecimal_Click(object sender, System.EventArgs e)
        {
            setDecimal();
        }
        #endregion

        //#region Main()
        ///// <summary>
        ///// The main entry point for the application.
        ///// </summary>
        //[STAThread]

        //static void Main()
        //{
        //    Application.Run(new Calculator1());
        //}
        //#endregion
    }
}

