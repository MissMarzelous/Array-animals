# Array-animals
Array-animals
# 🧩 OOP Fundamentals — Polymorphism, Abstract Classes & Interfaces

A C# (.NET Core 3.1) project that demonstrates core object-oriented
programming (OOP) principles including inheritance, polymorphism,
abstract classes, and interfaces. The project models a simple real-world
system using a well-structured class hierarchy.

---

## 📋 Features

- Abstract base class defining shared structure and behavior
- Concrete derived classes that override abstract methods
- Interface implementation demonstrating contract-based design
- Polymorphic method calls through base class references
- Demonstrates the "is-a" and "can-do" OOP relationships

---

## ⚙️ How It Works

- An `abstract` class defines shared properties and an abstract method
- Two or more derived classes extend the base and provide
  their own implementations of the abstract method
- An `interface` is defined and implemented by one or more classes
- A runner class instantiates objects and calls methods
  polymorphically through base class references

---

## 💡 Example Usage
Animal: Dog
Sound: Woof!
Can Fly: No
Animal: Bird
Sound: Tweet!
Can Fly: Yes

---

## 🛠️ Technologies Used

| Technology         | Purpose                                     |
|--------------------|---------------------------------------------|
| C# 8.0             | Core programming language                   |
| .NET Core 3.1      | Runtime framework                           |
| Abstract Classes   | Shared structure with enforced overrides    |
| Interfaces         | Contract-based capability definition        |
| Polymorphism       | Unified treatment of different object types |

---

## 🎓 Learning Outcomes

- Understanding the difference between abstract classes and interfaces
- Implementing polymorphism through method overriding
- Designing class hierarchies that follow the Open/Closed Principle
- Using base class references to call overridden methods

---

## 📁 Folder Structure
E3-array/
├── E3-array/
│   ├── Program.cs          ← Runner / entry point
│   ├── BaseClass.cs        ← Abstract base class
│   ├── DerivedClassA.cs    ← First concrete class
│   ├── DerivedClassB.cs    ← Second concrete class
│   ├── IMyInterface.cs     ← Interface definition
│   └── E3-array.csproj
├── array_animals.png
├── .gitignore
├── LICENSE
└── README.md

---

## 🚀 How to Run

```bash
git clone https://github.com/MissMarzelous/E3-array.git
cd E3-array/E3-array
dotnet run
```

---

## 📸 Screenshots

###Console Output
![Output](array_animals.png)

---

## 👩‍💻 Author

**MissMarzelous** — C# .NET Core student project
