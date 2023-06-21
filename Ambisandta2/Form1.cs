using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OssetianProverbsApp
{
    public partial class MainForm : Form
    {
        private List<string> ossetianProverbs;
        private List<string> russianTranslations;
        private List<string> selectedProverbs;

        public MainForm()
        {
            InitializeComponent();
            proverbsListView.View = View.Details;
            proverbsListView.Columns.Add("На осетинском");
            proverbsListView.Columns.Add("На русский");
            proverbsListView.Columns[0].Width = 200;
            proverbsListView.Columns[1].Width = 200;
            InitializeProverbs();
            InitializeListBoxes();
            selectedProverbs = new List<string>();
        }

        private void InitializeProverbs()
        {
            // Здесь вы можете заполнить списки пословицами на осетинском и их переводами на русский
            ossetianProverbs = new List<string>
            {
                "Пословица на осетинском 1",
                "Пословица на осетинском 2",
                "Пословица на осетинском 3"
            };

            russianTranslations = new List<string>
            {
                "Перевод на русский 1",
                "Перевод на русский 2",
                "Перевод на русский 3"
            };
        }

        private void InitializeListBoxes()
        {
            // Заполняем ListBox пословицами на осетинском
            foreach (var proverb in ossetianProverbs)
            {
                ossetianListBox.Items.Add(proverb);
            }

            // Заполняем ListBox переводами пословиц на русский
            foreach (var translation in russianTranslations)
            {
                russianListBox.Items.Add(translation);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Получаем выбранные элементы из ListBox-ов
            if (ossetianListBox.SelectedItem != null && russianListBox.SelectedItem != null)
            {
                string selectedProverb = ossetianListBox.SelectedItem.ToString();
                string selectedTranslation = russianListBox.SelectedItem.ToString();

                // Добавляем выбранные пословицу и перевод в ListView
                ListViewItem listViewItem = new ListViewItem(new[] { selectedProverb, selectedTranslation });
                proverbsListView.Items.Add(listViewItem);
                selectedProverbs.Add(selectedProverb);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите пословицу и ее перевод.");
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            // Проверяем правильность выбранных переводов
            foreach (ListViewItem item in proverbsListView.Items)
            {

                string proverb = item.SubItems[0].Text;
                string translation = item.SubItems[1].Text;
                int index = ossetianProverbs.IndexOf(proverb);

                if (index != -1 && russianTranslations[index] == translation)
                {
                    // Правильный перевод
                    item.BackColor = System.Drawing.Color.LightGreen;
                }
                else
                {
                    // Неправильный перевод
                    item.BackColor = System.Drawing.Color.LightPink;
                }
            }
        }

        
    }
}
