# Fucking Singletons

A framework of patterns for avoiding antipatterns in Unity

![readme image](./README.png)

Inspired heavily (entirely) by [Ryan's talk](https://www.youtube.com/watch?v=raQ3iHhE_Kk) at Unite 2017, this is a framework that provides some tools that make writing better game code easier.

## Background

This framework depends heavily on ScriptableObjects to make things work. As such, you should have an understanding of what those are! The best way to get that understanding is likely from [this video](https://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/scriptable-objects).


## API

> Current version is `0.1.0`

These are the "tools" that the framework provides :tada:

### SOObject

> Abstract class

A `SOObject` represents some primitive type as a scriptable object. It's effectively a data wrapper.

### SOBool

A primitive wrapper, wrapping a boolean value. 

### SOFloat

A primitive wrapper, wrapping a float value. 

### SOInt

A primitive wrapper, wrapping an int value. 

### SOString

A primitive wrapper, wrapping a string value.

### SOReference

> Abstract class

A `SOReference` provides an abstraction layer for your systems - enabling them to work on data represented as `SOObject`s, or as constant values.

### SOBoolReference

Abstraction representing either a `SOBool` or a boolean constant.

### SOFloatReference

Abstraction representing either a `SOFloat` or a float constant.

### SOIntReference

Abstraction representing either a `SOInt` or an int constant.

### SOStringReference

Abstraction representing either a `SOString` or a string constant.

### SOEvent<T0,T1,T2,T3>

A `SOEvent` represents an event that can be raised, and a collection of listeners that will be notified in the event that it is, in fact, raised.

#### Raise

Raises the event (optionally with parameters)

#### RegisterListener

Registers a listener

#### UnregisterListener

Unregisters a listener

### SOEventListener<T0,T1,T2,T3>

A `SOEventListener` represents the response to a `SOEvent` - namely the action(s) to take when it is raised

### SOSet

A `SOSet` represents a collection of items.

#### Items

Returns the child items

#### GetChildCount

Returns the count of the child items

#### Add

Adds a child item

#### Remove

Removes a child item

### GameObjectSOSet

A set wrapper for storing `GameObject`s

#### GameObjectSOSetElement

A runtime helper for adding `GameObject`s to a `GameObjectSOSet` - this enables runtime population of a set

### Metadata

Contains information about the framework (like version, editor tooling information, etc)