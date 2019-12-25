using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsGasolineTanker
{
    public class MultiLevelParking
    {
        List<Parking<ITransport>> parkingStages;
        private const int countPlaces = 5;
        private int pictureWidth;
        private int pictureHeight;
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
            }
        }
        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new StreamWriter(File.OpenWrite(filename)))
            {
                fs.WriteLine($"CountLevels:{parkingStages.Count}");
                foreach (var level in parkingStages)
                {
                    fs.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        try
                        {
                            var truck = level[i];
                            if (truck != null)
                            {
                                if (truck.GetType().Name == "BaseClassTruck")
                                {
                                    fs.WriteLine($"{i}:BaseClassTruck:" + truck);
                                }
                                if (truck.GetType().Name == "FullTruck")
                                {
                                    fs.WriteLine($"{i}:FullTruck:" + truck);
                                }
                            }
                        }
                        finally { }
                    }
                }
            }
        }
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string buff = "";
            using (StreamReader fs = new StreamReader(File.OpenRead(filename)))
            {
                buff = fs.ReadLine();
                if (buff.Split(':')[0] == "CountLevels")
                {
                    int countLevel = Convert.ToInt32(buff.Split(':')[1]);
                    if (parkingStages != null)
                        parkingStages.Clear();
                    parkingStages = new List<Parking<ITransport>>(countLevel);
                }
                else
                    throw new Exception("Неверный формат файла");
                int count = -1;
                while (!fs.EndOfStream)
                {
                    buff = fs.ReadLine();
                    ITransport truck = null;
                    if (buff == "Level")
                    {
                        count++;
                        parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
                        continue;
                    }
                    if (buff.Split(':')[1] == "BaseClassTruck")
                    {
                        truck = new BaseClassTruck(buff.Split(':')[2]);
                        parkingStages[count][Convert.ToInt32(buff.Split(':')[0])] = truck;
                    }
                    if (buff.Split(':')[1] == "FullTruck")
                    {
                        truck = new FullTruck(buff.Split(':')[2]);
                        parkingStages[count][Convert.ToInt32(buff.Split(':')[0])] = truck;
                    }
                }
            }
        }
        public void Sort()
        {
            parkingStages.Sort();
        }
    }
}