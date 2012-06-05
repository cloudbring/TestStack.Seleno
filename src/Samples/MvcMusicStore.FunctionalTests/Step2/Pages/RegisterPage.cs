using MvcMusicStore.Models;
using TestStack.Seleno.PageObjects;
using OpenQA.Selenium;

namespace MvcMusicStore.FunctionalTests.Step2.Pages
{
    public class RegisterPage : Page<RegisterModel>
    {
        public HomePage SubmitRegistration()
        {
            return NavigateTo<HomePage>(By.CssSelector("input[type='submit']"));
        }
    }
}