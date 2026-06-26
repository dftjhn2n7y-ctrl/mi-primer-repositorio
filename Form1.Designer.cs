namespace PagoEmpleados;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblTitulo = new Label();
        lblEmpleado = new Label();
        txtEmpleado = new TextBox();
        lblHoras = new Label();
        nudHoras = new NumericUpDown();
        lblPagoHora = new Label();
        nudPagoHora = new NumericUpDown();
        lblBonificacion = new Label();
        nudBonificacion = new NumericUpDown();
        lblDescuento = new Label();
        nudDescuento = new NumericUpDown();
        btnCalcular = new Button();
        btnLimpiar = new Button();
        grpResultado = new GroupBox();
        lblResultado = new Label();
        ((System.ComponentModel.ISupportInitialize)nudHoras).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudPagoHora).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudBonificacion).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudDescuento).BeginInit();
        grpResultado.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitulo
        // 
        lblTitulo.AutoSize = true;
        lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitulo.Location = new Point(28, 24);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(364, 32);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Calculo de pago de empleados";
        // 
        // lblEmpleado
        // 
        lblEmpleado.AutoSize = true;
        lblEmpleado.Location = new Point(32, 82);
        lblEmpleado.Name = "lblEmpleado";
        lblEmpleado.Size = new Size(124, 15);
        lblEmpleado.TabIndex = 1;
        lblEmpleado.Text = "Nombre del empleado";
        // 
        // txtEmpleado
        // 
        txtEmpleado.Location = new Point(32, 104);
        txtEmpleado.Name = "txtEmpleado";
        txtEmpleado.Size = new Size(316, 23);
        txtEmpleado.TabIndex = 2;
        // 
        // lblHoras
        // 
        lblHoras.AutoSize = true;
        lblHoras.Location = new Point(32, 148);
        lblHoras.Name = "lblHoras";
        lblHoras.Size = new Size(103, 15);
        lblHoras.TabIndex = 3;
        lblHoras.Text = "Horas trabajadas";
        // 
        // nudHoras
        // 
        nudHoras.DecimalPlaces = 2;
        nudHoras.Location = new Point(32, 170);
        nudHoras.Maximum = new decimal(new int[] { 168, 0, 0, 0 });
        nudHoras.Name = "nudHoras";
        nudHoras.Size = new Size(140, 23);
        nudHoras.TabIndex = 4;
        // 
        // lblPagoHora
        // 
        lblPagoHora.AutoSize = true;
        lblPagoHora.Location = new Point(208, 148);
        lblPagoHora.Name = "lblPagoHora";
        lblPagoHora.Size = new Size(80, 15);
        lblPagoHora.TabIndex = 5;
        lblPagoHora.Text = "Pago por hora";
        // 
        // nudPagoHora
        // 
        nudPagoHora.DecimalPlaces = 2;
        nudPagoHora.Location = new Point(208, 170);
        nudPagoHora.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        nudPagoHora.Name = "nudPagoHora";
        nudPagoHora.Size = new Size(140, 23);
        nudPagoHora.TabIndex = 6;
        nudPagoHora.ThousandsSeparator = true;
        // 
        // lblBonificacion
        // 
        lblBonificacion.AutoSize = true;
        lblBonificacion.Location = new Point(32, 214);
        lblBonificacion.Name = "lblBonificacion";
        lblBonificacion.Size = new Size(75, 15);
        lblBonificacion.TabIndex = 7;
        lblBonificacion.Text = "Bonificacion";
        // 
        // nudBonificacion
        // 
        nudBonificacion.DecimalPlaces = 2;
        nudBonificacion.Location = new Point(32, 236);
        nudBonificacion.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        nudBonificacion.Name = "nudBonificacion";
        nudBonificacion.Size = new Size(140, 23);
        nudBonificacion.TabIndex = 8;
        nudBonificacion.ThousandsSeparator = true;
        // 
        // lblDescuento
        // 
        lblDescuento.AutoSize = true;
        lblDescuento.Location = new Point(208, 214);
        lblDescuento.Name = "lblDescuento";
        lblDescuento.Size = new Size(64, 15);
        lblDescuento.TabIndex = 9;
        lblDescuento.Text = "Descuento";
        // 
        // nudDescuento
        // 
        nudDescuento.DecimalPlaces = 2;
        nudDescuento.Location = new Point(208, 236);
        nudDescuento.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        nudDescuento.Name = "nudDescuento";
        nudDescuento.Size = new Size(140, 23);
        nudDescuento.TabIndex = 10;
        nudDescuento.ThousandsSeparator = true;
        // 
        // btnCalcular
        // 
        btnCalcular.BackColor = Color.FromArgb(30, 116, 70);
        btnCalcular.FlatStyle = FlatStyle.Flat;
        btnCalcular.ForeColor = Color.White;
        btnCalcular.Location = new Point(32, 292);
        btnCalcular.Name = "btnCalcular";
        btnCalcular.Size = new Size(150, 36);
        btnCalcular.TabIndex = 11;
        btnCalcular.Text = "Calcular";
        btnCalcular.UseVisualStyleBackColor = false;
        btnCalcular.Click += BtnCalcular_Click;
        // 
        // btnLimpiar
        // 
        btnLimpiar.Location = new Point(198, 292);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(150, 36);
        btnLimpiar.TabIndex = 12;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.UseVisualStyleBackColor = true;
        btnLimpiar.Click += BtnLimpiar_Click;
        // 
        // grpResultado
        // 
        grpResultado.Controls.Add(lblResultado);
        grpResultado.Location = new Point(388, 82);
        grpResultado.Name = "grpResultado";
        grpResultado.Size = new Size(360, 246);
        grpResultado.TabIndex = 13;
        grpResultado.TabStop = false;
        grpResultado.Text = "Resultado";
        // 
        // lblResultado
        // 
        lblResultado.Font = new Font("Segoe UI", 10F);
        lblResultado.Location = new Point(18, 32);
        lblResultado.Name = "lblResultado";
        lblResultado.Size = new Size(324, 190);
        lblResultado.TabIndex = 0;
        lblResultado.Text = "Completa los datos y presiona Calcular.";
        // 
        // Form1
        // 
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(248, 249, 251);
        ClientSize = new Size(784, 371);
        Controls.Add(grpResultado);
        Controls.Add(btnLimpiar);
        Controls.Add(btnCalcular);
        Controls.Add(nudDescuento);
        Controls.Add(lblDescuento);
        Controls.Add(nudBonificacion);
        Controls.Add(lblBonificacion);
        Controls.Add(nudPagoHora);
        Controls.Add(lblPagoHora);
        Controls.Add(nudHoras);
        Controls.Add(lblHoras);
        Controls.Add(txtEmpleado);
        Controls.Add(lblEmpleado);
        Controls.Add(lblTitulo);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Pago de empleados";
        ((System.ComponentModel.ISupportInitialize)nudHoras).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudPagoHora).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudBonificacion).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudDescuento).EndInit();
        grpResultado.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblTitulo;
    private Label lblEmpleado;
    private TextBox txtEmpleado;
    private Label lblHoras;
    private NumericUpDown nudHoras;
    private Label lblPagoHora;
    private NumericUpDown nudPagoHora;
    private Label lblBonificacion;
    private NumericUpDown nudBonificacion;
    private Label lblDescuento;
    private NumericUpDown nudDescuento;
    private Button btnCalcular;
    private Button btnLimpiar;
    private GroupBox grpResultado;
    private Label lblResultado;
}
