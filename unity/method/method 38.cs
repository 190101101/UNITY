/*
object oz parent objectlerinde deyishiklik ede biler
bu kimi ve parent level ferq etmir parent/child/granchild
*/ 

GetComponentInParent<AudioSource>().mute = true;

/*
burda ise parent -> childa aid olanlari deyishir.
*/ 
GetComponentInChildren<AudioSource>().mute = true;

/*
<> icinde olanlar hemin objectin ozellikleridir
() function oldugunu bildirir.
*/ 

// but methodlarin coxlu halida var
GetComponentsInChildren<CapsuleCollider>();
GetComponentsInParent<CapsuleCollider>();
