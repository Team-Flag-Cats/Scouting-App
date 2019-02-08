using System;
// software by Homan 2018

public partial class scout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {


        var varName = Request.Form["name"];
        var varPhone = Request.Form["phone"];
        var varTeamname = Request.Form["teamname"];
        var varPerformance = Request.Form["performance"];
		var varPlatform = Request.Form["platform"];
		var varClimb = Request.Form["climb"];
		var varDoubleClimb = Request.Form["doubleclimb"];
		var varAutoComments = Request.Form["autoComments"];
		var varRocketHatchesAuto = Request.Form["rockethatchesauto"];
		var varRocketHatchesAuto2 = Request.Form["rockethatchesauto2"];
		var varRocketHatchesAuto3 = Request.Form["rockethatchesauto3"];
		var varRocketCargoAuto = Request.Form["rocketcargoauto"];
		var varRocketCargoAuto2 = Request.Form["rocketcargoauto2"];
		var varRocketCargoAuto3 = Request.Form["rocketcargoauto3"];
		var varShipHatchesAuto = Request.Form["shiphatchesauto"];
		var varShipCargoAuto = Request.Form["shipcargoauto"];
		var varRocketHatches = Request.Form["rockethatches"];
		var varRocketHatches2 = Request.Form["rockethatches2"];
		var varRocketHatches3 = Request.Form["rockethatches3"];
		var varRocketCargo = Request.Form["rocketcargo"];
		var varRocketCargo2 = Request.Form["rocketcargo2"];
		var varRocketCargo3 = Request.Form["rocketcargo3"];
		var varShipHatches = Request.Form["shiphatches"];
		var varShipCargo = Request.Form["shipcargo"];
		var varContacts = Request.Form["contacts"];
		var varBricked = Request.Form["bricked"];
		var varDefenseRating = Request.Form["defenseRating"];
		
        if (!IsPostBack)
        {
            //Code when initial loading 
            using (System.IO.StreamWriter v = new System.IO.StreamWriter(Server.MapPath("~/Files/scouts.csv"), true))

            {
				//v.WriteLine("name,phone,teamname,performance,counter");
                v.WriteLine(varName + "," + varPhone + ","  + varTeamname + "," + varPerformance + "," 
				+ varPlatform + "," + varClimb + "," + varDoubleClimb + "," + varAutoComments + "," 
				+ "," + varRocketHatchesAuto + "," + varRocketHatchesAuto2 + "," + varRocketHatchesAuto3
				+ "," + varRocketCargoAuto + "," + varRocketCargoAuto2 + "," + varRocketCargoAuto3 + "," + varShipHatchesAuto
				+ "," + varShipCargoAuto + "," + varRocketHatches + "," + varRocketHatches2 + "," + varRocketHatches3
				+ "," + varRocketCargo + "," + varRocketCargo2 + "," + varRocketCargo3 + "," + varShipHatches 
				+ "," + varShipCargo + "," + varContacts + "," + varBricked + "," + varDefenseRating);
            }
			using (System.IO.StreamWriter h = new System.IO.StreamWriter(Server.MapPath("~/Files/header.csv"), false)){
				h.WriteLine("Name,Phone,Teamname,Performance,Platform,Climb,DoubleClimb," + 
				"AutoComments,RocketHatchesAuto,RocketHatchesAuto2,RocketHatchesAuto3,RocketCargoAuto,RocketCargoAuto2," +
				"RocketCargoAuto3,ShipHatchesAuto,ShipCargoAuto,RocketHatches,RocketHatches2,RocketHatches3,RocketCargo," +
				"RocketCargo2,RocketCargo3,ShipHatches,ShipCargo,Contacts,Bricked,DefenseRating");
			}
			
			using (var outputStream = System.IO.File.Create(Server.MapPath("~/Files/finalScout.csv")))
			{
					using (var headerStream = System.IO.File.OpenRead(Server.MapPath("~/Files/header.csv")))
					{
						// Buffer size can be passed as the second argument.
						headerStream.CopyTo(outputStream);
					} 
					using (var scoutStream = System.IO.File.OpenRead(Server.MapPath("~/Files/scout.csv")))
					{
						// Buffer size can be passed as the second argument.
						scoutStream.CopyTo(outputStream);
					}
					
			}
			
			Response.Write("success");
			
        } else {
            
            // code when post back 
			
        }
        
        catch (Exception ex)
        {
            Response.Write("error " + ex.Message);
            
        }

    }


}

