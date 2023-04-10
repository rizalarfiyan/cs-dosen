namespace CSDosen
{
    class Dosen
    {
        private int ID;
        private string Nama;
        private int Nik;
        private string Gender;
        private string Course;

        public Dosen()
        {
            this.ID = 1;
            this.Nama = "Dosen Pengampu";
            this.Nik = 123456789;
            this.Gender = "Male";
            this.Course = "Pemrograma Berorientasi Objek";
        }

        public void attDosen(string name, int nik)
        {
            this.Nama = name;
            this.Nik = nik;
        }

        public void addCourse(string name)
        {
            this.Course += $", {name}";
        }

        public void display()
        {
            Console.WriteLine($"ID \t\t= {this.ID}");
            Console.WriteLine($"Nama \t\t= {this.Nama}");
            Console.WriteLine($"NIK \t\t= {this.Nik}");
            Console.WriteLine($"Gender \t\t= {this.Gender}");
            Console.WriteLine($"Course \t\t= {this.Course}");
        }
    }
}
