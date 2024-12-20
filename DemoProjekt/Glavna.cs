
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
using Dapper;

namespace DemoBaza
{
  public partial class Glavna : Form
  {
    public Glavna()
    {
      InitializeComponent();
    }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (!CheckConnectionString(out string connectionString))
            {
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                Cursor.Current = Cursors.WaitCursor;
                //Ovdje napisati SELECT upit i pozvati Query metodu
                string sql = "SELECT * FROM Game";
                var lista = connection.Query<Game>(sql).ToList();
                Cursor.Current = Cursors.Default;
                dgvAll.AutoGenerateColumns = false;
                //Otkomentirati kada se implementira upit
                dgvAll.DataSource = lista;
                lblRowCountAll.Text = lista.Count.ToString();
            }
        }

        private void btnSelectCriteria_Click(object sender, EventArgs e)
        {
            if (!CheckConnectionString(out string connectionString))
            {
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //var lista = connection.Query<Game>("SELECT * FROM Game").ToList();

                int? idGenre = null;
                if (int.TryParse(txtGenre.Text, out int tempInt))
                {
                    idGenre = tempInt;
                }
                decimal? priceFrom = null;
                if (decimal.TryParse(txtPriceFrom.Text, out decimal tempDecimal))
                {
                    priceFrom = tempDecimal;
                }
                decimal? priceTo = null;
                if (decimal.TryParse(txtPriceTo.Text, out tempDecimal))
                {
                    priceTo = tempDecimal;
                }
                int? idPublisher = null;
                if (int.TryParse(txtPublisher.Text, out tempInt))
                {
                    idPublisher = tempInt;
                }
                string title = null;
                if (!string.IsNullOrEmpty(txtNameContains.Text))
                {
                    title = $"%{txtNameContains.Text}%";
                }
                Cursor.Current = Cursors.WaitCursor;
                //Definirati parametre i pozvati upit s kriterijima
                var parameters = new { idGenre, idPublisher, priceFrom, priceTo, title };
                string sql = @"SELECT * FROM Game
                WHERE (idGenre = @idGenre OR @idGenre IS NULL) AND
                (idPublisher = @idPublisher OR @idPublisher IS NULL) AND
                (price >= @priceFrom OR @priceFrom IS NULL) AND
                (price <= @priceTo OR @priceTo IS NULL) AND
                (title LIKE @title OR @title IS NULL)";
                var lista = connection.Query<Game>(sql, parameters).ToList();
                Cursor.Current = Cursors.Default;
                //Otkomentirati kada se implementira upit
                dgvSelectCriteria.DataSource = lista;
                lblRowCountFilter.Text = lista.Count.ToString();
            }

        }

    private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

        private void btnSelectOne_Click(object sender, EventArgs e)
        {
            if (!CheckConnectionString(out string connectionString))
                return;
            using (var connection = new SqlConnection(connectionString))
            {
                int? id = null;
                if (int.TryParse(txtIdSelectOne.Text, out int tempInt))
                {
                    id = tempInt;
                }
                else
                {
                    MessageBox.Show("Pogrešan format");
                    return;
                }
                Cursor.Current = Cursors.WaitCursor;
                //Definirati parametre i pozvati upit za jedan zapis
                var parameters = new { id };
                string sql = "SELECT * FROM Game WHERE id = @id";
                Game game  = connection.QueryFirstOrDefault<Game>(sql, parameters);
                Cursor.Current = Cursors.Default;
                //Otkomentirati kada se implementira upit
                if (game == null)
                {
                  lblSelectOneResult.Text = "Nema rezultata";
                  lblIdValue.Text = string.Empty;
                  lblTitleValue.Text = string.Empty;
                  lblGenreValue.Text = string.Empty;
                  lblPublisherValue.Text = string.Empty;
                  lblDeveloperValue.Text = string.Empty;
                  lblPriceValue.Text = string.Empty;
                  lblReleaseDateValue.Text = string.Empty;
                  return;
                }
                lblIdValue.Text = game.Id.ToString();
                lblTitleValue.Text = game.Title;
                lblGenreValue.Text = game.IdGenre.HasValue ? game.IdGenre.ToString() : "N/A";
                lblPublisherValue.Text = game.IdPublisher.HasValue ? game.IdPublisher.ToString() : "N/A";
                lblDeveloperValue.Text = game.IdDeveloper.HasValue ? game.IdDeveloper.ToString() : "N/A";
                lblPriceValue.Text = game.Price.HasValue ? game.Price.Value.ToString("C") : "N/A";
                lblReleaseDateValue.Text = game.ReleaseDate.HasValue ? game.ReleaseDate.Value.ToString("d") : "N/A";
            }
        }

