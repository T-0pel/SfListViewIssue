using System.Collections.ObjectModel;

namespace TabView
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
    public class ContactInfo
    {
        public string Name { get; set; }
        public long Number { get; set; }
    }

    public class ContactsViewModel
    {
        public ObservableCollection<ContactInfo> ContactList { get; set; }

        public ContactsViewModel()
        {
            ContactList = new ObservableCollection<ContactInfo>();
            ContactList.Add(new ContactInfo { Name = "Aarov", Number = 7666798690860 });
            ContactList.Add(new ContactInfo { Name = "Adam", Number = 7323250 });
            ContactList.Add(new ContactInfo { Name = "Adrian", Number = 7239121 });
            ContactList.Add(new ContactInfo { Name = "Alwin", Number = 2329823 });
            ContactList.Add(new ContactInfo { Name = "Alex", Number = 8013481 });
            ContactList.Add(new ContactInfo { Name = "Alexander", Number = 7872329 });
            ContactList.Add(new ContactInfo { Name = "Barry", Number = 7317750 });
            ContactList.Add(new ContactInfo { Name = "Blexo", Number = 7363750 });
            ContactList.Add(new ContactInfo { Name = "Cassey", Number = 7323250 });
            ContactList.Add(new ContactInfo { Name = "Danny", Number = 7239121 });
            ContactList.Add(new ContactInfo { Name = "Edwin", Number = 2329823 });
            ContactList.Add(new ContactInfo { Name = "Jacob", Number = 8013481 });
            ContactList.Add(new ContactInfo { Name = "Jessie", Number = 7872329 });
            ContactList.Add(new ContactInfo { Name = "Linda", Number = 7317750 });
            ContactList.Add(new ContactInfo { Name = "Jacobq", Number = 80134871 });
            ContactList.Add(new ContactInfo { Name = "Kannan", Number = 78723289 });
            ContactList.Add(new ContactInfo { Name = "Lissa", Number = 73177530 });
            ContactList.Add(new ContactInfo { Name = "Mary", Number = 801348713 });
            ContactList.Add(new ContactInfo { Name = "Jose", Number = 7857232895 });
            ContactList.Add(new ContactInfo { Name = "Lusy", Number = 731775307 });
            ContactList.Add(new ContactInfo { Name = "Josena", Number = 7857232895 });
        }
    }
}
