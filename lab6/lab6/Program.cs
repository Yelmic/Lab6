
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Programms
    {
        
        public Programms()
        {

        }
          public void Inf()
          {
            Console.WriteLine($"Наимнование программы {name_of_prog},год программы {year}");
          }
        public double begin;
        public double end;
        public int array;
        private int year;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value > 0)
                {
                    year = value;
                }
                else
                {
                    Console.WriteLine("Бред");
                }
            }
        }
        public string name_of_prog;
        internal List<Programms> Spis = new List<Programms>();
        void Add(Programms elem)
        {
            Spis.Add(elem);
            Console.WriteLine($"Мы добавили {elem}");
        }
        void Remove(Programms elem)
        {
            Spis.Remove(elem);
            Console.WriteLine($"Мы удалили {elem}");
        }
        void Output(List<Programms> elem)
        {
            foreach (object list_of_prog in elem)
            {
                Console.WriteLine(list_of_prog);
            }
        }

    }
    class Controller
    {
       public enum obj
        {
            Monday = 1,
            Tuesday,
            Whensday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        List<object> list = new List<object>();

        public static void Count()//число рекл роликов
        {
            Console.WriteLine($"Число рекламных роликов равно {Advertisment.count}");
        }
        public static void Search(List<Programms> spis)//фильмы снятые в определенный год
        {
            for (int i = 0; i < spis.Count; i++)
            {
                if (spis[i].Year == 1999)
                {
                    Console.WriteLine(spis[i].name_of_prog);
                }
               
            }
        }
        public static void Time(double begin, double end)
        {
            double time = end - begin;
            if(time<1)
            {
                Console.WriteLine((int)(time*100)+" мин");
            }
            else if(time==1)
            {
                Console.WriteLine(time+"час(ов)");
            }
            else if(time>1)
            {
                Console.WriteLine(time);
            }
           
        }
    }
    class Printer
    {
        public string IAmPrinting(Object obj)
        {
            return obj.ToString();
        }
    }

    struct User
    {
        public string Name;
        public int Age;
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Info()
        {
            Console.WriteLine($"Имя юзера {Name}, его возраст {Age}");
        }
    }
    interface IPerson//в интерфейсе и абстр классе одноименные методы
    {
        void Move();
    }
    abstract class Movement
    {
        public abstract void Move();
    }
    class Person : Movement, IPerson
    {
        public string name;
        public int age = 18;
        public override void Move()
        {
            Console.WriteLine("Человек идет");
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(name))
            {
                return "Имя не определено";
            }
            return "Продюссера зовут " + name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }


    interface ITVprogram
    {
        void Watch();
        void Show();
    }
    abstract class TVprogram
    {
        public int agelimit;
        public double time;
    }

    class Film : TVprogram, ITVprogram
    {
        public string name;
        public int year;
        public int limit = 16;
        public Film(string name, int year, double time, int agelimit)
        {
            this.year = year;
            this.name = name;
            this.time = time;
            this.agelimit = agelimit;
        }
        public void Watch()
        {
            if (agelimit > limit)
            {
                Console.WriteLine("Вам разрешено смотреть этот фильм");
            }
            else
            {
                Console.WriteLine("Вам рано еще смотреть этот фильм");
            }
        }
        public override string ToString()
        {
            return $"Возрастное ограничение на просмотр этого фильма {agelimit}";
        }
        public virtual void Show()
        {
            Console.WriteLine("\n\nНазвание: " + name + "\n" + "Год: " + year + "\n" + "Продолжительность: " + time + "\n" + "Возрастное ограничение: " + agelimit + "\n");
        }
    }

    class News : TVprogram, ITVprogram
    {
        public string theme;
        public string speackers;
        public int limit = 18;
        public News(string theme, string speackers, double time, int agelimit)
        {
            this.theme = theme;
            this.speackers = speackers;
            this.agelimit = agelimit;
            this.time = time;
        }
        public override string ToString()
        {
            return $"Возрастное ограничение этих новостей {limit}";
        }
        public void Watch()
        {
            if (agelimit > limit)
            {
                Console.WriteLine("Вам разрешено смотреть новости");
            }
            else
            {
                Console.WriteLine("Вам рано смотреть");
            }
        }
        public virtual void Show()
        {
            Console.WriteLine("\n\nТема: " + theme + "\n" + "Ведущие: " + speackers + "\n" + "Продолжительность: " + time + "\n" + "Возрастное ограничение: " + agelimit + "\n");
        }
        public override bool Equals(object obj)
        {
            if (obj == null) // проверка
            {
                Console.WriteLine("Что-то не так");
                return false;
            }

            obj = obj as News;
            if (obj != null)
            {
                Console.WriteLine("Это действительно новости");
                return true;
            }

            Console.WriteLine("Это не новости!");
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    class Filmic : TVprogram, ITVprogram//художественный фильм
    {
        public string name;
        public int limit = 12;
        public Filmic(string name, double time, int agelimit)
        {
            this.name = name;
            this.agelimit = agelimit;
            this.time = time;
        }
        public override string ToString()
        {
            return $"Возрастное ограничение этого художественного фильма {limit}";
        }
        public void Watch()
        {
            if (agelimit > limit)
            {
                Console.WriteLine("Вам разрешено смотреть фильм");
            }
            else
            {
                Console.WriteLine("Вам рано смотреть");
            }
        }
        public virtual void Show()
        {
            Console.WriteLine("\n\nНазвание: " + name + "\n" + "Продолжительность: " + time + "\n" + "Возрастное ограничение: " + agelimit + "\n");
        }
    }

    class Cartoon : TVprogram, ITVprogram
    {
        public string name;
        static int limit = 8;
        public Cartoon(string name, double time, int agelimit)
        {
            this.name = name;
            this.agelimit = agelimit;
            this.time = time;
        }
        public override string ToString()
        {
            return $"Возрастное ограничение этого мультфильма {limit}";
        }
        public void Watch()
        {
            if (agelimit > limit)
            {
                Console.WriteLine("Вам можно смотреть мультфильм");
            }
            else
            {
                Console.WriteLine("Вам нельзя это смотреть");
            }
        }
        public virtual void Show()
        {
            Console.WriteLine("\n\nНазвание: " + name + "\n" + "Продолжительность: " + time + "\n" + "Возрастное ограничение: " + agelimit + "\n");
        }
    }
    class Advertisment : TVprogram, ITVprogram
    {
        public static int count;
        public double limit = 4.00;
        static Advertisment()
        {
            count = 0;
        }
        public Advertisment(int agelimit)
        {
            count++;
            this.agelimit = agelimit;
        }
        public override string ToString()
        {
            return $"Максимальное время рекламы {limit}";
        }
        public void Watch()
        {
            if (agelimit < limit)
            {
                Console.WriteLine("Достаточное количество");
            }
            else
            {
                Console.WriteLine("Чересчур рекламы");
            }
        }
        public virtual void Show()
        {
            Console.WriteLine("\n\nПродолжительность рекламы: " + agelimit + "\n");
        }
    }

    sealed class Director : Person, IPerson
    {
        public int Age;
        public string Name { get; set; }
        public string Surname { get; set; }
        public Director(string surname, string name, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public void Information()
        {
            Console.WriteLine("\n\nДанные режиссера: " + Surname + " " + Name + " " + Age);
        }
        public override bool Equals(object obj)
        {
            if (obj == null) // проверка
            {
                Console.WriteLine("Что-то не так");
                return false;
            }

            obj = obj as Director;
            if (obj != null)
            {
                Console.WriteLine("Это действительно режиссер.");
                return true;
            }

            Console.WriteLine("Это не режиссер!");
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "Елена";
            Console.WriteLine(person.name + " " + person.age + " ");
            Person person1 = new Person();
            person1.name = "Elena";
            Console.WriteLine(person1.ToString());
            Console.WriteLine(person1.GetHashCode());
            person1.Move();
            Film film1 = new Film("Бойцовский клуб", 1999, 1.03, 18);
            film1.Show();
            Console.WriteLine(film1.ToString());
            film1.Watch();
            News news1 = new News("Погода", "Иванов И. и Иванов К.", 45, 21);
            news1.Show();
            Console.WriteLine(news1.ToString());
            news1.Watch();
            Filmic filmic1 = new Filmic("Форрест Гамп", 1.30, 10);
            filmic1.Show();
            Console.WriteLine(filmic1.ToString());
            filmic1.Watch();
            Cartoon cartoon1 = new Cartoon("Русалочка", 1.10, 6);
            cartoon1.Show();
            Console.WriteLine(cartoon1.ToString());
            cartoon1.Watch();
            Advertisment advertisment1 = new Advertisment(6);
            advertisment1.Show();
            Advertisment advertisment2 = new Advertisment(8);
            Console.WriteLine(advertisment1.ToString());
            advertisment1.Watch();
            Director director1 = new Director("Berton", "Tim", 45);
            director1.Information();
            if (director1 is Director)
            {
                Console.WriteLine("Это известный режиссер");
            }
            if (film1 is News)
            {
                Console.WriteLine("Бред");
            }
            else

            Console.WriteLine("Фильм не является новостями");
            Console.WriteLine();
            foreach (var p in Controller.obj.GetNames(typeof(Controller.obj)))
            {
                Console.WriteLine(p);
            }
            Console.WriteLine((Controller.obj)1);
            Console.WriteLine();
            User man = new User("Alexei", 19);
            Console.WriteLine(man.Name+" "+man.Age);
            Programms prog1 = new Programms();
            prog1.name_of_prog = "Игра на выживание";
            prog1.Year = 1999;
            prog1.begin = 18.00;
            prog1.end = 18.30;
            prog1.Inf();
            Controller.Time(prog1.begin, prog1.end);
            Programms prog2 = new Programms();
            prog2.begin = 11.30;
            prog2.end = 12.30;
            Controller.Time(prog2.begin, prog2.end);
            prog2.Year = 1999;
            prog2.name_of_prog = "Матрица";
            Programms prog3 = new Programms();
            prog3.Year = 1998;
            prog3.begin = 10.30;
            prog3.end = 12.00;
            Controller.Time(prog3.begin, prog3.end);
            Programms progi = new Programms();
        
            List<Programms> TV = new List<Programms>() { prog1, prog2, prog3 };
            TV.Add(progi);
            Controller.Count();
            Controller.Search(TV);

        }
    }

}
