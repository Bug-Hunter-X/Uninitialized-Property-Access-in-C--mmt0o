# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been initialized.  Uninitialized properties can lead to unexpected behavior or exceptions, making debugging challenging.  The example shows how to correctly initialize the property to prevent this issue.

## Bug Description
The `ExampleClass` attempts to access the `MyProperty` before it's assigned a value.  Depending on the context, this might print the default value (0 for `int`) or throw a `NullReferenceException` if the property is a reference type.  This behavior can be inconsistent and difficult to track down.

## Solution
The solution provides multiple ways to initialize the property: in the constructor, directly within the property declaration, or within the `MyMethod` itself before accessing the property.