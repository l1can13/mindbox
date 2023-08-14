# Shape Library and Tests

This repository contains a C# library for calculating the properties of geometric shapes and corresponding unit tests.

## Introduction

The Shape Library provides classes to calculate the area, perimeter, and properties of geometric shapes such as circles and triangles. Additionally, there are test classes that validate the functionality of these shape classes.

## Features

- Calculate the area and perimeter of circles.
- Calculate the area, perimeter, and properties of triangles.
- Validate input values for non-negativity and non-nullness.
- Check whether a triangle is right-angled.
- Easily extensible for other shapes.

## Project Structure

The repository is structured as follows:

- `ShapeLibrary`: A C# library containing the shape classes and interfaces.
- `CircleTests`: Unit tests for the Circle class.
- `TriangleTests`: Unit tests for the Triangle class.

## Usage

You can use the Shape Library to perform geometric calculations in your C# projects. The library provides an interface `IShape` that defines common methods for all shapes, and classes `Circle` and `Triangle` that implement this interface.

Example usage:

```csharp
using ShapeLibrary;

// Create a circle
Circle circle = new Circle(5.0);
double circleArea = circle.Area();
double circlePerimeter = circle.Perimeter();

// Create a triangle
Triangle triangle = new Triangle(3.0, 4.0, 5.0);
double triangleArea = triangle.Area();
double trianglePerimeter = triangle.Perimeter();
bool isRightTriangle = triangle.IsRightTriangle();
```

## Running Tests
The unit tests are written using MSTest framework. You can run the tests using your preferred testing tool or the command line.

## Contributing
Contributions are welcome! If you find any issues or want to improve the library, feel free to open an issue or a pull request.