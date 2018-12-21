//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Pf.Library
//{
//	public interface IPfRepository
//	{
//		// interafce used to access data will define all access methods here
//		//will be implemented by the repo that has datacontext inside of it
//		IEnumerable<Users> GetUsers(string search);
//		// grabbing table of users, may have to implemnt users into pf.lib

//		//get users by id
//		Users GetUsersById(int Id);

//		//adding user, not sure where this differs from create
//		void AddUser(Users users);

//		//I wont delete a user, should make field that says inactive bool
//		//void DeleteUsers(int Id);

//		//edit update whatevs.
//		void UpdateUsers(Users users);

//		///LOCATOIN THIS SOUNDS FUN
//		void AddLocation(UserLocation userLocation, Users users);
//		//this may have to be userid at the end parm

//		//update edit a location, could just add a new loc to user
//		void UpdateLocation(Location location);

//		void Save();

//	}
//}
