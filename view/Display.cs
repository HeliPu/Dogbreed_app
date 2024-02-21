using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using DogForm;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Drawing2D;
using System.Net;
using System.Collections;
using System.Globalization;// nämä lisätty 6.2
using Newtonsoft.Json.Converters;




namespace DogForm
{
    public partial class DogForm : Form
    {
        //¤¤¤¤¤¤¤ MAHDOLLISTAA CONSOLE.WRITELINEN WINFORMSISSA ¤¤¤¤¤¤
        [DllImport("Kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        //¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤¤
        private System.Windows.Forms.ListBox listBoxBreeds;
        public List<KoiraOlio> LopullinenLista;
        /// TÄMÄ Lisätty 1.2

        public DogForm() //konstruktori
        {
            InitializeComponent();
            AllocConsole();
            // Console.WriteLine("moikku");
            listBoxBreeds = new ListBox();
            LopullinenLista = new List<KoiraOlio>();
            //Controls.Add(listBoxBreeds); // Tämä antaa listan suoraan 
            Controls.Add(cbRotuDropdown); //lisää Comboboxin dogFormiin
            LoadDogData();

            // Aseta DisplayMember ComboBoxiin
            cbRotuDropdown.DisplayMember = "Name"; // asettaa comboboxille näytettävän tiedon nimen/rodun perusteella
        }
        public void LoadDogData() //Metodi hakee koirarotujen tiedot The Dog API:sta
        {
            string apiUrl = "https://api.thedogapi.com/v1/breeds";

            try
            {
                HttpWebRequest jsonRequest = (HttpWebRequest)WebRequest.Create(apiUrl); //lähettää pyynnön API:lle
                HttpWebResponse jsonResponse = (HttpWebResponse)jsonRequest.GetResponse(); 
                string electricityString;
                using (System.IO.StreamReader JsonResponseReader = new(jsonResponse.GetResponseStream()))
                {
                    electricityString = JsonResponseReader.ReadToEnd();
                }

                electricityString = electricityString.Replace("-", "_");
                List<KoiraOlio> dogBreeds = JsonConvert.DeserializeObject<List<KoiraOlio>>(electricityString); //JSON-vastaus deserialisoidaan List<DogBreed> -olion listaksi.
               if (dogBreeds != null && dogBreeds.Count > 0) // testaus 6.2
                {
                    foreach (var breed in dogBreeds)
                    {
                        //object value = listBoxBreeds.Items.Add($"Breed: {breed.Name}, Origin: {breed.Origin}");
                        //string Description = String.Concat( // lisätty 6.2 ja otettu "" pois
                        string Description = String.Concat(
                        $"Temperament: {breed.Temperament}{Environment.NewLine} "+
                        $"bred_for: {breed.BredFor}{Environment.NewLine} "+
                        $"breed_group: {breed.BreedGroup}{Environment.NewLine} "+
                        $"life_span: {breed.LifeSpan}{Environment.NewLine} "
                         /// TÄNNE VOI LISÄTÄ KOIRAN TIETOJA JNE... 
                        );
                        KoiraOlio X = new KoiraOlio(breed.BredFor, Description, breed.History, breed.LifeSpan, breed.Name, breed.Origin,
                            breed.ReferenceImageId, breed.Temperament, breed.Height, breed.Weight, breed.Id, breed.BreedGroup, breed.CountryCode);
                        // Jokainen rotu käydään läpi, ja niistä luodaan KoiraOlio, joka lisätään LopullinenLista -listalle.
                        //rotujen nimet lisätään cbRotuDropdown - ComboBoxiin
                     
                        cbRotuDropdown.Items.Add(breed.Name);
                        LopullinenLista.Add(X);
                        // MessageBox.Show("moicuuu" + item.Name); testing
                        var uusiKoira = new KoiraOlio("Jotain", "Kuvaus", "Historia", "Elinaika", "Nimi", "Alkuperä", "KuvaID", "Luonne", new Eight(), new Eight(), 1234567890, BreedGroup.Herding, CountryCode.Au);
                        LopullinenLista.Add(uusiKoira);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Datan haku epäonnistui. Tarkista internetyhteys tai koita myöhemmin uudestaan.");
                Console.WriteLine("Error: EIW {0}", e.Message);
            }
        }
    
        public class DogBreedX
        {
            public string Name { get; set; }
            public string Origin { get; set; }
            public string BredFor { get; set; } //lisäsin nämä --->
            public string Description { get; set; }
            public string History { get; set; }
            public string LifeSpan { get; set; }
            public string ReferenceImageId { get; set; }
            public string Temperament { get; set; }
            public Eight Height { get; set; }
            public Eight Weight { get; set; }
            public long Id { get; set; }
            [JsonProperty("breed_group")]
            public BreedGroup BreedGroup { get; set; }
            public CountryCode CountryCode { get; set; }
        }
        //______________________________________________
        //TÄMÄ LISÄTTY
        private void btnEtsiClick(object sender, EventArgs e) //metodi kutsutaan kun käyttäjä painaa etsi nappulaa
        {
            // Tarkista, onko käyttäjä valinnut koirarodun
            if (cbRotuDropdown.SelectedItem == null)
            {
                MessageBox.Show("First, choose the breed of dog.");
                return;
            }
            string ValittuRotu = cbRotuDropdown.SelectedItem.ToString(); 
         
            int index = LopullinenLista.FindIndex(obj => obj.Name == ValittuRotu); // 0= Affenpinscher 1=Afghan Hound
            string Description = String.Concat(
                          //$" Name: {LopullinenLista[index].Name} \n " + // ei anna lisätä rotua 
                          $"TEMPERAMENT:\r\n {LopullinenLista[index].Temperament}\r\n " +
                          $"BRED FOR:\r\n {LopullinenLista[index].BredFor}\r\n " +
                          $"BREED GROUP:\r\n {LopullinenLista[index].BreedGroup}\r\n " +
                          $"LIFESPAN:\r\n {LopullinenLista[index].LifeSpan}\n "
                          /// TÄNNE VOI LISÄTÄ KOIRAN TIETOJA JNE...
                          );
           
            richTextInfoBox.Text = Description;
            // Hae kuvan URL API:sta
           string imageId = LopullinenLista[index].ReferenceImageId; //tätämä lisätty 2.2
            
            string imageUrl = $"https://cdn2.thedogapi.com/images/{imageId}.jpg";
           // MessageBox.Show(" imageUrl " + imageUrl);

            // Näytä kuva PictureBoxissa
            if (!string.IsNullOrEmpty(imageUrl))
            {
                pictureBoxDog.ImageLocation = imageUrl;
                
            }
            else
            {
                MessageBox.Show("Kuvan lataaminen epäonnistui.");
            }
        }
     
        public class DogImage
        {
            public string Url { get; set; }
        }
    
        private void kuva_label_Click(object sender, EventArgs e)
        {

        }

        private void Infobox_label_Click(object sender, EventArgs e)
        {

        }

        private void Koirarotu_label_Click(object sender, EventArgs e)
        {

        }

       private void textBoxDogInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextInfoBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
