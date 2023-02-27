namespace Proyecto_final.Rules
{
    public class ContactosRule
    {
        private readonly IConfiguration _configuration;

        public ContactosRule(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public void SendEmail(string emailTo, string mensaje, string asunto, string? deQuien)
        {
            var from = _configuration["Email:fromEmail"];

            var fromName = deQuien ?? _configuration["Email:fromName"];


            //Create email messaje
        }
    }
}
