using System;
using System.Drawing.Printing;
using System.IO;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Document = iTextSharp.text.Document;

namespace Blotter_records
{
    public partial class Form1 : Form
    {
        private string _uniqueFileName;

        public Form1()
        {
            InitializeComponent();

            dateTimePickerDate.Value = DateTime.Now;
            dateTimePickerTime.Value = DateTime.Now;

        }

        private void CreateRecordButton_Click(object sender, EventArgs e)
        {
            var recordDate = dateTimePickerDate.Value.Date;
            var recordTime = dateTimePickerTime.Value.TimeOfDay;
            var recordDescription = descriptionTextBox.Text;
            var recordCreatedBy = personTextBox.Text;

            _uniqueFileName = $"{recordDate:MMM-dd-yyyy}_{recordTime:hhmmss}_{Guid.NewGuid():N}.pdf";

            CreatePdf(_uniqueFileName, recordDate, recordTime, recordDescription, recordCreatedBy);
        }

        private void CreatePdf(string fileName, DateTime recordDate, TimeSpan recordTime, string recordDescription, string recordCreatedBy)
        {
            string time = dateTimePickerTime.Value.ToString("hh:mm tt");

            var pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);
            var writer = PdfWriter.GetInstance(pdfDoc, new FileStream(fileName, FileMode.Create));
            pdfDoc.Open();

            var titleParagraph = new Paragraph();
            var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 20);
            var captionFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

            titleParagraph.Add(new iTextSharp.text.Chunk("Blotter Record\n\n\n", titleFont));
            titleParagraph.Alignment = Element.ALIGN_CENTER;

            pdfDoc.Add(titleParagraph);

            var paragraph = new Paragraph();
            var font = FontFactory.GetFont(FontFactory.HELVETICA, 12);

            paragraph.Add(new iTextSharp.text.Chunk($"Date of Creation: ",captionFont));
            paragraph.Add(new iTextSharp.text.Chunk($"{recordDate:MM/dd/yyyy}\n\n", font));

            paragraph.Add(new iTextSharp.text.Chunk($"Time of Creation: ", captionFont));
            paragraph.Add(new iTextSharp.text.Chunk($"{time}\n\n", font));

            paragraph.Add(new iTextSharp.text.Chunk($"Record Description:\n\n", captionFont));
            paragraph.Add(new iTextSharp.text.Chunk($"{recordDescription}\n\n", font));        
            paragraph.Alignment = Element.ALIGN_JUSTIFIED;

            paragraph.Add(new iTextSharp.text.Chunk($"Noted By: ", captionFont));
            paragraph.Add(new iTextSharp.text.Chunk($"{recordCreatedBy}\n\n", font));

            paragraph.Add(new iTextSharp.text.Chunk($"Signature: \n", captionFont));
            paragraph.Add("\n\n");
            

            var line = new LineSeparator(1.5f, 25.0f, BaseColor.BLACK, Element.ALIGN_LEFT, -1);
            line.Alignment = Element.ALIGN_LEFT;
            paragraph.Add(line);

            pdfDoc.Add(paragraph);

            pdfDoc.Close();
            writer.Close();

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
            File.Move(fileName, desktopPath + fileName);

            MessageBox.Show($"Blotter record created successfully! \nYou can access the file inside your desktop folder.", "e-Barangay Application Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}