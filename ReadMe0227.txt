1) SQL 
	-> Create View
	-> Create store procedure

	
2) Visual Studio
	-> Get Views and Procedure on EDMX
	-> Create view model of views and procedure that were generate  on EDMX
	-> On Utility Controller, on GetContactInfoOds method, it calls another function, modify that function and call procedure name (entity.Prcedure) 

	internal static List<MODEL NAME> GetOdsPersonList()
        {
            using (var entiity = new HimalDbEntities())
            {
                var list = entiity.SP_PROCEDURE.OrderBy(x => x.DISPLAYNAME).ToList();
				var listModel = new List<MODEL NAME>();
				
				foreach(var item in list)
				{
				var model = new MODEL NAME();
				model.ProfileID= item.ProfileID;
				listModel.ADD(model);
				}
				
                return listModel;
            }
        }
		
		
		
		
------ March 1st
1) Search Operation, In Navbar2, write script and call jquery and css for autocomplete.
2) 	/Personnal/Search/ (Controller)
3) View -> /Personnal/Search/ 
4) SCAR -> Scar/Index ( Controller)
5) View -> Scar/Index , use jquery and search functionality