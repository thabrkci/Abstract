public class Calculate : Abstracthome
{
    public double Uzunluk { get; set; }/*get: Bu ifade, özelliğin değerini döndürmek için kullanılır. Örneğin, Uzunluk özelliği için bir değer almak istediğinizde get bloğu devreye girer ve o özelliğin değerini döndürür.
                                         set: Bu ifade, özelliğin değerini ayarlamak için kullanılır. Örneğin, Uzunluk özelliğine bir değer atamak istediğinizde set bloğu devreye girer ve o özelliğin değerini ayarlar.*/
    public double Genislik { get; set; }

    public override double AlanHesapla()
    {
     return Uzunluk*Genislik;
    }


}
    