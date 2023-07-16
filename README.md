# Pairs
An alternate for Standard C++ Pair **`std::pair<T1, T2>`** in **C#**

# Documentation

- ## Pair
  - ### Constructors
  - ```C#
    public Pair(TF firstArg, TS secondArg);
    ```
    <br>
  - ### Declaration & Initialization
    - ```C#
      Pair<T1 /* First Type */, T2 /* Second Type */ > myPair = new(
      
      // Constructor-Initialization (Optional)
      /* First Type Instance */
      /* Second Type Instance */
      
      );
      ```

    - ```C#
      Pair<string /* e.g, Name */, int /* e.g, Age */> myPair = new("Johan", 23);
      ```
  - ### Manual Initialization
    - ```C#
      Pair<string /* e.g, Name */, int /* e.g, Age */> myPair = new();
      myPair.First = "Johan";
      myPair.Second = "Age";
      ```
      
  - ### Accessing
    - ```C#
      myPair.First;
      // Johan
      
      myPair.Second;
      // 23
      ```

----

- ## Pairs
  Is just a collection of `Pair` in a `List` like `List<Pair<T1, T2>>`
  - ### Constructors
  - ```C#
    public Pairs(IEnumerable<Pair<TF, TS>> pairsArg, uint maximumSizeArg = 10000);
    public Pairs(uint maximumSizeArg = 10000);
    ```
    <br>
  - ### Declaration & Initialization
    - ```C#
      Pairs<T1 /* First Type */, T2 /* Second Type */ > myPairs = new(
      
      // Constructor-Initialization (Optional)
      /*
      IEnumerable<
          Pair<
            TF,
            TS
        >
      >
      */
      
      );
      ```

    - ```C#
      Pairs<string /* e.g, Name */, int /* e.g, Age */> myPairs = new();
      ```
  - ### Adding Item
    - ```C#
      Pairs<string /* e.g, Name */, int /* e.g, Age */> myPairs = new();
      myPairs.Add("Johan", 23);
      myPairs.Add("Nina", 19);
      myPairs.Add("Tenma", 28);
      ```
      
  - ### Accessing
    - ```C#
      foreach (var /* Pair<string, int> */ pairMember in myPairs) {
        Console.WriteLine($"{pairMember.First} - {pairMember.Second}");
      }
      
      // ----------- [OUTPUT] -----------
      // Johan - 23
      // Nona - 19
      // Tenma - 28
      ```
