using deneme4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace deneme4.Views
{
    public partial class AboutPage : TabbedPage
    {
        public AboutPage()
        {
            InitializeComponent();


            var list = AboutPage.list();
            lstview1.ItemsSource = list;

            var list2 = AboutPage.List2();
            lstview2.ItemsSource = list2;

            var list3 = AboutPage.List3();
            lstview3.ItemsSource = list3;

            var list4 = AboutPage.List4();
            lstview4.ItemsSource = list4;
        }

        private static List<urun> list()
        {
            return new List<urun>
            {
                new urun{UrunIsmi= " cam set üstü ocak", UrunFiyat= 799.99, UrunResim="https://www.bim.com.tr/Uploads/aktuel-urunler/822_kucuk_543X467_kumtel-ocak.jpg"
                },
                new urun{UrunIsmi= "elektrikli su ısıtıcısı", UrunFiyat= 169.99, UrunResim="https://www.bim.com.tr/Uploads/aktuel-urunler/822_kucuk_543X467_kettle.jpg"
                },
                new urun{UrunIsmi= "Fonksiyonlu buharlı temizleyici", UrunFiyat= 649.00, UrunResim="https://www.bim.com.tr/Uploads/aktuel-urunler/822_kucuk_543X467_temizleyici.jpg"
                },




            };
        }


        private static List<urun2> List2()
        {
            return new List<urun2>
            {

                new urun2{UrunIsmi2= "4'lü çerezlik", UrunFiyat2= 29.99, UrunResim2="https://www.bim.com.tr/Uploads/aktuel-urunler/822_kucuk_543X467_cerezlik.jpg"
                },
                new urun2{UrunIsmi2= "meşrubat bardağı", UrunFiyat2= 22.99, UrunResim2="https://www.bim.com.tr/Uploads/aktuel-urunler/822_kucuk_543X467_lav.jpg"
                },
                new urun2{UrunIsmi2= "Porselen fincanlı çaydanlık", UrunFiyat2= 179.00, UrunResim2="https://www.bim.com.tr/Uploads/aktuel-urunler/822_kucuk_543X467_caydanlik.jpg"
                },

            };
        }


        private static List<urun3> List3()
        {
            return new List<urun3>
            {

                new urun3{UrunIsmi3= "4 Bölmeli Derin Dondurucu", UrunFiyat3= 3499.9, UrunResim3="https://www.bim.com.tr/Uploads/aktuel-urunler/822_buyuk_543X467_derin-dondurucu%20copy.jpg"
                },
                new urun3{UrunIsmi3= "HP mejanik oyuncu klavye", UrunFiyat3= 699.99, UrunResim3="https://www.bim.com.tr/Uploads/aktuel-urunler/822_kucuk_543X467_klavye.jpg"
                },
                new urun3{UrunIsmi3= "Wifi Yazıcı", UrunFiyat3= 849.00, UrunResim3="https://www.bim.com.tr/Uploads/aktuel-urunler/822_kucuk_543X467_yazici.jpg"
                },

            };
        }



        private static List<urun4> List4()
        {
            return new List<urun4>
            {

                new urun4{UrunIsmi4= "JBL Kulaklık", UrunFiyat4= 99.99, UrunResim4="https://www.bim.com.tr/Uploads/aktuel-urunler/822_kucuk_543X467_jbl.jpg"
                },
                new urun4{UrunIsmi4= "Canavar Kamyonlar", UrunFiyat4= 59.99, UrunResim4="https://www.bim.com.tr/Uploads/aktuel-urunler/822_kucuk_543X467_kamyonlar.jpg"
                },
                new urun4{UrunIsmi4= "Girift Kutu Oyunu", UrunFiyat4= 79.90, UrunResim4="https://www.bim.com.tr/Uploads/aktuel-urunler/822_kucuk_543X467_girift.jpg"
                },

            };
        }





    }
}