    private void lblDeveloperValue_Click(object sender, EventArgs e)
    {

    }

    private void btnInsert_Click(object sender, EventArgs e)
    {
      //Otkomentirati kada se implementira klasa Game
      /*Game game = new Game();
      game.Title = txtTitleInsert.Text;
      game.IdGenre = int.TryParse(txtIdGenreInsert.Text, out int tempInt) ? tempInt : (int?)null;
      game.IdPublisher = int.TryParse(txtPublisherInsert.Text, out tempInt) ? tempInt : (int?)null;
      game.IdDeveloper = int.TryParse(txtDeveloperInsert.Text, out tempInt) ? tempInt : (int?)null;
      game.Price = decimal.TryParse(txtPriceInsert.Text, out decimal tempDecimal) ? tempDecimal : (decimal?)null;
      game.ReleaseDate = DateTime.TryParse(txtReleaseDateInsert.Text, out DateTime tempDateTime) ? tempDateTime : (DateTime?)null;*/
      if (!CheckConnectionString(out string connectionString))
      {
        return;
      }
      using (var connection = new SqlConnection(connectionString))
      {
        try
        {
          Cursor.Current = Cursors.WaitCursor;

         //Napisati upit za INSERT i vratiti novi Id u varijablu newId
         //int newId = ...

          //lblIdInsert.Text = newId.ToString();
          lblInsertResult.Text = "Uspješno ubačen novi zapis";
          lblInsertResult.ForeColor = Color.Green;
        }
        catch (Exception ex)
        {
          lblInsertResult.Text = ex.Message;
          lblInsertResult.ForeColor = Color.Red;
        }
        finally
        {
          Cursor.Current = Cursors.Default;
        }
        
        
      }
    }

    private void btnClearFormInsert_Click(object sender, EventArgs e)
    {
      lblInsertResult.Text = string.Empty;
      lblIdInsert.Text = string.Empty;
      txtTitleInsert.Text = string.Empty;
      txtIdGenreInsert.Text = string.Empty;
      txtPublisherInsert.Text = string.Empty;
      txtDeveloperInsert.Text = string.Empty;
      txtPriceInsert.Text = string.Empty;
      txtReleaseDateInsert.Text = string.Empty;
      lblInsertResult.BackColor = Color.Transparent;
    }

    private void btnLoadUpdate_Click(object sender, EventArgs e)
    {
      if (!CheckConnectionString(out string connectionString))
        return;
      if (!int.TryParse(txtIdUpdate.Text, out int id))
      {
        MessageBox.Show("Id mora biti broj.");
        return;
      }
      //Otkomentirati kada se implementira klasa Game i select one
      /*using (var connection = new SqlConnection(connectionString))
      {
        Cursor.Current = Cursors.WaitCursor;
        var parameters = new { id };
        var game = connection.QueryFirstOrDefault<Game>("SELECT * FROM Game WHERE id = @id", parameters);
        Cursor.Current = Cursors.Default;
        
        if (game == null)
        {
          lblUpdateResult.Text = "Nema rezultata za taj id";
          lblUpdateResult.ForeColor = Color.Red;
          return;
        }
        txtTitleUpdate.Text = game.Title;
        txtIdGenreUpdate.Text = game.IdGenre.HasValue ? game.IdGenre.ToString() : string.Empty;
        txtIdPublisherUpdate.Text = game.IdPublisher.HasValue ? game.IdPublisher.ToString() : string.Empty;
        txtIdDeveloperUpdate.Text = game.IdDeveloper.HasValue ? game.IdDeveloper.ToString() : string.Empty;
        txtPriceUpdate.Text = game.Price.HasValue ? game.Price.ToString() : string.Empty;
        txtReleaseDateUpdate.Text = game.ReleaseDate.HasValue ? game.ReleaseDate.Value.ToString("d") : string.Empty;
      }*/

    }

