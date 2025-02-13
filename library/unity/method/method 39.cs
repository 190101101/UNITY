/*
my object e bagli olan test01 scriptinden 
parent ve onun childrenlerine bagli olan test02 scriptdeki
public int age ve diger ozellikleri manupulasiya edirik
*/
GameObject.Find("parent").GetComponent<Test02>().age = 2;
GameObject.Find("parent/child").GetComponent<Test02>().age = 3;


// objeni her defe yeniden secmemek ucun bir defe var yaradib etmek
GameObject my;
my = GameObject.Find("parent");
my.GetComponent<Test02>().age = 2;

// tag ile search etmek daha verimlidir.
my = GameObject.FindWithTag("parent");
my.GetComponent<Test02>().age = 2;

// burada ise child obje child tag bagladim ve o parent objesinin altindadir
my = GameObject.FindWithTag("child");