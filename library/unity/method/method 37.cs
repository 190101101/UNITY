// 1 componenti secirik <> e gore. (). icindekileri gosterir
GetComponent<CapsuleCollider>().enabled = false;

//2 ilk once class icinde  sonra ise secmek
CapsuleCollider myCapsule;
myCapsule = GetComponent<CapsuleCollider>();

// 3 toplu shekilde
CapsuleCollider[] myCapsules;
myCapsules = GetComponents<CapsuleCollider>();
