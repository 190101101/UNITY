/*
56 Transform Özellikler ve Methodlar 4
	objecti diger objectin childi edir..
	false - position deyishmir 
	true - parente gore pos deyishir 
*/ 
child.transform.SetParent(parent, false);

// script hansi objecte baglidirsa onu yox edir.
Destroy(gameObject, 3f);
