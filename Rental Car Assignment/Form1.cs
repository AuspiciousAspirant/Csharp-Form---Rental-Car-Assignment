using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rental_Car_Assignment
{
    public partial class Form1 : Form
    {
        DataTable myDataTable = new DataTable();
        SqlConnection myConnection = new SqlConnection();
        SqlCommand myCommand = new SqlCommand();
        SqlDataAdapter myAdapter = new SqlDataAdapter();
        SqlTransaction myTransaction;
        String carType = "";
        String extra_driver = "";
        String extra_driver_cost = "";
        int totalCost = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Generate dates from today for the next 30 days and add them to the ComboBoxes
            DateTime startDate = DateTime.Today;
            int daysToGenerate = 30; // Number of days you want to generate

            // Populate Rent Date ComboBox
            for (int i = 0; i < daysToGenerate; i++)
            {
                rent_date_box.Items.Add(startDate.AddDays(i).ToString("yyyy-MM-dd")); //fprmat= yyyy-MM-dd 
            }

            // Populate Return Date ComboBox
            for (int i = 0; i < daysToGenerate; i++)
            {
                return_date_box.Items.Add(startDate.AddDays(i).ToString("yyyy-MM-dd"));
            }

            rent_date_box.SelectedIndex = 0; // Automatically selects the first date
            // Set a placeholder or default value
            return_date_box.SelectedIndex = 0; // Automatically selects the first date

            //Make dates unchangeable, 
            //dataGridView1.Columns["Car_Type"].ReadOnly = true;
            // dataGridView1.Columns["Rent_Date"].ReadOnly = true;
            // *this was done in design view*
        }

        private void dataGridView1_CellValueChanged(object senders, DataGridViewCellEventArgs z)
        {
            if (z.RowIndex >= 0)
            {
                // Get the row where the value was changed
                DataGridViewRow row = dataGridView1.Rows[z.RowIndex];

                // Update the total cost if the Extra_Driver value changes
                if (z.ColumnIndex == dataGridView1.Columns["Extra_Driver"]?.Index)
                {
                    // Get the base price based on Car_Type
                    string carType = row.Cells["Car_Type"].Value.ToString();
                    int baseCost = 0;

                    if (carType == "Compact") { baseCost = 25; }
                    else if (carType == "SUV") { baseCost = 40; }
                    else if (carType == "Sports Car") { baseCost = 60; }

                    // Get the extra driver charge
                    int extraDriverCharge = 0;
                    if (int.TryParse(row.Cells["Extra_Driver"].Value.ToString(), out extraDriverCharge))
                    {
                        // Calculate the new total cost
                        int newTotalCost = baseCost + extraDriverCharge;

                        // Update the Total_Charge cell
                        row.Cells["Total_Cost"].Value = newTotalCost;

                        // Update the database
                        UpdateDatabase(row);
                    }
                }
                else if (z.ColumnIndex == dataGridView1.Columns["Plate#"]?.Index)
                {
                    // Update the database when Plate# changes
                    UpdateDatabase(row);
                }
            }
        }

        // Helper method to update the database for a given row
        private void UpdateDatabase(DataGridViewRow row)
        {
            SqlCommand updateCommand = new SqlCommand();
            updateCommand.Connection = myConnection; // Set the connection for the command
            updateCommand.CommandText = "UPDATE [Table] SET Extra_Driver = @ED, Total_Cost = @TC WHERE Plate# = @Plate";

            // Add parameters for updating the database
            updateCommand.Parameters.Add("@ED", SqlDbType.VarChar, 1).Value = row.Cells["Extra_Driver"].Value?.ToString();
            updateCommand.Parameters.Add("@TC", SqlDbType.SmallInt).Value = Convert.ToInt32(row.Cells["Total_Cost"].Value);
            updateCommand.Parameters.Add("@Plate", SqlDbType.Int).Value = Convert.ToString(row.Cells["Plate#"].Value);

            try
            {
                myConnection.Open();
                updateCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating rental: " + ex.Message);
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarFall2024VST4708;Integrated Security=True;Connect Timeout=30;Encrypt=False";
                myConnection.Open();

                // Determine car type from radio buttons
                //if (radioButton1.Checked)
                //{
                //    carType = "Compact";
                //}
                //else if (radioButton2.Checked)
                //{
                //    carType = "SUV";
                //}
                //else if (radioButton3.Checked)
                //{
                //    carType = "Sports Car";
                //}
                //else
                //{
                //    MessageBox.Show("Please select a car type for filtering.");
                //    return;
                //}

                // Set the SQL command text with parameter for filtering by car type
                //myCommand.CommandText = "SELECT Plate#, Car_Type, Extra_Driver, Rent_Date, Return_Date FROM [Table] WHERE Car_Type = @CType";
                //myCommand.CommandText = "SELECT Plate#, Car_Type, Extra_Driver, Rent_Date, Return_Date FROM [Table]";
                myCommand.CommandText = "SELECT Plate#, Car_Type, Extra_Driver, Rent_Date, Return_Date, Total_Cost FROM [Table]";

                // Clear any existing parameters to avoid duplication issues
                myCommand.Parameters.Clear();

                // Assign the determined car type to the @CType parameter
                myCommand.Parameters.Add("@CType", SqlDbType.VarChar, 50).Value = carType;

                myCommand.Connection = myConnection;

                // Set the command for the adapter and fill the DataTable
                myAdapter.SelectCommand = myCommand;

                myDataTable.Clear(); // Clear existing data to avoid duplication
                myAdapter.Fill(myDataTable);

                // Bind the data to the DataGridView
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = myDataTable;
            }
            catch (SqlException se)
            {
                MessageBox.Show("Database error: " + se.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }
            }
        }

        private void place_rental_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the connection string and open the connection
                myConnection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarFall2024VST4708;Integrated Security=True;Connect Timeout=30;Encrypt=False";
                myConnection.Open();

                // Determine car type
                if (radioButton1.Checked) { carType = "Compact"; }
                else if (radioButton2.Checked) { carType = "SUV"; }
                else if (radioButton3.Checked) { carType = "Sports Car"; }

                // Determine extra driver
                //if (checkBox1.Checked) {extra_driver = "Y";}
                //else {extra_driver = "N";}

                // Determine extra driver v2
                if (checkBox1.Checked) { extra_driver = "Y"; }
                else { extra_driver = "N"; }


                // Determine price
                if (carType == "Compact") { totalCost = 25; }
                else if (carType == "SUV") { totalCost = 40; }
                else if (carType == "Sports Car") { totalCost = 60; }

                //if (extra_driver == "Y") { totalCost += 25; }
                if (extra_driver == "Y") { totalCost += int.Parse(extra_charge_cost.Text); } //******

                // Ensure that a value is selected for both rent and return dates
                if (rent_date_box.SelectedItem == null || return_date_box.SelectedItem == null)
                {
                    MessageBox.Show("Please select both rent and return dates.");
                    return;
                }

                // Parse the selected dates properly from the ComboBoxes
                DateTime rentDate = DateTime.Parse(rent_date_box.SelectedItem.ToString());
                DateTime returnDate = DateTime.Parse(return_date_box.SelectedItem.ToString());

                // Create a new SqlCommand for inserting the rental data
                SqlCommand insertCommand = new SqlCommand();
                insertCommand.Connection = myConnection; // Set the connection for the command
                insertCommand.CommandText = "INSERT INTO [Table] ([Plate#], Car_Type, Extra_Driver, Rent_Date, Return_Date, Total_Cost) VALUES (@Plate, @CType, @ED, @RentD, @ReturnD, @TC)";


                // Add parameters and set their values
                insertCommand.Parameters.Add("@Plate", SqlDbType.Int).Value = int.Parse(liscense_plate_box.Text);
                insertCommand.Parameters.Add("@CType", SqlDbType.VarChar, 50).Value = carType;
                insertCommand.Parameters.Add("@ED", SqlDbType.VarChar, 1).Value = extra_driver;
                insertCommand.Parameters.Add("@RentD", SqlDbType.Date).Value = rentDate;
                insertCommand.Parameters.Add("@ReturnD", SqlDbType.Date).Value = returnDate;
                insertCommand.Parameters.Add("@TC", SqlDbType.SmallInt).Value = totalCost;

                // Execute the insert command
                int rowsAffected = insertCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Rental added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add rental.");
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Invalid input format: " + fe.Message);
            }
            catch (SqlException se)
            {
                MessageBox.Show("Database error: " + se.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is properly closed
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Open db connection
                myConnection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarFall2024VST4708;Integrated Security=True;Connect Timeout=30;Encrypt=False";
                myConnection.Open();

                // Create an SqlCommandBuilder, it automatically generates updsate commands
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(myAdapter);

                // Apply changes from the DataTable to the database
                myAdapter.Update(myDataTable);

                
                myDataTable.AcceptChanges();

                MessageBox.Show("Changes saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message);
            }
            finally
            {
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }
            }
        }


    }
}

