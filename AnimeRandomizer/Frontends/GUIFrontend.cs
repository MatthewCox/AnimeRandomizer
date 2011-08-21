using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AnimeRandomizer.Frontends
{
    public partial class AnimeRandomizerForm : Form
    {
        private const string c_imageDir = ".\\images\\";
        private readonly BindingSource _bindingSource = new BindingSource();

        public AnimeRandomizerForm()
        {
            InitializeComponent();

            if (!BackEnd.LoadAnimeXML("AnimeDatabase.xml"))
            {
                MessageBox.Show("AnimeDatabase.xml could not be found, a blank one has been created.",
                                "AnimeDatabase.xml Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                BackEnd.SaveAnime("AnimeDatabase.xml");
            }
            _bindingSource.DataSource = BackEnd.AnimeList;
            AnimeListBox.DataSource = _bindingSource;
            AnimeListBox.DisplayMember = "Name";
        }

        private void AnimeListBox_SelectedIndexChanged(object p_sender, EventArgs p_e)
        {
            RefreshDataArea();
        }

        private void AnimeNameBox_TextChanged(object p_sender, EventArgs p_e)
        {
            BackEnd.AnimeList[AnimeListBox.SelectedIndex].Name = AnimeNameBox.Text;
            RefreshListBox();
        }

        private void AnimeDescriptionBox_TextChanged(object p_sender, EventArgs p_e)
        {
            BackEnd.AnimeList[AnimeListBox.SelectedIndex].Description = AnimeDescriptionBox.Text;
        }

        private void AnimeSuggestedByBox_TextChanged(object p_sender, EventArgs p_e)
        {
            BackEnd.AnimeList[AnimeListBox.SelectedIndex].SuggestedBy = AnimeSuggestedByBox.Text;
        }

        private void buttonPick1_Click(object p_sender, EventArgs p_e)
        {
            var rand = new Random();
            AnimeListBox.SelectedIndex = rand.Next(BackEnd.AnimeListLength);
        }

        private void buttonPickAvailable_Click(object p_sender, EventArgs p_e)
        {
            var rand = new Random();
            int tempSelectedIndex = rand.Next(BackEnd.AnimeListLength);
            while (!BackEnd.AnimeList[tempSelectedIndex].Available)
            {
                tempSelectedIndex = rand.Next(BackEnd.AnimeListLength);
            }
            AnimeListBox.SelectedIndex = tempSelectedIndex;
        }

        private void buttonAddAnime_Click(object p_sender, EventArgs p_e)
        {
            BackEnd.AddAnime("<Name Here>", "<Description Here>", "<Suggested By Here>", "");
            RefreshListBox();
            AnimeListBox.SelectedIndex = 0;
            RefreshDataArea();
            AnimeNameBox.Select();
        }

        private void buttonRemoveAnime_Click(object p_sender, EventArgs p_e)
        {
            if (
                MessageBox.Show("Are you sure you want to remove " + AnimeNameBox.Text + "?", "Remove Anime",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BackEnd.RemoveAnime(AnimeListBox.SelectedIndex);
                RefreshListBox();
                RefreshDataArea();
            }
        }

        private void buttonSave_Click(object p_sender, EventArgs p_e)
        {
            BackEnd.SaveAnime("AnimeDatabase.xml");
            RefreshListBox();
            AnimeListBox.SelectedIndex = AnimeListBox.FindString(AnimeNameBox.Text);
            RefreshDataArea();
        }

        private void buttonExit_Click(object p_sender, EventArgs p_e)
        {
            Close();
        }

        private void RefreshListBox()
        {
            _bindingSource.ResetBindings(false);
        }

        private void RefreshDataArea()
        {
            AnimeNameBox.Text = BackEnd.AnimeList[AnimeListBox.SelectedIndex].Name;
            AnimeDescriptionBox.Text = BackEnd.AnimeList[AnimeListBox.SelectedIndex].Description;
            AnimeSuggestedByBox.Text = BackEnd.AnimeList[AnimeListBox.SelectedIndex].SuggestedBy;
            if (BackEnd.AnimeList[AnimeListBox.SelectedIndex].ImageFilePath != "")
            {
                AnimeImageBox.Load(c_imageDir + BackEnd.AnimeList[AnimeListBox.SelectedIndex].ImageFilePath);
                AnimeImageFilepath.Text = BackEnd.AnimeList[AnimeListBox.SelectedIndex].ImageFilePath;
            }
            else
            {
                var rand = new Random();
                string ext = "";
                switch (rand.Next(0, 2))
                {
                    case 0:
                        ext = ".gif";
                        break;
                    case 1:
                        ext = ".jpg";
                        break;
                }
                AnimeImageBox.Load(c_imageDir + "noimage" + ext);
                AnimeImageFilepath.Text = "";
            }
        }

        private void buttonBrowse_Click(object p_sender, EventArgs p_e)
        {
            var ofd = new OpenFileDialog {InitialDirectory = c_imageDir};
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filename = Path.GetFileName(ofd.FileName);

                BackEnd.AnimeList[AnimeListBox.SelectedIndex].ImageFilePath = filename;
                AnimeImageFilepath.Text = filename;
                AnimeImageBox.Load(c_imageDir + filename);
            }
            ofd.Dispose();
        }

        private void AnimeRandomizerForm_Load(object p_sender, EventArgs p_e)
        {
            splitContainer1.Panel1MinSize = 100;
            splitContainer1.Panel2MinSize = 225;
        }

        private void AnimeListBox_MouseDoubleClick(object p_sender, EventArgs p_e)
        {
            BackEnd.AnimeList[AnimeListBox.SelectedIndex].Available = !BackEnd.AnimeList[AnimeListBox.SelectedIndex].Available;
            RefreshListBox();
        }

        private void AnimeListBox_DrawItem(object p_sender, DrawItemEventArgs p_e)
        {
            p_e.DrawBackground();
            if (BackEnd.AnimeList[p_e.Index].Available)
            {
                p_e.Graphics.DrawString(
                    BackEnd.AnimeList[p_e.Index].Name,
                    new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold),
                    new SolidBrush(Color.Black),
                    p_e.Bounds
                    );
            }
            else
            {
                p_e.Graphics.DrawString(
                    BackEnd.AnimeList[p_e.Index].Name,
                    new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular),
                    new SolidBrush(Color.Black),
                    p_e.Bounds
                    );
            }
            p_e.DrawFocusRectangle();
        }
    }
}