# ScriptableEvents

With this you will be able to create scriptable objects which are events that you can use across scenes.

You may add the scriptable event listener to an object of your choice and simply drag the scriptable event you created to that listerner slot.

Then you add the scriptable event to the script you wish to invoke the even from, so that any listener may act accordingly.

Simply right click -> Create -> Scriptable Event.

Create event script -> Add field of ScriptableEvent (public / serialized)

In script -> Add method for invoking event (scriptableEvent.Invoke();)

Add the scriptable asset to the scripts ScriptableEventField.

Create asset in scene -> Add ScriptableListener script to asset.

Drag the ScriptableEvent Object to the ScriptableListeners scriptableEvent field.

Hit + on the event field -> Drag Object you wish to react when even triggers into slot of event.

Use Script on object or anything else you wish to use for reaction on event.

Can use multiple unity events to same Scriptable event.
