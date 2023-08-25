using System;
using System.Windows.Forms; // Necesario para Application.Run
using LiveCharts;


namespace ConsoleChartExample
{
    class Program
    {
        [STAThread] // Requerido para usar Application.Run
        static void Main(string[] args)
        {
            // Crear el gráfico de líneas
            var chart = new CartesianChart
            {
                Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title = "Tendencia",
                        Values = new ChartValues<double> { 10, 20, 30, 40, 50 } // Datos de ejemplo
                    }
                }
            };

            // Crear una ventana de formulario para mostrar el gráfico
            var form = new Form
            {
                Text = "Gráfico de Tendencias",
                Width = 800,
                Height = 600
            };
            form.Controls.Add(chart);

            // Mostrar la ventana del formulario
            Application.Run(form);
        }
    }
}