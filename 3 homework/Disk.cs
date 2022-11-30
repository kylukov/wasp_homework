using System;
using System.Runtime.ConstrainedExecution;

namespace wasp_3
{
	public class Disk
	{
		private string _name;
		private string _genre;
		private int _burnCount;

		public string Name { get => _name; set => _name = value; }
		public string Genre { get => _genre; set => _genre = value; }
		public int BurnCount { get => _burnCount; set => _burnCount = value; }

		public Disk(string name, string genre)
		{
			Name = name;
			Genre = genre;
		}

		public virtual string[] Burn { get; set; }

		public virtual int DiskSize { get; set; }

        public override string ToString()
        {
            return Name + " " + Genre;
        }

    }

	public class Audio: Disk
	{
		private string _artist;
		private string _recordingStudio;
		private int _songsNumber;

        public string Artist { get => _artist; set => _artist = value; }
        public string RecordingStudio { get => _recordingStudio;
			set => _recordingStudio = value; }
        public int SongsNumber { get => _songsNumber;
			set => _songsNumber = value; }

        public Audio(string name,
                     string genre,
                     string artist,
                     string recordingStudio,
                     int songsnumber) : base(name, genre)
        {
			Artist = artist;
			RecordingStudio = recordingStudio;
			SongsNumber = songsnumber;
        }

        public override int DiskSize { get => SongsNumber * 8; }

        public override string ToString()
        {
            return base.Name + " " +
                base.Genre + " " +
				Artist + " " +
                RecordingStudio + " " +
                SongsNumber + " " +
                base.Burn ;
        }
    }

    public class DVD : Disk
    {
        private string _producer;
        private string _filmCompany;
        private int _minutesCount;
        public string Producer { get => _producer; set => _producer = value; }
        public string FilmCompany { get => _filmCompany; set => _filmCompany = value; }
        public int MinutesCount { get => _minutesCount; set => _minutesCount = value; }
        public DVD(string name,
                   string genre,
                   string producer,
                   string filmCompany,
                   int minutesCount) : base(name, genre)
        {
            Producer = producer;
            FilmCompany = filmCompany;
            MinutesCount = minutesCount;
        }

        public override int DiskSize { get => (MinutesCount / 64) * 2 ; }

        public override string ToString()
        {
            return base.ToString() + " " + Producer + " " + FilmCompany + " " + MinutesCount;
        }

    }

    public class Store
    {
        private string _storeName;
        private string _address;
        private List<Audio> _audios = new List<Audio>();
        private List<DVD> _dvds = new List<DVD>();

        public string StoreName { get => _storeName; set => _storeName = value; }
        public string Address { get => _address; set => _address = value; }

        public Store(string storeName,
                     string address)
        {
            StoreName = storeName;
            Address = address;
        }

        public void AddAudio(Audio audio){ _audios.Add(audio); }
        public void DeleteAudio(Audio audio) { _audios.Remove(audio); }

        public void AddDvd(DVD dvd) { _dvds.Add(dvd); }
        public void DeleteDVD(DVD dvd) { _dvds.Remove(dvd); }

        public override string ToString()
        {
            string res = "";
            foreach(Audio audio in _audios)
            {
                res += " > Audio: " + audio.ToString() + "\n";
            }
            foreach(DVD dvd in _dvds)
            {
                res += " > Film: " + dvd.ToString() + "\n";
            }

            return res;
        }


    }
}

