﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    public class Contact : INotifyPropertyChanged
    {
        private string contactName;
        private string contactNumber;
        private ImageSource image;

        public Contact()
        {

        }

        public string ContactName
        {
            get { return contactName; }
            set
            {
                if (contactName != value)
                {
                    contactName = value;
                    this.RaisedOnPropertyChanged("ContactName");
                }
            }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (contactNumber != value)
                {
                    contactNumber = value;
                    this.RaisedOnPropertyChanged("ContactNumber");
                }
            }
        }

        public ImageSource ContactImage
        {
            get { return this.image; }
            set
            {
                this.image = value;
                this.RaisedOnPropertyChanged("ContactImage");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }
    }
}
