# OldPhoneSolution


## Overview

**OldPhoneSolution** is a C# project that simulates typing on an old mobile phone keypad. It includes the `OldPhone` class, which converts a sequence of keypresses into corresponding text, and a set of unit tests to verify its functionality.


## Project Structure

* **OldPhone.cs** : Contains the `OldPhone` class with methods to convert keypress sequences into text.
* **OldPhoneTests.cs** : Contains unit tests for the `OldPhone` class.


## OldPhone Class


### Key Features

* **Keypad Mapping** : Maps digits to corresponding letters as found on old mobile phone keypads.
* **End Input** : Uses `#` to indicate the end of input.
* **Backspace** : Uses `*` to simulate the backspace operation.

### Methods

* **OldPhonePad(string input)** : Converts a string of keypresses into the corresponding text.
* **HandleBackspace(StringBuilder result)** : Handles the backspace operation.
* **HandleDigit(string input, StringBuilder result, int i, char currentChar)** : Handles digit input and appends the corresponding letter to the result.
* **CountConsecutiveDigits(string input, ref int i, char currentChar)** : Counts consecutive same digits in the input string.

## Unit Tests

The unit tests are written using the `OldPhoneTests` namespace and verify the functionality of the `OldPhone` class. The tests include:

* **Test_Output_E** : Verifies that the input “33#” produces the output “E”.
* **Test_Output_B** : Verifies that the input “227 *#” produces the output “B”.
* **Test_Output_HELLO** : Verifies that the input “4433555 555666#” produces the output “HELLO”.
* **Test_Output_TURING** : Verifies that the input “8 88777444666 * 664#” produces the output “TURING”.
* **Test_Output_HELLOWORLD_WITH_AMPERSAND** : Verifies that the input “4433555 555666196667775553#” produces the output “HELLO&WORLD”.

## Getting Started

### Prerequisites

* .NET SDK
* Visual Studio or any C# compatible IDE

### Running the Tests

1. Open the solution in Visual Studio.
2. Build the solution to restore dependencies.
3. Run the tests using the Test Explorer.

## Usage

To use the `OldPhone` class, call the `OldPhonePad` method with a string of keypresses:

```csharp
using OldPhoneNS;

string result = OldPhone.OldPhonePad("4433555 555666#");
Console.WriteLine(result); // Output: HELLO

```
