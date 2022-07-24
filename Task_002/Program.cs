using Task_002;

List<Month> list = new List<Month>();

list.Add(new Month(1, "January", 31));
list.Add(new Month(2, "February", 28));
list.Add(new Month(3, "March", 31));
list.Add(new Month(4, "April", 30));
list.Add(new Month(5, "May", 31));
list.Add(new Month(6, "June", 30));
list.Add(new Month(7, "July", 31));
list.Add(new Month(8, "August", 31));
list.Add(new Month(9, "September", 30));
list.Add(new Month(10, "October", 31));
list.Add(new Month(11, "November", 30));
list.Add(new Month(12, "December", 31));

// Searching by month name;
var selectMonthByName
    = list.FindAll(x => x.GetByMonthName.Contains("September"));

foreach (var item in selectMonthByName)
    item.Show();

Console.WriteLine(new String('-', 15));

// Searching by number in the list;
var selectMonthByNumber
    = list.FindAll(x => x.GetByMonthNumber.Equals(5));

foreach (var item in selectMonthByNumber)
    item.Show();

Console.WriteLine(new String('-', 15));

// Searching by days quantity;
var selectMonthByDays = from d in list
                          where d.GetByMonthDays == 31
                          select d;

foreach (var item in selectMonthByDays)
    item.Show();
