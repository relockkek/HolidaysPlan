using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HolidaysPlan
{
    internal class DB
    {
        List<Person> persons = new List<Person>();
        List<Holiday> holidays = new List<Holiday>();
        List<Present> presents = new List<Present>();
        int PersonAutoIncrement;
        int GiftAutoIncrement;
        int HolidaysAutoIncrement;

        string filename = "DBIncrement";

        private static DB instance;
        public static DB GetInstance()
        {
            if (instance == null)
                instance = new DB();
            return instance;
        }

        public void Save()
        {
            using (var fs = File.Create("persons.json"))
            {

                JsonSerializer.Serialize(fs, persons);
            }
            using (var fs = File.Create("holidays.json"))
            {

                JsonSerializer.Serialize(fs, holidays);
            }
            using (var fs = File.Create("presents.json"))
            {

                JsonSerializer.Serialize(fs, presents);
            }
            SaveIncrement();
        }
        public void Load()
        {
            if (!File.Exists("holidays.json"))
                return;
            if (!File.Exists("persons.json"))
                return;
            if (!File.Exists("presents.json"))
                return;
            using (var fs = File.OpenRead("persons.json"))
            {
                persons = JsonSerializer.Deserialize<List<Person>>(fs);
            }
            using (var fs = File.OpenRead("holidays.json"))
            {
                holidays = JsonSerializer.Deserialize<List<Holiday>>(fs);
            }
            using (var fs = File.OpenRead("presents.json"))
            {
                presents = JsonSerializer.Deserialize<List<Present>>(fs);
            }
            ReadIncrement();
        }
        public void PersonAdd(Person person)
        {
            person.Id = ++PersonAutoIncrement;
            persons.Add(person);

        }
        public void HolidayAdd(Holiday holiday)
        {
            holiday.Id = ++HolidaysAutoIncrement;
            holidays.Add(holiday);

        }
        public void PresentAdd(Present present)
        {
            present.Id = ++GiftAutoIncrement;
            presents.Add(present);
        }

        public void SaveIncrement()
        {
            using (var fs = File.Create(filename))
            using (var bw = new BinaryWriter(fs))
            {
                bw.Write(PersonAutoIncrement);
                bw.Write(HolidaysAutoIncrement);
                bw.Write(GiftAutoIncrement);
            }
        }

        public void ReadIncrement()
        {
            if (!File.Exists(filename))
                return;
            int count;
            using (var fs = File.OpenRead(filename))
            using (var br = new BinaryReader(fs))
            {
                PersonAutoIncrement = br.ReadInt32();
                HolidaysAutoIncrement = br.ReadInt32();
                GiftAutoIncrement = br.ReadInt32();
            }
        }
        public List<Person> GetPerson() 
        {
            return persons;
        }
        public List<Holiday> GetHoliday()
        {
            return holidays;
        }
        public List<Present> GetPresent()
        {
            return presents;
        }
    }
}

