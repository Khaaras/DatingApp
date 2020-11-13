namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }     // musi byc publiczne inaczej robiąć migrację nie zostałoby rozpoznane jako PrimaryKey
        public string UserName { get; set; }
 
        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }  

    }
}