    private bool CheckConnectionString(out string connectionString)
    {
      connectionString = txtConnectionString.Text;
      if (string.IsNullOrEmpty(connectionString))
      {
        MessageBox.Show("Connection string je obavezan.");
        return false;
      }
      return true;
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      if (!CheckConnectionString(out string connectionString))
        return;
      //Otkomentirati kada se implementira klasa Game
      /*Game game = new Game();
      if (!int.TryParse(txtIdUpdate.Text, out int id))
      {
        MessageBox.Show("Id mora biti broj.");
        return;
      }
      game.Id = id;
      game.Title = txtTitleUpdate.Text;
      game.IdGenre = int.TryParse(txtIdGenreUpdate.Text, out int tempInt) ? tempInt : (int?)null;
      game.IdPublisher = int.TryParse(txtIdPublisherUpdate.Text, out tempInt) ? tempInt : (int?)null;
      game.IdDeveloper = int.TryParse(txtIdDeveloperUpdate.Text, out tempInt) ? tempInt : (int?)null;
      game.Price = decimal.TryParse(txtPriceUpdate.Text, out decimal tempDecimal) ? tempDecimal : (decimal?)null;
      game.ReleaseDate = DateTime.TryParse(txtReleaseDateUpdate.Text, out DateTime tempDateTime) ? tempDateTime : (DateTime?)null;*/
      using (var connection = new SqlConnection(connectionString))
      {
        try
        {
          Cursor.Current = Cursors.WaitCursor;
          //Napisati UPDATE upit i pozvati ga
          Cursor.Current = Cursors.Default;
        }
        catch (Exception ex)
        {
          lblUpdateResult.Text = ex.Message;
          lblUpdateResult.ForeColor = Color.Red;
        }
      }
    }

    private void btnClearUpdate_Click(object sender, EventArgs e)
    {
      txtIdUpdate.Text = string.Empty;
      txtTitleUpdate.Text = string.Empty;
      txtIdGenreUpdate.Text = string.Empty;
      txtIdPublisherUpdate.Text = string.Empty;
      txtIdDeveloperUpdate.Text = string.Empty;
      txtPriceUpdate.Text = string.Empty;
      txtReleaseDateUpdate.Text = string.Empty;
    }

    private void btnLoadDelete_Click(object sender, EventArgs e)
    {
      if(!CheckConnectionString(out string connectionString))
      {
        return;
      }
      //Otkomentirati kada se implementira klasa Game
      /*using (var connection = new SqlConnection(connectionString))
      {
        Cursor.Current = Cursors.WaitCursor;
        BindingList<Game> games = new BindingList<Game>(connection.Query<Game>("SELECT * FROM Game").ToList());
        Cursor.Current = Cursors.Default;
        dgvDelete.DataSource = games;
      }*/
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      var selectedRow = dgvDelete.SelectedRows[0];
      if (selectedRow == null)
      {
        MessageBox.Show("Morate odabrati zapis.");
        return;
      }
      if (!CheckConnectionString(out string connectionString))
      {
        return;
      }
      if(MessageBox.Show("Da li ste sigurni da želite obrisati odabrani zapis?", "Brisanje", MessageBoxButtons.YesNo) != DialogResult.Yes)
      {
        return;
      }
      //Otkomentirati kada se implementira klasa Game
      //int id = (selectedRow.DataBoundItem as Game).Id;
      using (var connection = new SqlConnection(connectionString))
      {
        try
        {
          Cursor.Current = Cursors.WaitCursor;
          //Napisati DELETE upit i pozvati ga
         
          Cursor.Current = Cursors.Default;
        }
        catch (Exception ex)
        {
          lblDeleteResult.Text = ex.Message;
          lblDeleteResult.ForeColor = Color.Red;
        }
      }
    }
  }
}
