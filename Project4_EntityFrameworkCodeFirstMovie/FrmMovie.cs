﻿using Project4_EntityFrameworkCodeFirstMovie.DAL.Context;
using Project4_EntityFrameworkCodeFirstMovie.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_EntityFrameworkCodeFirstMovie
{
    public partial class FrmMovie : Form
    {
        public FrmMovie()
        {
            InitializeComponent();
        }

        MovieContext context = new MovieContext();
        private void btnGo_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Show();
        }

        private void btnMovieListele_Click(object sender, EventArgs e)
        {
            var values = context.Movies.ToList();
            dataGridView1.DataSource = values;
        }

        void CategoryList()
        {
            var values = context.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = values;
        }
        private void FrmMovie_Load(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnMovieAdd_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.MovieTitle = txtMovieName.Text;
            movie.Description = txtMovieDescription.Text;
            movie.CreatedDate = DateTime.Parse(mskCreatedDate.Text);
            movie.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            movie.Duration = int.Parse(txtMovieDuration.Text);
            context.Movies.Add(movie);
            context.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
        }

        private void btnMovieRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMovieId.Text);
            var value = context.Movies.Find(id);
            context.Movies.Remove(value);
            context.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
        }

        private void btnMovieSearch_Click(object sender, EventArgs e)
        {
            var values = context.Movies.Where(x => x.MovieTitle == txtMovieName.Text).ToList();
            dataGridView1.DataSource = values;
        }

        //içerisinde textbox'a girilen veriyi bulunduruanları listeler
        //mesela textbox'a ü girilsin içinde e olanları listeler
        private void btnMovieSearch2_Click(object sender, EventArgs e)
        {
            var values = context.Movies.Where(x => x.MovieTitle.Contains(txtMovieName.Text)).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnMovieUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMovieId.Text);
            var values = context.Movies.Find(id);
            values.Duration = int.Parse(txtMovieDuration.Text);
            values.MovieTitle = txtMovieName.Text;
            values.Description = txtMovieDescription.Text;
            values.CreatedDate = DateTime.Parse(mskCreatedDate.Text);
            values.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            context.SaveChanges();
            MessageBox.Show("İşlem Başarılı");
        }

        private void btnMovieWithCategory_Click(object sender, EventArgs e)
        {
            var values = context.Movies
                .Join(context.Categories, 
                movie => movie.CategoryId, 
                category => category.CategoryId, 
                (movie, category)=> new
            {
                    MoveId = movie.MovieId,
                    MovieTitle = movie.MovieTitle,
                    Description = movie.Description,
                    Duration = movie.Duration,
                    CategoryName = category.CategoryName,
            }).ToList();

            dataGridView1.DataSource= values;
        }
    }
}
