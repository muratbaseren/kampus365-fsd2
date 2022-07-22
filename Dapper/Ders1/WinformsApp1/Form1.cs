using Dapper;
using System.Data.SqlClient;

namespace WinformsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string _connectionString = "Data Source=localhost;Database=Northwind;Integrated Security=True;";

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO [dbo].[Categories] ([CategoryName] ,[Description] ,[Picture]) VALUES (@CategoryName ,@Description ,NULL)";

            string cname = txtCName.Text.Trim();
            string cdesc = txtCDesc.Text.Trim();

            RunSql(sql, new
            {
                CategoryName = cname,
                Description = cdesc
            }, "Kategori eklendi.");
        }

        private void RunSql(string sql, object @params, string successMessage)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int affectedRows = connection.Execute(sql, @params);

                if (affectedRows > 0)
                {
                    MessageBox.Show(successMessage, "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE [dbo].[Categories] " +
                "SET [CategoryName] = @Name ,[Description] = @Desc " +
                "WHERE CategoryID = @ID";

            int cid = (int)nudCId.Value;
            string cname = txtNewCName.Text.Trim();
            string cdesc = txtNewCDesc.Text.Trim();

            RunSql(sql, new
            {
                Name = cname,
                Desc = cdesc,
                ID = cid
            }, "Kategori güncellendi.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM [dbo].[Categories] WHERE CategoryID = @ID";

            int cid = (int)nudDeletedCId.Value;

            RunSql(sql, new
            {
                ID = cid
            }, "Kategori silindi.");
        }

        private void btnAdoNetOrm_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string sql = "SELECT [CategoryID] ,[CategoryName] ,[Description] FROM [Northwind].[dbo].[Categories]";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<dynamic> categories = connection.Query(sql).ToList();

                lstCategories.DataSource = categories;
                lstCategories.DisplayMember = "CategoryName";
                lstCategories.ValueMember = "CategoryID";
            }
        }

        private void btnLoad2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT [CategoryID] ,[CategoryName] ,[Description] FROM [Northwind].[dbo].[Categories]";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<Category> categories = connection.Query<Category>(sql).ToList();

                lstCategories.DataSource = categories;
                lstCategories.DisplayMember = "CategoryName";
                lstCategories.ValueMember = "CategoryID";
            }
        }

        private void btnSelectWhere_Click(object sender, EventArgs e)
        {
            string sql = "SELECT [CategoryID] ,[CategoryName] ,[Description] FROM [Northwind].[dbo].[Categories] WHERE Description = @Desc";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<Category> categories = connection.Query<Category>(sql, new
                {
                    Desc = "Cheeses"
                }).ToList();

                lstCategories.DataSource = categories;
                lstCategories.DisplayMember = "CategoryName";
                lstCategories.ValueMember = "CategoryID";
            }
        }

        private void btnInsertMany_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO [dbo].[Categories] ([CategoryName] ,[Description] ,[Picture]) VALUES (@CategoryName ,@Description ,NULL)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                //int affectedRows = connection.Execute(sql, new[]
                //{
                //    new { CategoryName = "GGG1", Description = "GGG1 Desc" },
                //    new { CategoryName = "GGG2", Description = "GGG2 Desc" },
                //    new { CategoryName = "GGG3", Description = "GGG3 Desc" },
                //    new { CategoryName = "GGG4", Description = "GGG4 Desc" },
                //});

                int affectedRows = connection.Execute(sql, insertAfterList);
                insertAfterList.Clear();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Kategoriler kaydedildi.", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        List<dynamic> insertAfterList = new List<dynamic>();

        private void btnInsertAfter_Click(object sender, EventArgs e)
        {
            string cname = txtCName.Text.Trim();
            string cdesc = txtCDesc.Text.Trim();

            insertAfterList.Add(new { CategoryName = cname, Description = cdesc });
        }

        private void btnSelectIn_Click(object sender, EventArgs e)
        {
            // SELECT * FROM Category WHERE Country IN ('Turkey','France','Germany');
            string sql = "SELECT [CategoryID] ,[CategoryName] ,[Description] FROM [Northwind].[dbo].[Categories] WHERE CategoryName IN @CategoryNames";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<Category> someCategories = connection.Query<Category>(sql,
                    new { CategoryNames = new[] { "Cat 1", "Cat 2", "Cat 3" } }).ToList();

                lstCategories.DataSource = someCategories;
                lstCategories.DisplayMember = "CategoryName";
                lstCategories.ValueMember = "CategoryID";
            }
        }

        private void btnStoredProc_Click(object sender, EventArgs e)
        {
            // Stored procedure : Create New Category

            string sql = "[Create New Category]";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                int affectedRows = connection.Execute(sql, new[]
                {
                    new { CatName = "OOOO", Desc = "OOOO Desc" },
                }, commandType: System.Data.CommandType.StoredProcedure);

                if (affectedRows > 0)
                {
                    MessageBox.Show("Kategori kaydedildi.", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            string sql1 = "INSERT INTO Categories(CategoryName) VALUES (@CatName1)";
            string sql2 = "INSERT INTO Categorie(CategoryName) VALUES (@CatName2)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlTransaction tran = connection.BeginTransaction())
                {
                    try
                    {
                        int affectedRows1 = connection.Execute(sql1, new[]
                        {
                            new { CatName1 = "tttt3" },
                        }, tran);

                        int affectedRows2 = connection.Execute(sql2, new[]
                        {
                            new { CatName2 = "tttt4" },
                        }, tran);

                        tran.Commit();

                        if (affectedRows1 > 0 && affectedRows2 > 0)
                        {
                            MessageBox.Show("Kategoriler kaydedildi.", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        tran.Rollback();
                    }
                }
            }
        }

        private void btnSSMS_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }
    }
}