using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task4
{
    public class Hospital
    {
        private static Hospital _instance;
        public static Hospital Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Hospital();
                }
                return _instance;
            }
        }
        private Hospital()
        {
            Doctors = new List<Doctor>();
            Rooms = new List<Room>();
        }
        public List<Doctor> Doctors { get; set; }
        public List<Room> Rooms { get; set; }
        public void AdmitPatient(Patient patient)
        {
            foreach (Room room in Rooms)
            {
                if (room.Patients.Count < room.Capacity)
                {
                    room.AssignPatient(patient);
                    Console.WriteLine("Patient" + patient.Name + "admitted to room" + room.RoomNumber);
                    return;
                }
            }
            Console.WriteLine("no free room for this patient.");
        }
        public void DischargePatient(Patient patient)
        {
            foreach (Room room in Rooms)
            {
                if (room.Patients.Contains(patient))
                {
                    room.Patients.Remove(patient);
                    Console.WriteLine("Patients" + patient.Name + "discharged from room" + room.RoomNumber);
                    return;
                }
            }
            Console.WriteLine("Parient not found in any room.");
        }
    }
}