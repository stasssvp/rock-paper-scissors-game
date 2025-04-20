# ✨ Rock Paper Scissors Game (WPF, C#)

A clean and well-structured Rock-Paper-Scissors game built using **C#** and **WPF**. This project not only showcases the core game mechanics, but also demonstrates clean architecture, scalable design, and readable code.

---

## 🎮 About the Game

- Play **Rock**, **Paper**, or **Scissors** against the computer.  
- First to **3 points** wins.  
- Visual highlights indicate the winner of each round.  
- Simple, intuitive, and smooth interface.

---

## 🛠 Technologies Used

- **C#**
- **WPF (Windows Presentation Foundation)**

---

## 🧠 Key Principles Applied

### 💂 Separation of Concerns
- Game logic is **clearly separated** from UI (XAML) for easier maintenance.  
- Main interaction logic is handled in `MainWindow.xaml.cs`, keeping XAML clean.

### 🎯 Event-Driven Design
- Click events (`MouseLeftButtonDown`) are attached directly to image elements for fast and natural interaction.

### ✍️ Clean and Consistent Naming
- Elements like Images, Borders, and TextBoxes are **consistently named** (e.g., `rock`, `paper`, `scissors`) for clarity.  
- Border and image names are easily matchable, making the code extensible.

### 🌈 Visual Feedback
- Border colors indicate round results:
  - 🟩 **Green** – Winner  
  - 🔴 **Red** – Loser  
  - 🟠 **Orange** – Tie  

### 🧹 Minimal and Efficient XAML
- Clean layout using **Grids** and **Borders**.  
- Carefully set margins and alignment for a professional UI without unnecessary complexity.

### 💬 Comments and Readability
- Important parts of the code are **commented in English** to explain the *why* and *how* behind the logic.

### 🚀 Scalability
- Easily extendable structure allows for future improvements:
  - Adding animations  
  - Introducing difficulty levels  
  - Expanding game rules (e.g., Rock-Paper-Scissors-Lizard-Spock)

---

## 🚀 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/stasssvp/rock-paper-scissors-game.git
2.	Open the solution in Visual Studio (2019 or later recommended).
3.	Build and run the project.

---

## 👽 Credits
- Game Logic: Created by Stanimir Petkov.
- Artworks: Emoji images are sourced from the Apple emoji set.
- Font: Uses Cascadia Code, licensed under the Microsoft Cascadia Code License.
- Frameworks: Built with .NET and WPF. No third-party libraries required.

Contributions are welcome! Feel free to open issues or pull requests.

---

## 🔥 Final Words

This project is a great example of how even a simple game can benefit from clean code, good practices, and attention to detail.

**Enjoy playing and improving!**
