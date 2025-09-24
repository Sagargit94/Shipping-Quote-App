# 📦 Shipping Quote Console Application

This is a simple **C# console application** that calculates a shipping quote based on package weight and dimensions.  
Built as a beginner-friendly project for learning conditional statements, input validation, and basic arithmetic in C#.

---

## 🚀 Features
- Prompts the user for:
  - Package weight
  - Width
  - Height
  - Length
- Rejects packages:
  - Heavier than **50 lbs**
  - With total dimensions greater than **50 inches**
- Calculates shipping cost using:
  ```
  Quote = (Weight × Width × Height × Length) / 100
  ```
- Displays result formatted as a **currency value**

---

## 📖 Example Run
```
Welcome to Package Express. Please follow the instructions below.
Please enter the package weight:
40
Please enter the package width:
10
Please enter the package height:
12
Please enter the package length:
11
Your estimated total for shipping this package is: $528.00
Thank you!
```

---

## 🛠️ How to Run
1. Clone this repo:
   ```bash
   git clone [https://github.com/your-username/ShippingQuoteApp.git](https://sagargit94.github.io/Shipping-Quote-App/)
   cd ShippingQuoteApp
   ```
2. Run the program:
   ```bash
   dotnet run
   ```

---

## 📌 Requirements
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)

---

