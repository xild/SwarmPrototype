﻿using System;

namespace Prototype.Models
{
	public class User
	{
		public string Name { get; private set; }
		public string Description { get; private set; }
		public string LastCheckIn { get; private set; }
		public string Location { get; private set; }
		public string Status { get; private set; }
		public int PhotoCount { get; private set; }
		public int FriendCount { get; private set; }

		public User (string name, string description, string lastCheckIn, string location, int photoCount, int friendCount, string status = "")
		{
			Name = name;
			Description = description;
			LastCheckIn = lastCheckIn;
			Location = location;
			PhotoCount = photoCount;
			FriendCount = friendCount;
			Status = status;
		}
	}
}

