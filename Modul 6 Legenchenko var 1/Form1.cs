﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Modul_6_Legenchenko_var_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_download_Click(object sender, EventArgs e)
        {
            // Создаем соеденение
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb";//строка соеденения
            OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаем соеденение
            OleDbDataReader dbReader;

            // Выполянем запрос к БД
            dbConnection.Open();                                            // открываем соеденение
            string query = "SELECT * FROM table_name";                      // строка запроса
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); // команда
            dbReader = dbCommand.ExecuteReader();                           // считываем данные

            // Проверяем данные
            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены!", "Ошибка!");
            }
            else
            {
                // Чтение данных
                while (dbReader.Read())
                {
                    // Выводим данные
                    dataGridView1.Rows.Add(dbReader["Name"], dbReader["Surname"], dbReader["Post"], dbReader["Salary"]);
                }
            }
            dbReader.Close();
            dbConnection.Close();
        }


        private void button_delete_Click(object sender, EventArgs e)
        {
            //Проверим количество выбранных строк
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            //Запомним выбранную строку
            int index = dataGridView1.SelectedRows[0].Index;

            // Проверим данные в таблицы
            if (dataGridView1.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            // Считаем данные
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            // Создаем соеденение
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb";  // строка соеденения
            OleDbConnection dbConnection = new OleDbConnection(connectionString);                   // создаем соеденение

            try
            {
                // Выполянем запрос к БД
                dbConnection.Open();                                            // открываем соеденение
                string query = "DELETE FROM table_name WHERE id = " + id;       // строка запроса
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); // команда

                // Выполняем запрос
                if (dbCommand.ExecuteNonQuery() != 1)
                    MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                else
                {
                    MessageBox.Show("Данные удалены!", "Внимание!");
                    // Удаляем данные из таблицы в форме
                    dataGridView1.Rows.RemoveAt(index);
                }
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show($"Сообщение: {ex.Message}", "Вызвано исключение!");
            }
            finally
            {
                // Закрываем соеденение с БД
                dbConnection.Close();
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //Проверим количество выбранных строк
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            //Запомним выбранную строку
            int index = dataGridView1.SelectedRows[0].Index;

            //Проверим данные в таблицы
            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                dataGridView1.Rows[index].Cells[1].Value == null ||
                dataGridView1.Rows[index].Cells[2].Value == null ||
                dataGridView1.Rows[index].Cells[3].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            // Считаем данные
            string name = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string surname = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string post = dataGridView1.Rows[index].Cells[2].Value.ToString();
            string salary = dataGridView1.Rows[index].Cells[3].Value.ToString();

            // Создаем соеденение
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb";  // строка соеденения
            OleDbConnection dbConnection = new OleDbConnection(connectionString);                   // создаем соеденение

            try
            {
                // Выполянем запрос к БД
                dbConnection.Open();//открываем соеденение
                string query = "INSERT INTO table_name VALUES (" + name + ", '" + surname + "', " + post + ", " + salary + ")";//строка запроса
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);//команда

                // Выполняем запрос
                if (dbCommand.ExecuteNonQuery() != 1)
                    MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                else
                    MessageBox.Show("Данные добавлены!", "Внимание!");
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show($"Сообщение: {ex.Message}", "Вызвано исключение!");
            }
            finally
            {
                // Закрываем соеденение с БД
                dbConnection.Close();
            }
        }
    }
}
