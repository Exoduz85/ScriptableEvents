using UnityEngine;
public class Spin : MonoBehaviour {
    // Called whenever the scriptable event is triggered.
    public void SpinMe() {
        this.GetComponent<Rigidbody>().AddTorque(new Vector3(
            Random.Range(-359, 359),
            Random.Range(-359, 359),
            Random.Range(-359, 359)
        ));
    }
}