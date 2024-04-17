# AC3

## Prompts IA: 

Prompt 1:

private void MostrarSiguientes10Lineas()

Respuesta: 

private void MostrarSiguientes10Lineas()
{
    int lineasAMostrar = 10;
    var lineasRestantes = comarcas.Skip(lineaActual).Take(lineasAMostrar).ToList();
    Cuadro.DataSource = lineasRestantes;
    Cuadro.Columns[1].Visible = false;
    lineaActual += lineasAMostrar;
}

Prompt 2:

tengo un datagrid view de un windows forms. Tambíen tengo un csv de este tipo: Any,Codi comarca,Comarca,Població,Domèstic xarxa,Activitats econòmiques i fonts pròpies,Total,Consum domèstic per càpita
2022,1,"ALT CAMP, L'",45540,1685688,3040038,4725726,101.41
2022,2,"ALT EMPORDÀ, L'",144926,8593650,4831755,13425405,162.46
2022,3,"ALT PENEDÈS, L'",110929,4533398,3262053,7795451,111.97. Y tengo una clase helper. Quiero que me hagas un método que me parse el csv y me lo muestre en el datagrid incluyendo las columnas

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

public class CsvHelper
{
    public static void MostrarCsvEnDataGridView(string rutaCsv, DataGridView dataGridView)
    {
        // Limpiamos el DataGridView antes de cargar nuevos datos
        dataGridView.Rows.Clear();
        dataGridView.Columns.Clear();

        // Leemos todas las líneas del archivo CSV
        string[] lineas = File.ReadAllLines(rutaCsv);

        // Asumimos que la primera línea contiene los encabezados de las columnas
        if (lineas.Length > 0)
        {
            string[] encabezados = lineas[0].Split(',');

            // Creamos las columnas del DataGridView basadas en los encabezados del CSV
            foreach (string encabezado in encabezados)
            {
                dataGridView.Columns.Add(encabezado, encabezado);
            }

            // Iteramos sobre las líneas restantes del CSV para llenar el DataGridView
            for (int i = 1; i < lineas.Length; i++)
            {
                string[] campos = lineas[i].Split(',');
                dataGridView.Rows.Add(campos);
            }
        }
    }
}
