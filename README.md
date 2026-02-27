## Unity-BitFlags

### Table of Contents

- [Introduction](#introduction)
- [Usage](#usage)
  - [Setting Bit Flags](#setting-bit-flags)
  - [Getting Bit Flags](#getting-bit-flags)
  - [ToString Method](#tostring-method)

### Introduction

This script provides a way to manage multiple flags using a single `uint` variable. Each bit in the `uint` represents one flag, and you can easily set and get individual bits or all flags at once.

### Usage

#### Setting Bit Flags

You can set a specific bit by calling the `SetBitFlag` method with the index of the flag and a boolean value indicating whether to set or reset the bit. For example:

```csharp
BitFlags flags = new BitFlags(0);
flags.SetBitFlag(5, true); // Set the 6th bit
```

#### Getting Bit Flags

To check if a specific bit is set, you can use the `GetBitFlag` method with the index of the flag. For example:

```csharp
bool isSet = flags.GetBitFlag(5); // Check if the 6th bit is set
```

#### ToString Method

You can convert all flags to a string by calling the `ToString` method. This will return a binary representation of the flags, where each bit corresponds to one flag.

```csharp
string binaryRepresentation = flags.ToString();
```

### Example Usage

Here's an example of how you might use this script in a Unity project:

```csharp
using UnityEngine;
using UsefulUtilities;

public class FlagManager : MonoBehaviour
{
    private BitFlags _flags;

    void Start()
    {
        _flags = new BitFlags(0);

        // Set the 6th bit
        _flags.SetBitFlag(5, true);

        // Check if the 6th bit is set
        bool isSet = _flags.GetBitFlag(5);

        // Convert all flags to a string
        string binaryRepresentation = _flags.ToString();

        Debug.Log("Flags: " + binaryRepresentation);
    }
}
```

### Notes

- The `BitFlags` struct is designed to handle up to 32 flags.
- The `SetBitFlag` method only supports setting single bits at a time. If you need to set multiple bits simultaneously, you may need to implement additional logic.
- The `ToString` method returns a string representation of all flags in binary format.
