# Inheritance

Inheritance allows use to reuse behaviour without the need to repeat ourselves in different classes.

In C#, every class implicitely inherits from the Object class.
This is the reason why we have access to methods such as ToString().

It's also important to note that in C#, a class can only inherit from a single one. For example:

```csharp
// We could have:
class A {
  //...
}

// Class B inherits from A
class B : A {
  //...
}

// Class C inherits from B that inherits from A
class C : B {
  //...
}

// but NOT
// class C : A, B {
```

When we inherit from a class, we have access to its fields, properties and methods as long as those are public or protected.

For example, if we have the following classes:

```csharp
class Animal {
  public void Eat() => Console.WriteLine("Animal is eating...");
}

class Dog : Animal {
}
```

We can access the eat method from an instance of the Dog class like so:

```csharp
Dog dog = new Dog();
dog.Eat(); // This will print "Animal is eating..."
```

<!-- virtual -->

Now, what if we wanted to change the Eat method to be more accurate for the dog?
In order to do that, we could add the `virtual` keyboard to the Eat method in the parent class 
(Animal in this example) and override it in the child class (Dog).

It would look like this:

```csharp
class Animal {
  public virtual void Eat() => Console.WriteLine("Animal is eating...");
}

class Dog : Animal {
  public override void Eat() => Console.WriteLine("Dog is eating bones and meat...");
}
```

And then, in our Program.cs file:

```csharp
Animal animal = new Animal();
animal.Eat(); // This will print "Animal is eating..."

Dog dog = new Dog();
dog.Eat(); // This will print "Dog is eating bones and meat..."
```

By default, each class has an empty constructor if no one is specified so in reality:

```csharp
class Animal {
}

class Dog : Animal {
}
```

is the same as:

```csharp
class Animal {
  public Animal() {}
}

class Dog : Animal {
  public Dog() : base() {}
}
```

Notice that the child class (Dog) will always call a constructor of the parent class (Animal).
By default, if not specified, the child class (Dog) will call the parameterless constructor from the parent (Animal).

In order to specify a particular constructor, we use the `base` keyword:

```csharp
class Animal {
  public Animal() {}
  public Animal(string name) {}
}

class Dog : Animal {
  public Dog(string name) : base(name) {}
}
```

Note that the parent class' (Animal) constructor will be called first before executing the code inside the child class (Dog).

The `base` keyword can also be used to call a method from the parent class.
For example, when overriding a method, we may want to add some feature while keeping the original code.
In that case, we could do like the following:

```csharp
class Animal {
  public virtual void Run() => Console.WriteLine("Running!");
}

class Dog : Animal {
  public override void Run()
  {
    Console.Write("In 3, 2, 1... ");
    base.Run();
  }
}
```

And then, in our Program.cs file:

```csharp
Animal animal = new Animal();
animal.Run(); // This will print "Running!"

Dog dog = new Dog();
dog.Run(); // This will print "In 3, 2, 1... Running"
```
