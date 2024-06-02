using Page_Navigation_App.Model;
using System.Collections.ObjectModel;

internal static class ArchiveHelpers
{
    public static ObservableCollection<waterModel> GetArchives()
    {
        ObservableCollection<waterModel> employees = new ObservableCollection<waterModel>();
        waterModel employee = new waterModel();
        employee.FirstName = "Margaret";
        employee.LastName = "Peacock";
        employee.Position = "Sales Representative";
        employee.Age = 24;
        employees.Add(employee);
        employee = new waterModel();
        employee.FirstName = "Steven";
        employee.LastName = "Buchanan";
        employee.Position = "Sales Manager";
        employee.Age = 44;
        employees.Add(employee);
        employee = new waterModel();
        employee.FirstName = "Michael";
        employee.LastName = "Suyama";
        employee.Position = "Sales Representative";
        employee.Age = 33;
        employees.Add(employee);
        employee = new waterModel();
        employee.FirstName = "Robert";
        employee.LastName = "King";
        employee.Position = "Sales Representative";
        employee.Age = 28;
        employees.Add(employee);
        employee = new waterModel();
        employee.FirstName = "Laura";
        employee.LastName = "Callahan";
        employee.Position = "Inside Sales Coordinator";
        employee.Age = 26;
        employees.Add(employee);
        employee = new waterModel();
        employee.FirstName = "Anne";
        employee.LastName = "Dodsworth";
        employee.Position = "Sales Representative";
        employee.Age = 30;
        employees.Add(employee);

        return employees;
    }
}