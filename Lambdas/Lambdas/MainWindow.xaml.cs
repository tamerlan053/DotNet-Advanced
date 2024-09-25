using System;
using System.Windows;

namespace Lambdas;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        Func<int, int, string> printNumbersMethod; // Declare a variable that can hold a method that expects two integers and returns a string
        printNumbersMethod = (x, y) => $"({x},{y})"; // Assign a method to the variable using a lambda expression
        string result = printNumbersMethod(10, 20); // Call the method
        MessageBox.Show(result);

        Action<int> notifyMethod; // Declare a variable that can hold a method that expects an integer and returns void
        notifyMethod = (x) => MessageBox.Show($"The number is {x}"); // Assign a method to the variable using a lambda expression
        notifyMethod(10); // Call the method

        SubmitButton.Click += SubmitButton_Click; //Assign a named method to the event handler
        SubmitButton.Click += (sender, args) => MessageBox.Show("Click handled by lambda"); // Assign a method to the event handler using a lambda expression

        Func<int, int, int> absoluteMaxMethod; // Declare a variable that can hold a method that expects two integers and returns an integer
        // Assign a method to the variable using a lambda expression with multiple statements in the body
        absoluteMaxMethod = (x, y) =>
        {
            x = Math.Abs(x);
            y = Math.Abs(y);
            return Math.Max(x, y);
        };
        int absoluteMax = absoluteMaxMethod(-5, 1); // Call the method
        MessageBox.Show($"Absolute maximum of -5 an 1 = {absoluteMax}");

        Action workCompletedMethod; // Declare a variable that can hold a method that expects no parameters and returns void
        workCompletedMethod = () => MessageBox.Show("Work completed"); // Assign a method to the variable using a lambda expression
        workCompletedMethod(); // Call the method
    }

    private void SubmitButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Click handled by classic method");
    }
}