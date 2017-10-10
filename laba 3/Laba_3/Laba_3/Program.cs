using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3
{
	/*ВАРИАНТ 16 лаба 3 ООП*/
	partial class Student                                    
	{
		//поля
		public static int count;
		const string university="BSTU";
		readonly int ID;
		private string full_name;
		private int date_of_birthday;
		private string adress;
		private int phone;
		private string faculity;
		private int course;
		private int group;
		private int age;

		//свойства (аксессоры)       
		public int Age
		{
			get
			{
				return age;
			}            
		}
		public string Full_name
		{
			get { return full_name; }
			set
			{
				if (value != string.Empty)
					full_name = value;
				else
				{
					Console.WriteLine("You didn't enter data");
				}
			}
		}
		public int Date_of_birthday
		{
			get { return date_of_birthday; }
			set
			{
				if (value < 1900 && value>2000)
				{
					Console.WriteLine("You didn't enter data");
				}                    
				else
				{
					date_of_birthday = value;
				}                
			}

		}
		public string Adress
		{
			get { return adress; }
			private set
			{
				if(value != string.Empty)
				{
					adress = value;
				}                   
				else
				{
					Console.WriteLine("You didn't enter data");
				}
			}

		}
		public int Phone
		{
			get { return phone; }
			set
			{
				if (value<1000000 || value > 9999999)
				{
					Console.WriteLine("Incorrect value");
				}
				else
				{
					phone = value;
				}
			}
		}
		public string Faculity
		{
			get { return faculity; }
			set
			{
				if (value != string.Empty) 
					faculity = value;
			}

		}
		public int Course
		{
			get { return course; }
			set
			{
				if (value < 1 ||value>4)
				{
					Console.WriteLine("Incorrect value");
				}
				else
				{
					course = value;
				}               
			}
		}
		public int Group
		{
			get { return group; }
			set
			{
				if (value < 1 || value > 5)
				{
					Console.WriteLine("Incorrect value");
				}
				else
				{
					group = value;

				}
			}
		}

		//предназначен для определённого действия
		//работает только при создании объекта
		static Student()
		{
			Console.WriteLine("статический конструктор\n");
		} 

		//конструктор бкз параметров
		public Student ()
		{
			full_name = "Unknown";
			adress = "Unkown";           
			faculity = "Unkown";

			count ++;
			Print();
			Console.WriteLine();
		}

		//конструктор с параметрами
		public Student( string full_name, int date_of_birthday, string adress, int phone, int course, string faculity, int group)
		{
			this.full_name = full_name;   
			this.date_of_birthday = date_of_birthday;
			this.adress = adress;
			this.phone = phone;            
			this.course = course;
			this.faculity = faculity;
			this.group = group;

			count++;
			Print();
			Age_student(course);
		}
	}

	//частичный класс
	partial class Student
	{
		//методы
		public void Age_student(int course)
		{
			if (course == 1)
			{
				age = 18;
			}
			if (course == 2)
			{
				age = 19;
			}
			if (course == 3)
			{
				age = 20;
			}
			if (course == 4)
			{
				age = 21;
			}
			Console.WriteLine("Age: " + age + "\n");
		}

		public void Print()
		{            
			Console.WriteLine("Full name: " + full_name);
			Console.WriteLine("Date of birthday: " + date_of_birthday);
			Console.WriteLine("Adress: " + adress);
			Console.WriteLine("Phone: " + phone);
			Console.WriteLine("Course: " + course);
			Console.WriteLine("Faculity: " + faculity);            
		}      
	}

	class Animal
	{
		private int age { get; set; }
		private int lines { get; set; }
		private float happiness { get; set; }

		public Animal()
		{
			age = 1;
			lines = 10;
		}
		public float Cat(ref int age, ref int lines, out float happiness)
		{
			happiness = (2 * age) / lines;
			return happiness;
		}
	}
	class MainClass
	{
		static void Main(string[] args)
		{
			//анонимный тип 
			var stud = new Student { Full_name = "Shkindar Andrey Andreevich" };

			//массив объектов 
			Student [] students = new Student [50];
			students[0] = new Student("Akshevskaya Ekaterina Igorevna", 1998, "Minsk", 1254786, 1, "FIT", 5);
			students[1] = new Student("Sinkevich Hanna Andreevna", 1997, "Gomel", 1515645, 3, "FIT", 1);
			students[2] = new Student("Lebedev Oleg Leonidovich", 1998, "Mogilev", 1233457, 2, "FIT", 4);
			students[3] = new Student("Yaskuty Pavel Olegovich", 1999, "Minsk", 3696457, 4, "FIT", 3);
			students[4] = new Student("Babako Anna Pavlovna", 1996, "Polotsk", 3612757, 2, "FIT", 5);
			for (int i = 5; i < students.Length; i++)
			{
				students[i] = new Student();
			}

			//сравнение объектов
			Console.WriteLine("Equals firts dtudent with second student: " + students[0].Equals(students[1]));
			//получение хеш-кода
			Console.WriteLine("Hash code of first student: " + students[0].GetHashCode());
			//получение информации об объекте
			Console.WriteLine("Information of object: " + students[0].ToString());
			Console.WriteLine("Information of object: " + students[1].GetType());

			//вывод по группе
			Console.WriteLine("\nInput number of group: ");
			try
			{
				int number_group = Convert.ToInt32(Console.ReadLine());
				for (int i = 0; i < students.Length; i++)
				{
					if(students[i].Group == number_group)
					{
						Console.WriteLine(students[i].Full_name);
					}
				}
			}
			catch (FormatException)
			{
				Console.WriteLine("Format Exception");
			}

			//вывод по факультету
			Console.WriteLine("\n Faculity IT: ");
			for (int i = 0; i < students.Length; i++)
			{
				if (students[i].Faculity.StartsWith("F"))
				{
					Console.WriteLine(students[i].Full_name);
				}
			}

			Console.WriteLine("\ncount of objects: "+ Student.count);
			Animal kitten = new Animal();                       
		}
	}
}

			
		
