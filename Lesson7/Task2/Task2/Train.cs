using System;

namespace Task2
{
    public struct Train
    {
        private string destinationPlace;
        private int trainNumber;
        private DateTime departureTime;

        public Train(string destinationPlace, int trainNumber, DateTime departureTime)
        {
            this.destinationPlace = destinationPlace;
            this.trainNumber = trainNumber;
            this.departureTime = departureTime;
        }

        public string DestinationPlace { get { return destinationPlace; } }
        public int TrainNumber { get { return trainNumber; } }
        public DateTime DepartureTime { get { return departureTime; } }

    }
}