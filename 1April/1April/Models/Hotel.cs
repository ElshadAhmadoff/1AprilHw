using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1.Models
{
    class Hotel
    {
        private string _name;
        private Room[] _rooms = new Room[0];
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public Hotel(string name)
        {
            Name = name;
        }
        public Room this[int index]
        {
            get { return _rooms[index]; }
            set
            {
                _rooms[index] = value;
            }
        }

        public void AddRooms(Room room)
        {
            Array.Resize(ref _rooms, _rooms.Length + 1);
            this[_rooms.Length - 1] = room;
        }
        public void Reserve(int? roomId)
        {
            for (int i = 0; i < _rooms.Length; i++)
            {
                if (this[i].Id == roomId)
                {
                    if (this[i].IsAviable == true)
                    {
                        this[i].IsAviable = false;
                        Console.WriteLine($"{this[i].Name} has reserved");
                        break;
                    }
                    else if (this[i].Id == roomId && i == _rooms.Length - 1) throw new NotAviableException("Room already was reserved");
                }
                else if (this[i].Id == roomId && i == _rooms.Length - 1) throw new NotFoundExceptions("Room could not find");
            }
        }
    }
}