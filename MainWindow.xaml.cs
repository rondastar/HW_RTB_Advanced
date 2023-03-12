using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace HW_RTB_Advanced
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

        // 1st item: FlowDocument
        // 2nd item: Paragraph (Block Element)
        // 3rd item: Run (Inline Element)
    {
        FlowDocument fdDisplay = new FlowDocument();
        public MainWindow()
        {
            InitializeComponent();
            rtbDisplay.Document = fdDisplay;

        } // MainWindow()

        private void ItWorked()
        {

            Paragraph para1 = new Paragraph();
            // Creating a sentence
            Run run1 = new Run("Programing 122 Advanced Rich Text Box");
            //run1.Background = new SolidColorBrush(Colors.CadetBlue);
            // Adding a sentence to our paragraph
            //para1.Background = new SolidColorBrush(Colors.Orange);
            para1.Inlines.Add(run1);
            // Adding the paragraph to our document
            fdDisplay.Blocks.Add(para1);
            //fdDisplay.Background = new SolidColorBrush(Colors.MediumPurple);
            // Add our document to our rich text box
            //rtbDisplay.Background = new SolidColorBrush(Color.FromRgb(255, 133, 133));
            rtbDisplay.Document = fdDisplay;
        }
        private void btnPost_Click(object sender, RoutedEventArgs e)
        {
            string header = txtHeader.Text;
            string body = runBody.Text;
            // Get the flow document
            // Create a paragraph
            Paragraph newParagraph = new Paragraph();
            // Create a run
            
            
            
            // Add to paragraph
            newParagraph.Inlines.Add(HeaderFormatted(header));
            newParagraph.Inlines.Add(BodyFormatted(body));
            // Add to flow document
            fdDisplay.Blocks.Add(newParagraph);
        }

        public Run HeaderFormatted(string header)
        {
            Run newRunHeader = new Run(header + "\n");
            newRunHeader.FontSize = 24;
            newRunHeader.Foreground = new SolidColorBrush(Colors.Orange);
            return newRunHeader;
        }

        public Run BodyFormatted(string body)
        {
            Run newRunBody = new Run(body);
            newRunBody.FontSize = 16;
            return newRunBody;
        }

    } // class

    // Questions
    // What's the difference between a paragraph and a run tag ( regarding space used )?
    //  --run is an individual line of code; a paragraph hold multiple lines
    //    What "Collection" does a Paragraph have that holds inlines?
    //      --Inlines
    //    What "Collection" does a FlowDocument have that holds blocks?
    //      --Blocks
    //    How do you connect a FlowDocument to a RichTextBox
    //      --Assign the FlowDocument to the RTB Document (e.g. rtbDisplay.Document = fdDisplay)
    //    How often does Will appear in the Rich Text Box with the following code?
    //    Run name = new Run("Will");

    //    paragraph.Inlines.Add(name);
    //paragraph.Inlines.Add(name);
    //paragraph.Inlines.Add(name);
    //      --Once
    //.....

    //What property is used to add Italics?
    //  --FontStyle
    //What property is used to add bold?
    //  --FontWeight
}
