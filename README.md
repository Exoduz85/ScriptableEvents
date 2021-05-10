# ScriptableEvents

A demo project on how to use Scriptable events.

With simplicity create and use scriptable events you can cross reference objects or prefabs across scenes.

Easy to implement, easy to use.

# Documentation

Right click -> Create -> Scriptable Event.

<img width="489" alt="Skärmavbild 2021-05-10 kl  15 03 28" src="https://user-images.githubusercontent.com/47660094/117663364-e3395080-b1a0-11eb-9a5f-ad3aeab01814.png">

Name the event whatever you feel like it should reflect. 

<img width="323" alt="Skärmavbild 2021-05-10 kl  15 09 14" src="https://user-images.githubusercontent.com/47660094/117664112-b20d5000-b1a1-11eb-8c70-615de9a80d6c.png">

In order to use and fire off the scriptable event you need to add it as a field to the script you wish to invoke the event from.

<img width="374" alt="Skärmavbild 2021-05-10 kl  15 10 36" src="https://user-images.githubusercontent.com/47660094/117664276-e41eb200-b1a1-11eb-87da-53bf1b365479.png">

```cs
public class SomeEventClass : MonoBehaviour, IPointerClickHandler {
        // The scriptable event you want to use (to fire off)
        [SerializeField] ScriptableEvent someScriptableEvent;
        
        public void OnPointerClick(PointerEventData eventData) {
            // Call the Invoke when you want to fire off the event.
            someScriptableEvent.Invoke();
        }
    }
```

Now that you have a method for firing off the scriptable event from, you can add the "ScriptableEventListener.cs" to any object you wish should listen to that event.

Drag and drop the Scriptable event object into the scriptable event slot in the ScriptableEventListener script.

<img width="375" alt="Skärmavbild 2021-05-10 kl  15 11 39" src="https://user-images.githubusercontent.com/47660094/117664411-087a8e80-b1a2-11eb-82ab-490dd25d0cbd.png">

Hit the plus button to add to the list of reactions.

<img width="384" alt="Skärmavbild 2021-05-10 kl  15 13 03" src="https://user-images.githubusercontent.com/47660094/117664659-52637480-b1a2-11eb-93ac-2ac904c1bb4c.png">

Drag and drop the object that you want to use in the slot of the unity event, and add the reaction you wish to use for the event.

<img width="478" alt="Skärmavbild 2021-05-10 kl  15 14 51" src="https://user-images.githubusercontent.com/47660094/117664806-7aeb6e80-b1a2-11eb-8d67-c33bba5ec168.png">

The reaction can be anything from changing the text of a textfield to killing a enemy when that enemy health is zero.

In our demo scene, we call upon the "spin.cs" script to use the SpinMe() method when the Scriptable Event is invoked and we as a listener can react.

Try it: :)

<img width="391" alt="Skärmavbild 2021-05-10 kl  15 17 33" src="https://user-images.githubusercontent.com/47660094/117665168-da497e80-b1a2-11eb-95c9-88f6892628dc.png">
