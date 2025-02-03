// gameObject skriptin bagli oldugu objelere.
gameObject.GetComponent<CapsuleCollider>().enabled = false;

// bu kod daha eski ve uzun.
CapsuleCollider capsulum = gameObject.GetComponent(typeof(CapsuleCollider)) as CapsuleCollider;

// bu ise daha kisa ve yeni
CapsuleCollider capsulum = GetComponent<CapsuleCollider>();

// bu xoshuma gelmedi 1 ci kimi
CapsuleCollider capsulum = gameObject.GetComponent("CapsuleCollider") as CapsuleCollider;



