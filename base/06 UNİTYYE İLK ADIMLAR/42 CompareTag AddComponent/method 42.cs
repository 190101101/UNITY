// burada bir obje activse passiv edirik.. 
// amma oyun bashlamadan passiv ise active olmaz!
gameObject.SetActive(false);
gameObject.SetActive(true);

// component elave etmek.. meselen capsule collider ve ya rigidbody vermek
Rigidbody added = gameObject.AddComponent<Rigidbody>();

// tag ile tutmaq find kimi bir shey
print(gameObject.CompareTag("Player"));