using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MaxWord.Models
{
    enum Formates
    {
        txt = 0,
        pdf = 1,
        rtf = 2
    }
    internal class Document
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set 
            { 
                _text = value;
                OnPropertyChanged();
            }
        }

        public Formates Form { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}