using Emailverification;



namespace EmailValidation.Test
{
   
    public class EmailTest
    {
        EmailConformation conformation=new EmailConformation();
        [Theory]
        [InlineData("Superjoc@icloud.com", true)]
        public void EmailAddressShouldPass(String EmailAddress, Boolean Expected)
        {
            //Arrage
            Boolean _Expected = Expected;

            //Act
            Boolean Actual = conformation.VerifyEmail(EmailAddress);

            //Assert
            Assert.Equal(Expected, Actual);
        }
    }
}
