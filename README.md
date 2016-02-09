# SafeFilenames
Methods for generating safe filenames.

## What's inside
This project includes two classes (static and extension) for cleaning strings.

## System requirements
1. NET Framework 4

## NuGet availability
This project is available on [NuGet](https://www.nuget.org/packages/SafeFilenames)

## Usage instructions
### Getting started
1. Add **SafeFilenames.dll** as a reference in your project.

### Cleaning strings for filenames
1. Depending on your use, there are two string methods available:
  - `SafeFilename`: Static class with `GetSafeFilename(string filename, string replacement)` method for cleaning strings
  - `SafeFilenameExtension`: Class with `GetSafeFilename(this string filename, string replacement)` extension method for cleaning strings
