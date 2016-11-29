using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SimpleBindingMVVM.Annotations;

namespace SimpleBindingMVVM
{
    class ViewModel : INotifyPropertyChanged
    {
        public string Name { get; set; }

        private ObservableCollection<Model> _models;

        public ObservableCollection<Model> Models
        {
            get { return _models; }
            set { _models = value; }
        }

        public ViewModel()
        {
            _models = new ObservableCollection<Model>();
            _models.Add(new Model("Henrik"));
            _models.Add(new Model("Peter"));
            _models.Add(new Model("Vibeke"));
            Name = "Navn";

        }

        public void Add() { Models.Add(new Model(Name)); OnPropertyChanged();}


        #region PropertyChangeSupport
       public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        
    }
}
