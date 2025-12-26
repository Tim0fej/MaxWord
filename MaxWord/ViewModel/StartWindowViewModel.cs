using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxWord.Models;

namespace MaxWord.ViewModel
{
    class StartWindowViewModel
    {
        public ObservableCollection<Document> Documents { get; set; }


        public StartWindowViewModel()
        {
            Documents = new ObservableCollection<Document>();
            Documents.Add(new Document()
            {
                FileName = "NICATINAMEDADIDENDINUCLEOTID",
                Form = 0,
                ModifiedDate = DateTime.Now,
                CreatedDate = DateTime.Now
            });

            Documents.Add(new Document()
            {
                FileName = "GIDROKSIPROPILMETILCELULOZA",
                Form = 0,
                ModifiedDate = DateTime.Now,
                CreatedDate = DateTime.Now
            });
        }


    }



}
