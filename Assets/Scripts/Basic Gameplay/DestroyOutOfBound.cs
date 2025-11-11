using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Bu, pizzalarýn çarpacaðý "üst" sýnýrdýr
    private float topBound = 30.0f;

    // Bu, hayvanlarýn çarpacaðý "alt" sýnýrdýr
    private float lowerBound = -10.0f;

    // Update is called once per frame
    void Update()
    {
        // ----- PÝZZALAR ÝÇÝN ÜST SINIR KONTROLÜ -----
        // Eðer Z pozisyonum 30'un üstüne çýkarsa...
        if (transform.position.z > topBound)
        {
            // ...kendimi yok et!
            Destroy(gameObject);
        }

        // ----- HAYVANLAR ÝÇÝN ALT SINIR KONTROLÜ -----
        // Eðer Z pozisyonum -10'un altýna düþerse...
        else if (transform.position.z < lowerBound)
        {
            // ...kendimi yok et!
            Destroy(gameObject);
        }
    }
}
