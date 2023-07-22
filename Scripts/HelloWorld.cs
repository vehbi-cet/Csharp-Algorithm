using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    //Fonksiyona Ataycağımız Değeri Burda Vericez
    void Start()
    {
     Bolenler(6,77);

        
    }

    //Fonksiyonun Yazıldığı Kısım
    void Bolenler(int a, int b){

        string Deger = "Tüm Liste: "; //Sonuçların Birleşeceği Yer
        string ciftDeger = "İkiye Bölünebilnler: ";
        string üclüDeger = "Üçe Bölünebilenler: ";
        string dortluDeger ="Dörde Bölünebilenler: ";
        string besliDeger ="Beşe Bölünebilenler: ";
        for(int i = a; i < b+1; i++)  //Döngü uygulayanan yer
        {

              Deger += i + "-"; //Bütün Sayıları Bulduğumuz yer
              //Bmlünebbilen sayıları bulduğumuz yer
            if(i%2 == 0){
                ciftDeger += "-" + i  ;
            }if(i%3 == 0){
                üclüDeger += "-" + i  ;
            }if(i%4 == 0){
                dortluDeger += "-" + i   ;
            }if(i%5 == 0){
                besliDeger += "-" + i   ;
            }
        }

        //Sonuçları Yazdırdığımız Yer
        print(Deger);
        print(ciftDeger);
        print(üclüDeger);
        print(dortluDeger);
        print(besliDeger);
    }



}
