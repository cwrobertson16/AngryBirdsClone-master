using UnityEngine;
using System.Collections;

public class ParallaxScrolling : MonoBehaviour {

	Camera myCamera = new Camera();

	// Use this for initialization
	void Start () {
        myCamera = Camera.main;
        previousCameraTransform = myCamera.transform.position;
	}
				
	
	/// <summary>
	/// similar tactics just like the "CameraMove" script
	/// </summary>
	void Update () {
        Vector3 delta = myCamera.transform.position - previousCameraTransform;
        delta.y = 0; delta.z = 0;
        transform.position += delta / ParallaxFactor;


        previousCameraTransform = myCamera.transform.position;
	}

    public float ParallaxFactor;

    Vector3 previousCameraTransform;

    ///background graphics found here:
    ///http://opengameart.org/content/hd-multi-layer-parallex-background-samples-of-glitch-game-assets
}
