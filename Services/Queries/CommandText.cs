namespace PlantIT.API.Services.Queries
{
    public class CommandText : ICommandText
    {

        public string Get => "SELECT * FROM tbl_BP_Material";
        public string GetById => "SELECT * FROM tbl_BP_Material WHERE nKey=@nKey";
        public string Add => "";
        public string Update => "";
        public string Remove => "";
    }
}