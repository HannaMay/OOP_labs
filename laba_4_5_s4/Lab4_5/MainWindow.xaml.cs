using System;
using System.Collections.Generic;
using System.Linq;
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
using Microsoft.Win32;
using System.IO;
using Microsoft.DirectX.AudioVideoPlayback;
namespace Lab4_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool flag = true;
        private static int count_of_windows = 0;
        public MainWindow()
        {
            InitializeComponent();
            if (count_of_windows != 0)
            {
                this.Title += " (" + count_of_windows++ + ") ";
            }
            else
            {
                count_of_windows++;
            }
            this.FontSizeTextBox.Text = this.Font_Size.Value.ToString();
            this.MainText.AllowDrop = true;
            this.FontTypes.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            Uri iconUri = new Uri("D:\\Hannika\\university\\2_course\\c#_git\\labs\\laba_4_5_s4\\Lab4_5\\resources\\icon.ico", UriKind.RelativeOrAbsolute);
            this.Icon = BitmapFrame.Create(iconUri);
            this.MainText.AddHandler(RichTextBox.DragOverEvent, new DragEventHandler(this.DragItem), true);
            this.MainText.AddHandler(RichTextBox.DropEvent, new DragEventHandler(this.DropItem), true);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    FileName = "text.txt",
                    InitialDirectory = "D:\\Hannika\\university\\2_course\\c#_git\\labs\\laba_4_5_s4\\Lab4_5"
                };
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|RichText Files (*.rtf)|*.rtf|XAML Files (*.xaml)|*.xaml|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == true)
                {
                    TextRange textRange = new TextRange(this.MainText.Document.ContentStart, this.MainText.Document.ContentEnd);
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                    {
                        switch (Path.GetExtension(saveFileDialog.FileName).ToLower())
                        {
                            case ".rtf":
                                textRange.Save(fs, DataFormats.Rtf);
                                break;
                            case ".txt":
                                textRange.Save(fs, DataFormats.Text);
                                break;
                            default:
                                textRange.Save(fs, DataFormats.Xaml);
                                break;
                        }
                    }
                }
                else
                {
                    throw new Exception("uncorrect extension");
                }
            }
            catch
            {
                MessageBox.Show("save error");
            }
        }

        private void Font_Size_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                if (this.Font_Size.IsFocused && this.Font_Size.Value > 0)
                {
                    ChangeFontSize();
                    this.FontSizeTextBox.Text = this.Font_Size.Value.ToString();
                    ((Slider)sender).SelectionEnd = e.NewValue;
                }
                else if (this.Font_Size.Value == 0)
                {
                    MessageBox.Show("error: font size doesn't be negative");
                    this.Font_Size.Value = 12;
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    FileName = "text.txt",
                    InitialDirectory = "D:\\Hannika\\university\\2_course\\c#_git\\labs\\laba_4_5_s4\\Lab4_5"
                };
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|RichText Files (*.rtf)|*.rtf|XAML Files (*.xaml)|*.xaml|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == true)
                {
                    TextRange textRange = new TextRange(this.MainText.Document.ContentStart, this.MainText.Document.ContentEnd);
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                    {
                        switch (Path.GetExtension(openFileDialog.FileName).ToLower())
                        {
                            case ".rtf":
                                textRange.Load(fs, DataFormats.Rtf);
                                break;
                            case ".txt":
                                textRange.Load(fs, DataFormats.Text);
                                break;
                            default:
                                textRange.Load(fs, DataFormats.Xaml);
                                break;
                        }
                    }
                    this.Title = "Text Editor (" + openFileDialog.FileName + ") ";
                }
                else
                {
                    throw new Exception("uncorrect extension");
                }
            }
            catch
            {
                MessageBox.Show("open error");
            }
        }

        private void FontUpdating(object sender, RoutedEventArgs e)
        {
            object temp = this.MainText.Selection.GetPropertyValue(Inline.FontFamilyProperty);
            this.FontTypes.SelectedItem = temp;
        }

        private void OnChangeFontFamily(object sender, SelectionChangedEventArgs e)
        {
            if (this.FontTypes.SelectedItem != null)
            {
                this.MainText.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, this.FontTypes.SelectedItem);
            }
            this.MainText.Focus();
        }

        private void Font_Size_MouseMove(object sender, MouseEventArgs e)
        {
            this.ToolTip = this.Font_Size.Value.ToString();
        }

        private void Font_Size_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (this.Font_Size.IsFocused)
            {
                this.ToolTip = this.Font_Size.Value.ToString();
            }
        }

        private void ChangeFontSize()
        {
            TextRange tr;
            if (!this.MainText.Selection.IsEmpty)
            {
                tr = new TextRange(this.MainText.Selection.Start, this.MainText.Selection.End);
            }
            else
            {
                tr = new TextRange(this.MainText.CaretPosition, this.MainText.Document.ContentEnd);
            }
            tr.ApplyPropertyValue(FontSizeProperty, this.Font_Size.Value);
        }

        private void FontSizeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double value;
                if (this.FontSizeTextBox.Text.Equals(String.Empty))
                {
                    this.Font_Size.Value = 12;
                    this.FontSizeTextBox.Text = this.Font_Size.Value.ToString();
                    throw new Exception("please, write a correct size");
                }
                if ((value = Convert.ToDouble(this.FontSizeTextBox.Text)) < 0 && value > 100)
                {
                    MessageBox.Show("error: font size is uncorrect");
                }
                else
                {
                    this.Font_Size.Value = Convert.ToDouble(this.FontSizeTextBox.Text);
                    ChangeFontSize();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void DragItem(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.All;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
            e.Handled = false;
        }

        private void DropItem(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] docPath = (string[])e.Data.GetData(DataFormats.FileDrop);
                    if (System.IO.File.Exists(docPath[0]))
                    {
                        try
                        {
                            TextRange range = new TextRange(this.MainText.Document.ContentStart, this.MainText.Document.ContentEnd);
                            FileStream fStream = new FileStream(docPath[0], FileMode.OpenOrCreate);
                            range.Load(fStream, DataFormats.Rtf);
                            fStream.Close();
                            this.Title = "Text Editor (" + docPath[0] + ") ";
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("File could not be opened. Make sure the file is a text file.");
                        }
                    }
                }
            }
        }

        private void NewWind(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
        }

        private void SetRussian(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Resources = new ResourceDictionary()
                {
                    Source = new Uri("pack://application:,,,/resources/langRU.xaml")
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void SetEnglish(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Resources = new ResourceDictionary()
                {
                    Source = new Uri("pack://application:,,,/resources/langEN.xaml")
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }

        private void Bold_Unchecked(object sender, RoutedEventArgs e)
        {
            this.MainText.FontWeight = FontWeights.Normal;
        }

        private void Italic_Unchecked(object sender, RoutedEventArgs e)
        {
            this.MainText.FontStyle = FontStyles.Normal;
        }

        private void UnderLine_Unchecked(object sender, RoutedEventArgs e)
        {

        }

        private string GetLength(RichTextBox rtb)
        {
            int count_of_symbols = 0, count_of_lines = 0;
            var textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
            foreach (char c in textRange.Text)
            {
                if (!c.Equals('\n') && (int)c != 13)
                {
                    count_of_symbols++;
                }
                else if (c.Equals('\n'))
                {
                    count_of_lines++;
                }
            }
            return "count of symbols " + count_of_symbols + ", count of lines " + count_of_lines;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            this.Log.Content = GetLength(this.MainText);
        }
    }
}
