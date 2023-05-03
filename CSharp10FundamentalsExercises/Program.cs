double ratePerHour = 125.50;
int numOfHoursWorked = 95;
int bonus = 1000;
double currentMonthStipend = ratePerHour * numOfHoursWorked + bonus;

ratePerHour -= 25;
Console.WriteLine(currentMonthStipend);

double currentMonthStipendInPercentage = currentMonthStipend / 100;
Console.WriteLine(currentMonthStipendInPercentage);