using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Niche.UserControlPages
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void createSampleCVButton_Click(object sender, EventArgs e)
        {
            using (DocX document = DocX.Create("sampleCV.docx"))
            {
                    // Add content to the document

                    if (languageComboBox.SelectedIndex == 0) { 
                    // Add firstName and lastName as a section
                    Paragraph p1 = document.InsertParagraph(firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" + "(Address, Email, Phone Number)\n")
                                          .FontSize(16)  // Set font size
                                          .Font(new Xceed.Document.NET.Font("Times New Roman")); // Set font family to Times New Roman

                    // Add education as a section
                    Paragraph p2 = document.InsertParagraph("• Education: \n" + educationTextBox.Text + "\n" + "(Elaborate on your education or add more here.)\n")
                                          .FontSize(12)  // Set font size
                                          .Font(new Xceed.Document.NET.Font("Times New Roman")); // Set font family to Times New Roman


                    // Add skills as a section
                    Paragraph p3 = document.InsertParagraph("• Skills: \n" + skillsTextBox.Text + "\n" + "(Elaborate on each of your skills or add more skills here.)\n")
                                          .FontSize(12)  // Set font size
                                          .Font(new Xceed.Document.NET.Font("Times New Roman")); // Set font family to Times New Roman

                    // Add experience as a section
                    Paragraph p4 = document.InsertParagraph("• Experience: \n" + experienceTextBox.Text + "\n" + "(Elaborate on your experience or add more here.)\n")
                                          .FontSize(12)  // Set font size
                                          .Font(new Xceed.Document.NET.Font("Times New Roman")); // Set font family to Times New Roman

                    // Save the document
                    document.Save();
            
                    MessageBox.Show("Document was created successfully!", "Sample CV File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    else if (languageComboBox.SelectedIndex == 1)
                {
                    // Add firstName and lastName as a section
                    Paragraph p1 = document.InsertParagraph(firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" + "(Adresse, Courriel, Numéro de téléphone)\n")
                                          .FontSize(16)  // Set font size
                                          .Font(new Xceed.Document.NET.Font("Times New Roman")); // Set font family to Times New Roman

                    // Add education as a section
                    Paragraph p2 = document.InsertParagraph("• Éducation: \n" + educationTextBox.Text + "\n" + "(Expliquer votre éducation ou ajouter plus d'informations ici.)\n")
                                          .FontSize(12)  // Set font size
                                          .Font(new Xceed.Document.NET.Font("Times New Roman")); // Set font family to Times New Roman


                    // Add skills as a section
                    Paragraph p3 = document.InsertParagraph("• Compétences: \n" + skillsTextBox.Text + "\n" + "(Expliquer vos compétences ou ajouter plus d'informations ici.)\n")
                                          .FontSize(12)  // Set font size
                                          .Font(new Xceed.Document.NET.Font("Times New Roman")); // Set font family to Times New Roman

                    // Add experience as a section
                    Paragraph p4 = document.InsertParagraph("• Expérience de travail: \n" + experienceTextBox.Text + "\n" + "(Expliquer votre expérience de travail ou ajouter plus d'informations ici.)\n")
                                          .FontSize(12)  // Set font size
                                          .Font(new Xceed.Document.NET.Font("Times New Roman")); // Set font family to Times New Roman

                    // Save the document
                    document.Save();

                    MessageBox.Show("Le document a été créé avec succès!", "Fichier Exemple de CV ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    else if (languageComboBox.SelectedIndex == 2)
                {
                    // Add firstName and lastName as a section
                    Paragraph p1 = document.InsertParagraph(firstNameTextBox.Text + " " + lastNameTextBox.Text + "\n" + "(Dirección, correo electrónico, número de teléfono)\n")
                                          .FontSize(16)  // Set font size
                                          .Font(new Xceed.Document.NET.Font("Times New Roman")); // Set font family to Times New Roman

                    // Add education as a section
                    Paragraph p2 = document.InsertParagraph("• Educación: \n" + educationTextBox.Text + "\n" + "(Explica tu formación o añade más información aquí.)\n")
                                          .FontSize(12)  // Set font size
                                          .Font(new Xceed.Document.NET.Font("Times New Roman")); // Set font family to Times New Roman


                    // Add skills as a section
                    Paragraph p3 = document.InsertParagraph("• Habilidades: \n" + skillsTextBox.Text + "\n" + "(Explica tus habilidades o agrega más información aquí.)\n")
                                          .FontSize(12)  // Set font size
                                          .Font(new Xceed.Document.NET.Font("Times New Roman")); // Set font family to Times New Roman

                    // Add experience as a section
                    Paragraph p4 = document.InsertParagraph("• Experiencia laboral: \n" + experienceTextBox.Text + "\n" + "(Explica tu experiencia laboral o añade más información aquí.)\n")
                                          .FontSize(12)  // Set font size
                                          .Font(new Xceed.Document.NET.Font("Times New Roman")); // Set font family to Times New Roman

                    // Save the document
                    document.Save();

                    MessageBox.Show("El documento fue creado exitosamente!", "Archivo Ejemplo de CV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
