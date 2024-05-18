using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AllureReporting
{
    public class ExecutionClass : Basepage
    {
        Basepage basepage = new Basepage();   
        LoginPage login = new LoginPage();
        AdminPanel admin = new AdminPanel();
        Adduser adduser = new Adduser();
        SearchUser searchuser = new SearchUser();   
        
        [SetUp]
        public void Setup()
        {
            basepage.SeleniumInit("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
        }
        [TearDown]  
        public void TearDown() 
        {
            basepage.Close();
        }
        
        [Test]
        public void OrangeHRM()
        {
            login.Valid_login("Admin","admin123");
            admin.Admin_Panel();
            adduser.Add_User();
            searchuser.search_user();
        }
    }
}