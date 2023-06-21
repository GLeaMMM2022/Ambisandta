﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OssetianProverbsApp
{
    public partial class MainForm : Form
    {
        //Создаем списки
        private List<string> ossetianProverbs;
        private List<string> russianTranslations;
        private List<string> selectedProverbs;

        public MainForm()
        {
            InitializeComponent();

            //Настраиваем свойства 
            proverbsListView.View = View.Details;
            proverbsListView.Columns.Add("На осетинском");
            proverbsListView.Columns.Add("На русский");
            proverbsListView.Columns[0].Width = 200;
            proverbsListView.Columns[1].Width = 200;

            InitializeProverbs(); //Для инициализации списокв пословиц
            InitializeListBoxes(); //ДЛя заполнения ListBox-ов пословицами

            selectedProverbs = new List<string>();

            // Привязываем обработчик к кнопке addButton
            addButton.Click += addButton_Click;
            // Привязываем обработчик к кнопке checkButton
            checkButton.Click += checkButton_Click; 

        }

        private void InitializeProverbs()
        {
            // Здесь заполняем списки пословицами на осетинском и их переводами на русский
            ossetianProverbs = new List<string>
            {
                "Ӕфсӕст стонджы не 'мбары",
                "Буцхаст уӕздан кӕны, уӕздан магуса кӕны, магуса та сӕфтмӕ цӕуы",
                "Адӕмаг кусынӕн у",
                "Зивӕггӕнаг иууылдӕр тӕхуды кӕны",
                "Ард фӕсайын зын хъуыддаг у",
                "Зондджын лӕг хъусгӕ фылдӕр кӕны, дзургӕ - къаддӕр",
                "Кӕстӕран йӕ хӕс - хистӕрмӕ хъусын",
                "Усы хорз лӕгыл дӕр зыны",
                "Мадӕн йӕ ралгъыст дӕр арфӕ у",
                "Куыдз дӕр хорздзинад никуы рох кӕны"
            };

            russianTranslations = new List<string>
            {
                "Сытый голодного не разумеет",
                "Баловень становится нежным, неженка - лодырем, а лодырь идёт к гибели",
                "Человек существует, чтобы трудиться",
                "Ленивый лишь мечтает",
                "Нарушить клятву - тяжелое преступление",
                "Умный человек больше слушает, а меньше говорит",
                "Долг младшего - слушаться старшего",
                "При хорошей жене и муж делается лучше",
                "Даже проклятье материнское является благословением",
                "Даже собака не забывает благодеяние"
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
