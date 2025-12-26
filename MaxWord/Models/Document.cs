using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MaxWord.Models
{
    public enum Formates
    {
        txt = 0,
        pdf = 1,
        rtf = 2
    }
    public class Document : INotifyPropertyChanged
    {
        public required string FileName { get; set; }

        private string _text;
        private Formates form;
        private DateTime createdDate;
        private DateTime modifiedDate;
        private string rtfContent;

        public string Text
        {
            get { return _text; }
            set 
            { 
                _text = value;
                OnPropertyChanged();
            }
        }

        public string RtfContent
        {
            get { return rtfContent; }
            set
            {
                rtfContent = value;
                OnPropertyChanged();
            }
        
        }

        public string FormString => Form.ToString();

        public Formates Form 
        {
            get { return form; }
            set 
            {
                form = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FormString));
            } 
        }

        public DateTime CreatedDate 
        { 
            get { return createdDate; }
            set 
            { 
                createdDate = value;
                OnPropertyChanged();
            }
        }
        public DateTime ModifiedDate 
        { 
            get { return modifiedDate; }
            set 
            {
                modifiedDate = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}