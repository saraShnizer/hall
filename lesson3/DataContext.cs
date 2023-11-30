using lesson3.Entities;

namespace lesson3
{
    public class DataContext
    {
        public List<Dose> Doses { get; set; }

        public List<Employee> Employees { get; set; }
        public List<Order> Orders { get; set; }
        public DataContext()
        {
            Doses = new List<Dose>(){
            new Dose {Id=1,Name="shnizels",Price=30},
            new Dose   {Id=2,Name="steiks",Price=40},
            new Dose  {Id=3,Name="salamon",Price=70},
            };
            Employees = new List<Employee>(){
            new Employee{ Id=1,Name="Moshe",PhoneNumber="0501247497"},
            new Employee{ Id=2,Name="Avrham",PhoneNumber="0534111537"},
            new Employee{ Id =3, Name = "Refael", PhoneNumber = "0527640789" }
            };
            Orders = new List<Order>{
             new Order{ Id = 2, NameClient = "ruty toledano", Date = new DateTime(2020, 02, 02), DosesCount = 10000 },
             new Order{ Id = 3, NameClient = " sari snizer", Date = new DateTime(2000, 03, 02), DosesCount = 10000 },
             new Order{ Id = 4, NameClient = " rivky toledano", Date = new DateTime(2010, 03, 01), DosesCount = 10000 },
             new Order{ Id = 5, NameClient = " yael frank", Date = new DateTime(2000, 03, 02), DosesCount = 10000 }
            };
;
        }


    }
}
