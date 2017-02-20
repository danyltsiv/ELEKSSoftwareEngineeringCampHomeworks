using System;
using System.Collections.Generic;
using System.Windows.Forms;
using prac9task1MVC1.Entities;
using prac9task1MVC1.Contracts.Views;
using prac9task1MVC1.Contracts.Presenters;
namespace prac9task1MVC1
{
    public partial class EstablishmentsView : Form, IEstablishmentView
    {
        public EstablishmentsView()
        {
            InitializeComponent();
        }

        public IEstablishmentPresenter Presenter { get; set; }

        public Establishment GetSelectedEstablishment()
        {
            if (gridEstablishments.SelectedRows.Count < 1)
            {
                return null;
            }
            return gridEstablishments.SelectedRows[0].DataBoundItem as Establishment;
        }

        public void RefreshEstablishments(IEnumerable<Establishment> establishments)
        {
            gridEstablishments.DataSource = establishments;
            gridEstablishments.Refresh();
        }

        public void ShowView()
        {
            Show();
        }

        public void CloseView()
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Presenter.AddEstablishment();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Presenter.EditEstablishment();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Presenter.RemoveEstablishment();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            Presenter.ToggleEstablishments();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Presenter.RefreshData();
        }

        private void btn5random_Click(object sender, EventArgs e)
        {
            Presenter.Add5RandomEstablishments();
        }

        private void btnRecalculate_Click(object sender, EventArgs e)
        {
            Presenter.EstablishmentsRecalculateRating();
        }
    }
}
