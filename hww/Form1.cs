using Microsoft.EntityFrameworkCore;

namespace hww
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClearAreas()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        async private void AddCountry()
        {
            try
            {
                string country = textBox1.Text.Trim();
                string capital = textBox2.Text.Trim();
                string continent = textBox5.Text;

                if (country == "" || capital == "" || continent == "")
                {
                    MessageBox.Show("Not specified one of values");
                }
                if (!double.TryParse(textBox3.Text, out double population) || !double.TryParse(textBox4.Text, out double square))
                {
                    MessageBox.Show("Population or Square is not a valid number.");
                    return;
                }


                using (var db = new CountryContext())
                {
                    var result = new CountryModel
                    {
                        Country = country,
                        Capital = capital,
                        Population = population,
                        Square = square,
                        Continent = new Continent(continent)

                    };
                    await db.Countries.AddAsync(result);
                    await db.SaveChangesAsync();

                }

                MessageBox.Show("Country successfully added");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private async void RemoveCountry()
        {

            try
            {
                string country = textBox1.Text.Trim();

                using (var db = new CountryContext())
                {

                    if (string.IsNullOrWhiteSpace(country))
                    {
                        MessageBox.Show("Please enter a country name.");
                        return;
                    }

                    var RemovingCountry = await db.Countries.Where(c => c.Country == country).ToListAsync();
                    if (RemovingCountry.Count == 0)
                    {
                        MessageBox.Show("Country not found.");
                        return;
                    }

                    db.Countries.RemoveRange(RemovingCountry);
                    await db.SaveChangesAsync();


                }
                ClearAreas();
                MessageBox.Show("Country removed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void ChangeCountry()
        {
            try
            {


                string country = textBox1.Text.Trim();
                string capital = textBox2.Text.Trim();
                string continent = textBox5.Text;

                if (country == "" || capital == "" || continent == "")
                {
                    MessageBox.Show("Not specified one of values");
                }
                if (!double.TryParse(textBox3.Text, out double population) || !double.TryParse(textBox4.Text, out double square))
                {
                    MessageBox.Show("Population or Square is not a valid number.");
                    return;
                }

                using (var db = new CountryContext())
                {
                    var query = await db.Countries.SingleOrDefaultAsync(c => c.Country == country);

                    if (query == null)
                    {
                        MessageBox.Show("Country not found.");
                        return;
                    }

                    // Обновляем данные
                    query.Capital = capital;
                    query.Population = population;
                    query.Square = square;
                    query.Continent = new Continent(continent);
                    await db.SaveChangesAsync();
                }

                MessageBox.Show("Country updated successfully!");







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) //Add button
        {
            AddCountry();
        }

        private void button2_Click(object sender, EventArgs e) //Remove button
        {
            RemoveCountry();
        }

        private void button3_Click(object sender, EventArgs e)//Edit button
        {
            ChangeCountry();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
