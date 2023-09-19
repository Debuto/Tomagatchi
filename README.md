# Project Name: Deante's Bakery

### By: **Deante Cacatian**

## Setup/Install Instructions:

* In order to run project: <br> (please install necessary technologies...)

1. Clone this repo.

2. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "bakery.solution".

3. In the command line, run the command "dotnet run" to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal.

4. Optionally, you can run "dotnet build" to compile this console app without running it.
<br>

## Description:

A C# console application for a bakery that prompts a for user input to determine an order amount (Quantity) and a cost for each order (Total cost).

<br>

---

# Technologies used: 
- VS code
- .NET https://dotnet.microsoft.com/en-us/download/dotnet/
- C#

<br>

# Tests:
- Change directory to Bakery.tests folder (command: cd Bakery.tests)
- dotnet test to run tests
- Has tests for 2 models in Bakery folder, tests all classes, methods, etc.


# Known bugs:

Issue with Stats.cs lines 20-21 unable to run Timer related methods.

(Is commented out for now...)
// TimerCallback timerCallback = new TimerCallback(PassTime);
// dethklok = new Timer(PassTime, null, 0, 10000);

#### Copyright (c) 2023 Deante Cacatian

- Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

- The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

- THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.