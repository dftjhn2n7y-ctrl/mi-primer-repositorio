namespace PagoEmpleados;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void BtnCalcular_Click(object sender, EventArgs e)
    {
        string empleado = txtEmpleado.Text.Trim();
        decimal horasTrabajadas = nudHoras.Value;
        decimal pagoPorHora = nudPagoHora.Value;
        decimal bonificacion = nudBonificacion.Value;
        decimal descuento = nudDescuento.Value;

        if (string.IsNullOrWhiteSpace(empleado))
        {
            MessageBox.Show("Escribe el nombre del empleado.", "Dato faltante",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtEmpleado.Focus();
            return;
        }

        if (horasTrabajadas <= 0 || pagoPorHora <= 0)
        {
            MessageBox.Show("Las horas trabajadas y el pago por hora deben ser mayores que cero.",
                "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        decimal horasNormales = Math.Min(horasTrabajadas, 40);
        decimal horasExtra = Math.Max(horasTrabajadas - 40, 0);
        decimal pagoNormal = horasNormales * pagoPorHora;
        decimal pagoExtra = horasExtra * pagoPorHora * 1.5m;
        decimal sueldoBruto = pagoNormal + pagoExtra + bonificacion;
        decimal sueldoNeto = sueldoBruto - descuento;

        lblResultado.Text =
            $"Empleado: {empleado}{Environment.NewLine}" +
            $"Horas normales: {horasNormales:N2}  |  Pago: {pagoNormal:C2}{Environment.NewLine}" +
            $"Horas extra: {horasExtra:N2}  |  Pago extra: {pagoExtra:C2}{Environment.NewLine}" +
            $"Bonificacion: {bonificacion:C2}{Environment.NewLine}" +
            $"Descuento: {descuento:C2}{Environment.NewLine}" +
            $"Total a pagar: {sueldoNeto:C2}";
    }

    private void BtnLimpiar_Click(object sender, EventArgs e)
    {
        txtEmpleado.Clear();
        nudHoras.Value = 0;
        nudPagoHora.Value = 0;
        nudBonificacion.Value = 0;
        nudDescuento.Value = 0;
        lblResultado.Text = "Completa los datos y presiona Calcular.";
        txtEmpleado.Focus();
    }
}
