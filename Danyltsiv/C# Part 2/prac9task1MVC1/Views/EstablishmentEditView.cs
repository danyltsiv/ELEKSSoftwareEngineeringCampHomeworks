using System;
using System.Collections.Generic;
using prac9task1MVC1.Entities;
using System.Windows.Forms;
using prac9task1MVC1.Contracts.Views;
using prac9task1MVC1.Contracts.Presenters;
namespace prac9task1MVC1
{
    public partial class EstablishmentEditView : Form, IEstablishmentEditView 
    {
        public EstablishmentEditView()
        {
            InitializeComponent();
        }

        public IEstablishmentEditPresenter Presenter { get; set; }

        public Establishment GetEstablishment()
        {
            return new Establishment
            {
                Name = textName.Text,
                Address = textAddress.Text,
                Rating = int.Parse(textRating.Text),
                Opened = radioOpened.Checked
            };
        }

        public void SetEditedEstablishment(Establishment establishment)
        {
            textName.Text = establishment.Name;
            textAddress.Text = establishment.Address;
            textRating.Text = establishment.Rating.ToString();
            radioOpened.Checked = establishment.Opened;
            radioClosed.Checked = !establishment.Opened;
        }
        public void ShowView()
        {
            ShowDialog();
        }

        public void CloseView()
        {
            Close();
        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            Presenter.SaveEstablishment();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Presenter.CancelEditing();
        }
    }
}
