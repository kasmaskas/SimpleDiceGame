# 🎲 Dice Game (Console Application)

A simple and interactive **C# Console Application** where players roll three dice and aim for a high score based on specific bonus rules. This project demonstrates core programming logic and data structure management in .NET.

### 🚀 Latest Update
- **[DEC 27, 2025]** - **UX & UI Improvements:** Added more descriptive feedback messages and improved console readability using strategic line breaks.
- **[DEC 27, 2025]** - **Language Localization:** The entire game interface has been unified to English for a more professional feel.
- **[DEC 27, 2025]** - **Code Cleanup:** Refactored the logic flow and formatting to follow cleaner coding standards.

## 🚀 How It Works

The game prompts the player to roll three separate dice. The final result is calculated by adding the face values of the dice plus any earned bonuses.

### Scoring Rules:
* **Base Score:** The sum of the three dice values (e.g., 4 + 1 + 6 = 11).
* **Triple Bonus:** If all three dice show the same value, you earn a **+6 point** bonus.
* **Double Bonus:** If any two dice show the same value, you earn a **+2 point** bonus.
* **Win Condition:** You win the round if your total score (Base + Bonuses) is **15 or higher**.

## 🛠 Technical Stack

This project implements the following C# concepts:

* **Collections:** Used `int[]` to store and evaluate dice results.
* **Control Flow:** Implementation of `for` loop for turn-based input and `if/else if` statements for scoring logic.
* **Randomization:** Used the `Random` class to generate unpredictable dice outcomes.
* **Logic Operators:** Utilized AND (`&&`) and OR (`||`) operators for efficient bonus checking.

## 📋 Installation & Setup

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/your-username/dice-game.git](https://github.com/your-username/dice-game.git)
    ```
2.  **Navigate to the project directory:**
    ```bash
    cd dice-game
    ```
3.  **Run the application:**
    ```bash
    dotnet run
    ```

## 🔮 Future Roadmap (Planned UI Update)

I plan to evolve this project from a console-based app to a full Desktop Application:
- [ ] Implement a **Graphical User Interface (GUI)** using Windows Forms or WPF.
- [ ] Add animations for rolling dice.
- [ ] Include a "Play Again" loop and session-based high score tracking.
- [ ] Add sound effects for wins and bonuses.

---
*Developed as a C# learning project.*

Note: While the core logic and code of this project were developed by me, this documentation was assisted by AI to ensure clarity and professional standards.