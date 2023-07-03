using System.Net;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using System; 

namespace E14_TP1_2210043_v2
{
    public partial class Form1 : Form
    {
        // ########################## GLOBALS ########################## \\
        static Excel.Application? excelApp;
        static Excel.Workbook? excelBook;
        static Excel.Worksheet? excelSheet;
        static Excel.Range? excelRange;


        // ########################## INITS ########################## \\
        public Form1()
        {
            InitializeComponent();
        }


        // ########################## EVENTS ########################## \\

        private void Form1_Load(object sender, EventArgs e)
        {
            excelApp = new Excel.Application();

            if (excelApp == null){
                MessageBox.Show("Excel doit etre installé pour utiliser cette application.");
                Application.Exit();
            }

            try
            {   
                excelBook = excelApp?.Workbooks.Open(AppContext.BaseDirectory + "ListePatineurs.xlsx");
                excelSheet = excelBook?.Worksheets[1];
                excelRange = excelSheet!.UsedRange;
            }
            catch (Exception ex)
            {   
                MessageBox.Show("Une erreur est survenue: " + ex.Message);
                CloseExcel();
                Application.Exit();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseExcel();
        }


        // ########################## CLICK - EVENTS ########################## \\

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // count des ligne et colonnes
            long lastRow = excelRange.Rows.Count;
            long lastCol = excelRange.Columns.Count;

            //count des ligne non-null
            int rowTotal = 0;
            for (int i = 1; i < lastRow; i++)
            {
                if (excelRange.Cells[i, 1].Value != null)
                {
                    rowTotal++;
                }
            }

            //count des colonnes non-null
            int colTotal = 0;
            for (int i = 1; i < lastCol; i++)
            {
                if (excelRange.Cells[1, i].Value != null)
                {
                    colTotal++;
                }
            }

            // un for pour le premier listView
            for (int i = 1; i < rowTotal; i += 4)
            {
                string current = excelRange.Cells[i, 1].Value;
                current = current.Replace(",", "");
                if(current == null)
                {
                    continue;
                }
                else
                {
                    string[] splitCurrent = current.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    listView1.Items.Add(new ListViewItem(splitCurrent));
                }
            }

            string NoPatineur = "";
            // un for pour le deuxieme listView
            for (int i = 1; i <= rowTotal; i++)
            {
                excelRange = excelSheet!.get_Range("A" + i.ToString(), "J" + i.ToString());
                Array myvalues = (Array)excelRange.Cells.Value;
                string[] strArray = ConvertToStringArray(myvalues);

                if (strArray[1] == "")
                {
                    string? str1 = strArray[0].ToString();
                    if (str1 == null)
                    {
                        NoPatineur = "";
                    }
                    else
                    {
                        NoPatineur = str1.Substring(0, 2);
                    }
                    continue;
                }

                strArray[6] = strArray[5];
                strArray[5] = strArray[2];
                strArray[2] = strArray[1];
                strArray[1] = strArray[0];
                strArray[0] = NoPatineur;
                listView2.Items.Add(new ListViewItem(strArray));
            }
        }


        // ########################## PROCEDURES ########################## \\

        private void CloseExcel()
        {
            // fermer et quitter
            excelBook?.Close();
            excelApp?.Quit();

            // garbage collector
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // liberer les com objects
            if (excelRange != null) Marshal.ReleaseComObject(excelRange);
            if (excelSheet != null) Marshal.ReleaseComObject(excelSheet);
            if (excelBook != null) Marshal.ReleaseComObject(excelBook);
            if (excelApp != null) Marshal.ReleaseComObject(excelApp);
        }

        
        // ########################## FONCTIONS ########################## \\

        string[] ConvertToStringArray(Array values)
        {
            // create a new string array  
            string[] theArray = new string[values.Length];
            // loop through the 2-D System.Array and populate the 1-D String Array  

            for (int i = 1; i <= values.Length; i++)
            {
                if (values.GetValue(1, i) == null)
                    theArray[i - 1] = "";
                else
                    theArray[i - 1] = values.GetValue(1, i).ToString();
            }

            return theArray;
        }
    }
}