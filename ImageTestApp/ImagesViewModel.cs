using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTestApp
{
    public class ImagesViewModel
    {
        public ObservableCollection<string> Images { get; }

        private readonly string[] _images = {
            "https://i.alza.cz/Foto/ImgGalery/Ikony/Mobilni_telefony/Wearables/zdravi.png",
            "https://i.alza.cz/Foto/ImgGalery/IkonyPatra/Mobilni_telefony/120/wearables.png",
            "https://i.alza.cz/Foto/category/120/18855742.png", "https://i.alza.cz/Foto/category/120/18855843.png",
            "https://i.alza.cz/Foto/ImgGalery/IkonyPatra/Elektronika/120/sc.png",
            "https://i.alza.cz/Foto/ImgGalery/IkonyPatra/Kategorie/Mobilni_telefony/Chytre_telefony.jpg",
            "https://i.alza.cz/Foto/category/120/18856129.png",
            "https://i.alza.cz/Foto/ImgGalery/IkonyPatra/Kategorie/Televizory/smart_tv.jpg",
            "https://i.alza.cz/Foto/category/40/18855744_1.png"
        };

        public ImagesViewModel()
        {
            Images=new ObservableCollection<string>();            
        }

        public void LoadHttp()
        {
            Images.Clear();
            foreach (var image in _images)
            {
                Images.Add(image.Replace("https:","http:"));
            }
        }

        public void LoadHttps()
        {           
            Images.Clear();
            foreach (var image in _images)
            {
                Images.Add(image);
            }
        }
    }
}
