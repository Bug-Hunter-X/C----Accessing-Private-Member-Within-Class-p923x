# C# - Accessing Private Member Within Class

This repository demonstrates a common C# coding practice that, while technically allowed, is generally considered bad form.  The code directly accesses a private member variable from within the class. While it works, this violates the principle of encapsulation and leads to maintainability issues.

The `bug.cs` file shows the problematic code. The `bugSolution.cs` file demonstrates a corrected version using the property.