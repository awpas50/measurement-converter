using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMeasurementConverter
{
    // simple measurement converter.

    class Program {
        const double METERS_TO_INCHES = 39.370079;
        const double METERS_TO_FEET = 3.280839895;
        const double METERS_TO_YARDS = 1.093613298;
        const double YARDS_TO_CM = 91.44;
        const double YARDS_TO_METERS = 0.9144;

        static void WelcomeMessage() {
            Console.WriteLine("Welcome to the Simple Measurement Converter!");
            Console.WriteLine("Press any key to start");
            Console.ReadKey();
        } // end WelcomeMessage

        static void ErrorMessage() {
            Console.WriteLine("\n**Invaild input**");
        } // end ErrorMessage

        static void InputErrorMessage() {
            Console.WriteLine("Number must be a positive number!\n");
        } // end InputErrorMessage

        static void ExitProgram() {
            Console.WriteLine("\nThanks for using the Measurement Converter.");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        } // end ExitProgram

        static int MainMenu() {
            string yourFirstChoice;
            int first_measurementConversion;
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("************************************************");
            Console.WriteLine("Please choose from one of the following options:");
            Console.WriteLine("1. metric to imperial conversion");
            Console.WriteLine("2. imperial to metric conversion");
            Console.WriteLine("0. quit this program\n");
            Console.Write("Enter your choice: ");
            yourFirstChoice = Console.ReadLine();
            int.TryParse(yourFirstChoice, out first_measurementConversion);
            return first_measurementConversion;
        } // end MainMenu

        static int MainMenu_Choice1_metric() {
            string yourSecondChoice;
            int Conversion_metric;
            Console.WriteLine("\nMetric to imperial conversion");
            Console.WriteLine("************************************************");
            Console.WriteLine("Convery meters to:");
            Console.WriteLine("1. inches");
            Console.WriteLine("2. feet");
            Console.WriteLine("3. yards");
            Console.WriteLine("0. return to main menu\n");
            Console.Write("Enter your choice: ");
            yourSecondChoice = Console.ReadLine();
            int.TryParse(yourSecondChoice, out Conversion_metric);
            return Conversion_metric;
        } // end MainMenu_Choice1_metric

        static double InputData_metric(int Conversion_metric) {
            string numberInput; 
            double numberOutput;
            if (Conversion_metric == 1) {
                Console.Write("\nEnter value of meters: "); // 1. inchs
                numberInput = Console.ReadLine();
                double.TryParse(numberInput, out numberOutput);
                return numberOutput;
            } else if (Conversion_metric == 2) {
                Console.Write("\nEnter value of meters: "); // 2. feet
                numberInput = Console.ReadLine();
                double.TryParse(numberInput, out numberOutput);
                return numberOutput;
            } else if (Conversion_metric == 3) {
                Console.Write("\nEnter value of meters: "); // 3. yards
                numberInput = Console.ReadLine();
                double.TryParse(numberInput, out numberOutput);
                return numberOutput;
            } else if ((Conversion_metric <= -1) || (Conversion_metric >= 4)) { // return to main menu
                ErrorMessage();
                Conversion_metric = 0;
                return 0;
            } else {
                return 0;
            }
        } // end InputData_metric

        static int MainMenu_Choice2_imperial() {
            string yourSecondChoice;
            int Conversion_imperial;
            Console.WriteLine("\nImperial to metric conversion");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Convery meters to:");
            Console.WriteLine("1. cm");
            Console.WriteLine("2. meter");
            Console.WriteLine("0. return to main menu\n");
            Console.Write("Enter your choice: ");
            yourSecondChoice = Console.ReadLine();
            int.TryParse(yourSecondChoice, out Conversion_imperial);
            return Conversion_imperial;
        } // end MainMenu_Choice2_imperial

        static double InputData_imperial(int Conversion_imperial) {
            string numberInput;
            double numberOutput;
            if (Conversion_imperial == 1) {
                Console.Write("\nEnter value of yards: "); // 1. cm
                numberInput = Console.ReadLine();
                double.TryParse(numberInput, out numberOutput);
                return numberOutput;
            } else if (Conversion_imperial == 2) {
                Console.Write("\nEnter value of yards: "); // 2. meter
                numberInput = Console.ReadLine();
                double.TryParse(numberInput, out numberOutput);
                return numberOutput;
            } else if ((Conversion_imperial <= -1) || (Conversion_imperial >= 3)) { // return to main menu
                ErrorMessage();
                Conversion_imperial = 0;
                return 0;
            } else {
                return 0;
            }
        } // end InputData_imperial

        static double Calculation_metric(int Conversion_metric, double numberOutput) {
            double meters, yards, inches, feet;
            if (Conversion_metric == 1) { // meters --> inches
                meters = numberOutput;
                inches = meters * METERS_TO_INCHES;
                return inches;
            } else if (Conversion_metric == 2) { // meters --> feet
                meters = numberOutput;
                feet = meters * METERS_TO_FEET;
                return feet;
            } else if (Conversion_metric == 3) { // meters --> yards
                meters = numberOutput;
                yards = meters * METERS_TO_YARDS;
                return yards;
            } else {
                return 0.0;
            }
        } // end Calculation_metric
        static double Calculation_imperial(int Conversion_imperial, double numberOutput) {
            double meters, yards, centimeters;
            if (Conversion_imperial == 1) { // yards --> centimeters
                yards = numberOutput;
                centimeters = yards * YARDS_TO_CM;
                return centimeters;
            } else if (Conversion_imperial == 2) { // yards --> meters
                yards = numberOutput;
                meters = yards * YARDS_TO_METERS;
                return meters;
            } else {
                return 0.0;
            }
        } // end Calculation_metric

        static void DisplayResult(int Conversion_metric, int Conversion_imperial, double numberOutput, double result) {
            if (Conversion_metric == 1) {
                Console.WriteLine("RESULT: {0} meters equals {1:f2} inches. \n", numberOutput, result);
            } else if (Conversion_metric == 2) {
                Console.WriteLine("RESULT: {0} meters equals {1:f2} feet. \n", numberOutput, result);
            } else if (Conversion_metric == 3) {
                Console.WriteLine("RESULT: {0} meters equals {1:f2} yards. \n", numberOutput, result);
            } else if (Conversion_imperial == 1) {
                Console.WriteLine("RESULT: {0} yards equals {1:f2} centimeters. \n", numberOutput, result);
            } else if (Conversion_imperial == 2) {
                Console.WriteLine("RESULT: {0} yards equals {1:f2} meters. \n", numberOutput, result);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        } // end DisplayResult

        static void Main(string[] args) {
            int measurementConversion, Conversion_metric, Conversion_imperial;
            double numberOutput, result;
            WelcomeMessage();
            do {
                Console.Clear();
                measurementConversion = MainMenu();
                if ((measurementConversion < 0) || (measurementConversion > 2)) { // choices outside 0,1,2
                    ErrorMessage();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                } else if (measurementConversion == 1) { // 1. metric to imperial conversion
                    Conversion_metric = MainMenu_Choice1_metric();
                    if ((Conversion_metric >= 0) || (Conversion_metric <= 3)) { // choice must be 0,1,2,3 to proceed
                        numberOutput = InputData_metric(Conversion_metric);
                        result = Calculation_metric(Conversion_metric, numberOutput);
                        if (numberOutput >= 0) { // positive number
                            Conversion_imperial = 0;
                            DisplayResult(Conversion_metric, Conversion_imperial, numberOutput, result);
                        } else { // negative number or non-number
                            InputErrorMessage();
                        }
                    }
                } else if (measurementConversion == 2) { // 2. imperial to metric conversion
                    Conversion_imperial = MainMenu_Choice2_imperial();
                    if ((Conversion_imperial >= 0) || (Conversion_imperial <= 2)) { // choice must be 0,1,2 to proceed
                        numberOutput = InputData_imperial(Conversion_imperial);
                        result = Calculation_imperial(Conversion_imperial, numberOutput);
                        if (numberOutput >= 0) { // positive number
                            Conversion_metric = 0;
                            DisplayResult(Conversion_metric, Conversion_imperial, numberOutput, result);
                        } else { // negative number or non-number
                            InputErrorMessage();
                        }
                    }
                }
            } while (measurementConversion != 0); // exit program when enter 0
            ExitProgram();
        }
    }
}
