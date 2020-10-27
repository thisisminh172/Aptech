using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M6DataBindingAlbumApp
{
    public partial class Detail : Form
    {
        private BindingSource formDataSource;
        public Detail(BindingSource bindingSource)
        {
            this.formDataSource = bindingSource;
            InitializeComponent();
            //dataBinding
            txtArtist.DataBindings.Clear();
            txtAlbum.DataBindings.Clear();
            txtRelease.DataBindings.Clear();
            txtRating.DataBindings.Clear();
            //databinding
            txtAlbum.DataBindings.Add("Text", formDataSource, "cd",true,DataSourceUpdateMode.OnPropertyChanged);
            txtArtist.DataBindings.Add("Text", formDataSource, "artist",true, DataSourceUpdateMode.OnPropertyChanged);
            txtRelease.DataBindings.Add("Text", formDataSource, "releaseDate",true, DataSourceUpdateMode.OnPropertyChanged);
            txtRating.DataBindings.Add("Text", formDataSource, "rating",true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
