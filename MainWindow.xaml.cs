using System;
using System.Windows;
using System.Windows.Media;

namespace RockPaperScissorsGame
{
    public enum Choice
    {
        Rock = 1,
        Paper,
        Scissors
    }

    // Game logic class
    public class Game
    {
        public int PlayerPoints { get; set; }
        public int ComputerPoints { get; set; }

        // Evaluates the winner of the round
        public string GetResult(Choice playerChoice, Choice computerChoice)
        {
            if (playerChoice == computerChoice)
                return "It's a tie!";
            if ((playerChoice == Choice.Rock && computerChoice == Choice.Scissors) ||
                (playerChoice == Choice.Paper && computerChoice == Choice.Rock) ||
                (playerChoice == Choice.Scissors && computerChoice == Choice.Paper))
            {
                PlayerPoints++;
                return "Player wins this round!";
            }
            else
            {
                ComputerPoints++;
                return "Computer wins this round!";
            }
        }
    }

    public partial class MainWindow : Window
    {
        private Game game;

        public MainWindow()
        {
            InitializeComponent();
            game = new Game();  // Initialize the game logic

            grid.Background = Brushes.LavenderBlush;
            player_points.Background = Brushes.LavenderBlush;
            computer_points.Background = Brushes.LavenderBlush;
        }

        // Reset all the borders' background to transparent
        private void Restart_Border()
        {
            rock_border.Background = Brushes.Transparent;
            paper_border.Background = Brushes.Transparent;
            scissors_border.Background = Brushes.Transparent;

            rock_border_copy.Background = Brushes.Transparent;
            paper_border_copy.Background = Brushes.Transparent;
            scissors_border_copy.Background = Brushes.Transparent;
        }

        // Update the points and check if the game is over
        private void Count_Points()
        {
            player_points.Text = game.PlayerPoints.ToString();
            computer_points.Text = game.ComputerPoints.ToString();

            if (game.PlayerPoints == 3)
            {
                string result = $"Game over! Player won with {game.PlayerPoints} points.";
                MessageBox.Show(result);
                Close(); // Close the window after the game ends
            }
            else if (game.ComputerPoints == 3)
            {
                string result = $"Game over! Computer won with {game.ComputerPoints} points.";
                MessageBox.Show(result);
                Close(); // Close the window after the game ends
            }
        }

        // Handle Rock click event
        private void Rock_Click(object sender, RoutedEventArgs e)
        {
            Restart_Border();

            Choice playerChoice = Choice.Rock; // Player chooses Rock
            Random rand = new Random();
            Choice computerChoice = (Choice)rand.Next(1, 4); // Computer randomly chooses Rock, Paper, or Scissors

            string roundResult = game.GetResult(playerChoice, computerChoice); // Get the result of the round

            // Set the UI colors based on choices
            SetChoiceColor(playerChoice, computerChoice);

            //MessageBox.Show(roundResult); // Display the result of the round
            player_points.Text = game.PlayerPoints.ToString();
            computer_points.Text = game.ComputerPoints.ToString();

            Count_Points(); // Update the points
        }

        // Handle Paper click event
        private void Paper_Click(object sender, RoutedEventArgs e)
        {
            Restart_Border();

            Choice playerChoice = Choice.Paper; // Player chooses Paper
            Random rand = new Random();
            Choice computerChoice = (Choice)rand.Next(1, 4); // Computer randomly chooses Rock, Paper, or Scissors

            string roundResult = game.GetResult(playerChoice, computerChoice); // Get the result of the round

            // Set the UI colors based on choices
            SetChoiceColor(playerChoice, computerChoice);

            //MessageBox.Show(roundResult); // Display the result of the round
            player_points.Text = game.PlayerPoints.ToString();
            computer_points.Text = game.ComputerPoints.ToString();

            Count_Points(); // Update the points
        }

        // Handle Scissors click event
        private void Scissors_Click(object sender, RoutedEventArgs e)
        {
            Restart_Border();

            Choice playerChoice = Choice.Scissors; // Player chooses Scissors
            Random rand = new Random();
            Choice computerChoice = (Choice)rand.Next(1, 4); // Computer randomly chooses Rock, Paper, or Scissors

            string roundResult = game.GetResult(playerChoice, computerChoice); // Get the result of the round

            // Set the UI colors based on choices
            SetChoiceColor(playerChoice, computerChoice);

            //MessageBox.Show(roundResult); // Display the result of the round
            player_points.Text = game.PlayerPoints.ToString();
            computer_points.Text = game.ComputerPoints.ToString();

            Count_Points(); // Update the points
        }

        // Method to set the UI colors based on player and computer choices
        private void SetChoiceColor(Choice playerChoice, Choice computerChoice)
        {
            var colorConverter = new BrushConverter();

            // Player's selection colors
            switch (playerChoice)
            {
                case Choice.Rock:
                    rock_border.Background = (Brush)colorConverter.ConvertFrom("#ffbe0b"); // Orange
                    break;
                case Choice.Paper:
                    paper_border.Background = (Brush)colorConverter.ConvertFrom("#6a994e"); // Green
                    break;
                case Choice.Scissors:
                    scissors_border.Background = (Brush)colorConverter.ConvertFrom("#fb5607"); // Red
                    break;
            }

            // Computer's selection colors
            switch (computerChoice)
            {
                case Choice.Rock:
                    rock_border_copy.Background = (Brush)colorConverter.ConvertFrom("#ffbe0b"); // Orange
                    break;
                case Choice.Paper:
                    paper_border_copy.Background = (Brush)colorConverter.ConvertFrom("#6a994e"); // Green
                    break;
                case Choice.Scissors:
                    scissors_border_copy.Background = (Brush)colorConverter.ConvertFrom("#fb5607"); // Red
                    break;
            }
        }
    }
}