using UnityEngine;
public class Spin : MonoBehaviour {
    public void SpinMe() {
        this.GetComponent<Rigidbody>().AddTorque(new Vector3(
            Random.Range(-359, 359),
            Random.Range(-359, 359),
            Random.Range(-359, 359)
        ));
    }
}