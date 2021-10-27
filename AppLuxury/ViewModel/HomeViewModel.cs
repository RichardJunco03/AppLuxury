using AppLuxury.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppLuxury.ViewModel
{
    public class HomeViewModel
    {
        public ObservableCollection<Anillo> anillo { get; set; }
        public ObservableCollection<Reloj> reloj { get; set; }
        public ObservableCollection<Banner> banner { get; set; }
        public HomeViewModel()
        {
            reloj = new ObservableCollection<Reloj>
            {
                new Reloj{ImagenReloj="reloj1.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj2.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj3.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj4.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj5.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj6.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj7.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj8.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj9.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj10.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj11.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj12.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj13.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj14.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj16.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj17.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj18.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj19.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj20.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj21.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj22.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
                new Reloj{ImagenReloj="reloj23.jpeg",MarcaReloj="casio",ModeloReloj="GD-350-1B G-STOCK",PrecioReloj="S/979",OfertaReloj="S/729(Oferta)"},
               
            };
            anillo = new ObservableCollection<Anillo>
            {
                new Anillo{ImagenAnillo="anillo1.jpeg",MarcaAnillo="anella",ModeloAnillo="rl",PrecioAnillo="S/486",OfertaAnillo="S/466(Oferta)"},
                new Anillo{ImagenAnillo="anillo2.jpeg",MarcaAnillo="sara",ModeloAnillo="wn",PrecioAnillo="S/345",OfertaAnillo="S/321(Oferta)"},
                new Anillo{ImagenAnillo="anillo3.jpeg",MarcaAnillo="dolc",ModeloAnillo="kj",PrecioAnillo="S/789",OfertaAnillo="S/749(Oferta)"},
                new Anillo{ImagenAnillo="anillo4.jpeg",MarcaAnillo="nim",ModeloAnillo="kj",PrecioAnillo="S/648",OfertaAnillo="S/548(Oferta)"},
                new Anillo{ImagenAnillo="anillo5.jpeg",MarcaAnillo="sara",ModeloAnillo="rl",PrecioAnillo="S/658",OfertaAnillo="S/648(Oferta)"},
                new Anillo{ImagenAnillo="anillo6.jpeg",MarcaAnillo="sara",ModeloAnillo="rl",PrecioAnillo="S/415",OfertaAnillo="S/405(Oferta)"},
                new Anillo{ImagenAnillo="anillo7.jpeg",MarcaAnillo="dolc",ModeloAnillo="op",PrecioAnillo="S/897",OfertaAnillo="S/747(Oferta)"},
                new Anillo{ImagenAnillo="anillo8.jpeg",MarcaAnillo="anella",ModeloAnillo="op",PrecioAnillo="S/145",OfertaAnillo="S/125(Oferta)"},
                new Anillo{ImagenAnillo="anillo9.jpeg",MarcaAnillo="sara",ModeloAnillo="op",PrecioAnillo="S/987",OfertaAnillo="S/957(Oferta)"},
                new Anillo{ImagenAnillo="anillo10.jpeg",MarcaAnillo="pric",ModeloAnillo="wn",PrecioAnillo="S/345",OfertaAnillo="S/305(Oferta)"},
                new Anillo{ImagenAnillo="anillo11.jpeg",MarcaAnillo="anella",ModeloAnillo="op",PrecioAnillo="S/156",OfertaAnillo="S/106(Oferta)"},
                new Anillo{ImagenAnillo="anillo12.jpeg",MarcaAnillo="dolc",ModeloAnillo="kj",PrecioAnillo="S/354",OfertaAnillo="S/350(Oferta)"},
                new Anillo{ImagenAnillo="anillo13.jpeg",MarcaAnillo="nim",ModeloAnillo="rl",PrecioAnillo="S/741",OfertaAnillo="S/738(Oferta)"},
                new Anillo{ImagenAnillo="anillo14.jpeg",MarcaAnillo="anella",ModeloAnillo="zm",PrecioAnillo="S/315",OfertaAnillo="S/305(Oferta)"},
                new Anillo{ImagenAnillo="anillo15.jpeg",MarcaAnillo="pric",ModeloAnillo="wn",PrecioAnillo="S/658",OfertaAnillo="S/558(Oferta)"},
                new Anillo{ImagenAnillo="anillo16.jpeg",MarcaAnillo="pric",ModeloAnillo="qw",PrecioAnillo="S/567",OfertaAnillo="S/547(Oferta)"},
                new Anillo{ImagenAnillo="anillo17.jpeg",MarcaAnillo="anella",ModeloAnillo="qw",PrecioAnillo="S/631",OfertaAnillo="S/431(Oferta)"},
                new Anillo{ImagenAnillo="anillo18.jpeg",MarcaAnillo="nim",ModeloAnillo="zm",PrecioAnillo="S/315",OfertaAnillo="S/305(Oferta)"},
                new Anillo{ImagenAnillo="anillo19.jpeg",MarcaAnillo="dolc",ModeloAnillo="kj",PrecioAnillo="S/465",OfertaAnillo="S/395(Oferta)"},
                new Anillo{ImagenAnillo="anillo20.jpeg",MarcaAnillo="anella",ModeloAnillo="wn",PrecioAnillo="S/654",OfertaAnillo="S/620(Oferta)"},
                new Anillo{ImagenAnillo="anillo21.jpeg",MarcaAnillo="nim",ModeloAnillo="zm",PrecioAnillo="S/476",OfertaAnillo="S/418(Oferta)"},
                new Anillo{ImagenAnillo="anillo22.jpeg",MarcaAnillo="nim",ModeloAnillo="zm",PrecioAnillo="S/416",OfertaAnillo="S/358(Oferta)"},
                new Anillo{ImagenAnillo="anillo23.jpeg",MarcaAnillo="dolc",ModeloAnillo="wn",PrecioAnillo="S/687",OfertaAnillo="S/617(Oferta)"},
            };
            banner = new ObservableCollection<Banner>
            {
                new Banner{ImageBanner="banner1.jfif"},
                new Banner{ImageBanner="banner2.jpg"},
                new Banner{ImageBanner="banner3.jfif"},
                new Banner{ImageBanner="banner4.jfif"},
                new Banner{ImageBanner="banner5.jpg"},
                new Banner{ImageBanner="banner6.jfif"},
                new Banner{ImageBanner="banner7.jfif"},
                new Banner{ImageBanner="banner8.jpg"},

            };
        }
    }
}
