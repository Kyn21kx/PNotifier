
# PNotifier - Know when your processes are done... you know, like a toaster or a wahing machine.

## Why?
PNotifier is a simple script that lets you know when a process executed through the command line has finished by playing a small tune to your console

I mainly made it so I know when my C++ apps are done compiling, because sometimes I forget I even sent the command out.

## Installation
Just clone the repo using `git clone` and then build with either `dotnet build` or with Microsoft Visual Studio.

After the program is built, add the executable's path to your `PATH` environment variable so you can call it from the terminal.

## Usage
Just precede any command you want to run with `PNotifier`, i.e.
```ps
# Compile some C++
PNotifier gcc someFile.cpp

# Update / install dependencies
PNotifier npm install -g somePackage
```

