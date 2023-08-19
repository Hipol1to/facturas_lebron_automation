using System;
using TechTalk.SpecFlow;

namespace FacturasLebron.StepDefinitions
{
    [Binding]
    public class User_AdministrationStepDefinitions
    {
        [Given(@"logged-in administrator")]
        public void GivenLogged_InAdministrator()
        {
            throw new PendingStepException();
        }

        [When(@"adding a new user with appropriate permissions")]
        public void WhenAddingANewUserWithAppropriatePermissions()
        {
            throw new PendingStepException();
        }

        [Then(@"the new user's information is stored in the database")]
        public void ThenTheNewUsersInformationIsStoredInTheDatabase()
        {
            throw new PendingStepException();
        }

        [Given(@"logged-in user without admin privileges")]
        public void GivenLogged_InUserWithoutAdminPrivileges()
        {
            throw new PendingStepException();
        }

        [When(@"attempting to add a new user")]
        public void WhenAttemptingToAddANewUser()
        {
            throw new PendingStepException();
        }

        [Then(@"the system rejects the user creation request")]
        public void ThenTheSystemRejectsTheUserCreationRequest()
        {
            throw new PendingStepException();
        }
    }
}
