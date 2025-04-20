✨ Rock Paper Scissors Game (WPF, C#)

This is a clean and carefully structured Rock-Paper-Scissors game developed using C# and WPF technologies.

It demonstrates not only game mechanics but also solid principles for organizing and writing readable and scalable code.

⸻

🎮 About the Game
	•	Play Rock, Paper, or Scissors against the computer.
	•	First to 3 points wins.
	•	Visual highlights indicate who wins each round.
	•	Simple, intuitive, and smooth interface.

⸻

🛠 Technologies Used
	•	C# 8.0
	•	WPF (Windows Presentation Foundation)

⸻

🧠 Key Principles Applied

💂 Separation of Concerns
	•	Game logic is clearly separated from UI design (XAML) to keep maintenance easy.
	•	All main interaction happens in MainWindow.xaml.cs without cluttering the XAML with logic.

🎯 Event-Driven Design
	•	Mouse click events (MouseLeftButtonDown) are attached directly to Image elements for fast and intuitive interaction.

✍️ Clean and Consistent Naming
	•	All elements (Images, Borders, TextBoxes) are consistently named (rock, paper, scissors, etc.) for clear readability.
	•	Border names and Image names are easily matchable, making the logic extensible.

🌈 Visual Feedback
	•	Borders change colors based on the result of each round:
	•	🟩 Green for Winner
	•	🔵 Red for Loser
	•	🟠 Orange for Tie

🧹 Minimal and Efficient XAML
	•	Layout is optimized with Grids and Borders.
	•	Margins and alignments are carefully set to create a clean, professional interface without unnecessary complexity.

💬 Comments and Readability
	•	All important parts of the code are commented in English to explain why and how things work.

🚀 Scalability
	•	The structure allows easy future improvements:
	•	Adding animations
	•	Introducing difficulty levels
	•	Extending the game rules (e.g., Rock-Paper-Scissors-Lizard-Spock)

⸻

🚀 How to Run
	1.	Clone the repository:
	git clone https://github.com/stasssvp/rock-paper-scissors-game.git
	2.	Open the solution in Visual Studio (version 2019+ recommended).
	3.	Build and run the project.

⸻

📄 License

This project is open-source and available under the MIT License.
Feel free to use, modify, and improve it!

⸻

👽 Credits

- **Game Logic**: The basic game logic was created by Stanimir Petkov.
- **Artworks**: Images used in the game are from the Apple emoji set.
- **Font**: Font used is **Cascadia Code**, available under the [Microsoft Cascadia Code License](https://github.com/microsoft/cascadia-code).
- **Libraries**: This project uses the .NET Framework and WPF for the GUI, and no additional third-party libraries were required.

Feel free to contribute or make suggestions via issues or pull requests on GitHub.

⸻

🔥 Final Words

This project is a great example of how even a simple game can benefit from good practices, clear structure, and attention to detail.

Enjoy playing and improving! 🎮🎉
