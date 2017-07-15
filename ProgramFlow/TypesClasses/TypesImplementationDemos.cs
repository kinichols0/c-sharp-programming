﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgramming.TypesClasses
{
    public class TypesImplementationDemos
    {
        public static void BasicStructDemo()
        {
            Console.WriteLine("Started struct demo...\n");

            Rectangle rect = new Rectangle(5, 10);
            Console.WriteLine("Initialized a struct with dimensions {0}x{1} (LxW).", rect.length, rect.width);

            Rectangle rect2;
            rect2.length = 10;
            rect2.width = 20;
            Console.WriteLine("Initialized a struct with dimensions {0}x{1} (LxW).", rect2.length, rect2.width);

            Console.WriteLine("\nEnded struct demo...");
        }

        public static void InheritanceDemo()
        {
            Console.WriteLine("Started basic inheritance demo...");

            StudentProfileData studentProfile = new StudentProfileData();
            studentProfile.Print();

            StudentProfileData studenProfile2 = new StudentProfileData("Kelvin", "Nichols", "Computer Science", ClassStanding.Senior);
            studenProfile2.Print();

            Console.WriteLine("Ended basic inheritance demo...");
        }

        public static void BoxingUnboxingDemo()
        {
            Console.WriteLine("Started basic boxing and unboxing demo...");

            int i = 55;
            Console.WriteLine("int i = {0}", i);
            Console.WriteLine("boxing i");

            object o = i;// implicit boxing, explicit boxing ex: object o = (object)i
            Console.WriteLine("i is still {0}", o);

            object x = 122;
            Console.WriteLine("object x = {0}", x);
            Console.WriteLine("unboxing x");
            i = (int)x;
            Console.WriteLine("x is still {0}", x);

            Console.WriteLine("Ended basic boxing and unboxing demo...");
        }

        public static void IComparableDemo()
        {
            Console.WriteLine("Started basic IComparable demo...");

            List<ComparableAgeEntity> entities = new List<ComparableAgeEntity>()
                        {
                            new ComparableAgeEntity("Name1", 26),
                            new ComparableAgeEntity("Name2", 30),
                            new ComparableAgeEntity("Name3", 5),
                            new ComparableAgeEntity("Name4", 6),
                            new ComparableAgeEntity("Name5", 50),
                            new ComparableAgeEntity("Name6", 40),
                            new ComparableAgeEntity("Name7", 33),
                            new ComparableAgeEntity("Name8", 12),
                            new ComparableAgeEntity("Name9", 65),
                            new ComparableAgeEntity("Name10", 70)
                        };

            Console.WriteLine("All comparable entities");
            entities.ForEach(t => Console.WriteLine(t));

            Console.WriteLine("\nComparable entities sorted by age from youngest to oldest");
            entities.Sort();
            entities.ForEach(t => Console.WriteLine(t));

            Console.WriteLine("\nComparable entities sorted by age from oldest to youngest");
            entities = entities.OrderByDescending(t => t).ToList();
            entities.ForEach(t => Console.WriteLine(t));

            Console.WriteLine("Ended basic IComparable demo...");
        }

        public static void IEnumerableDemo()
        {
            Console.WriteLine("Started IEnumerable Implementation demo...");

            // One way to initialize the collection
            EnumerableCollection<ComparableAgeEntity> objs = new EnumerableCollection<ComparableAgeEntity>() {
                            new ComparableAgeEntity("Name1", 26),
                            new ComparableAgeEntity("Name2", 30),
                            new ComparableAgeEntity("Name3", 5),
                            new ComparableAgeEntity("Name4", 6),
                            new ComparableAgeEntity("Name5", 50),
                            new ComparableAgeEntity("Name6", 40),
                            new ComparableAgeEntity("Name7", 33),
                            new ComparableAgeEntity("Name8", 12),
                            new ComparableAgeEntity("Name9", 65),
                            new ComparableAgeEntity("Name10", 70)
                        };

            // Another way to initialize the collection
            ComparableAgeEntity[] comparableEntities = new ComparableAgeEntity[]
            {
                            new ComparableAgeEntity("Name1", 26),
                            new ComparableAgeEntity("Name2", 30),
                            new ComparableAgeEntity("Name3", 5),
                            new ComparableAgeEntity("Name4", 6),
                            new ComparableAgeEntity("Name5", 50),
                            new ComparableAgeEntity("Name6", 40),
                            new ComparableAgeEntity("Name7", 33),
                            new ComparableAgeEntity("Name8", 12),
                            new ComparableAgeEntity("Name9", 65),
                            new ComparableAgeEntity("Name10", 70)
            };
            var collection = new EnumerableCollection<ComparableAgeEntity>(comparableEntities);

            // Custom Add implementation
            collection.Add(new ComparableAgeEntity("NameX", 16));

            // Custom foreach implementation
            collection.ForEach(t => Console.WriteLine(t));

            Console.WriteLine("Ended IEnumerable Implementation demo...");
        }
    }
}