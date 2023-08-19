using System;
using TechTalk.SpecFlow;

namespace FacturasLebron.StepDefinitions
{
    [Binding]
    public class User_Password_Secure_StorageStepDefinitions
    {
        [Given(@"a user with credentials")]
        public void GivenAUserWithCredentials()
        {
            throw new PendingStepException();
        }

        [When(@"the user's password is saved")]
        public void WhenTheUsersPasswordIsSaved()
        {
            throw new PendingStepException();
        }

        [Then(@"the password is encrypted using a strong algorithm")]
        public void ThenThePasswordIsEncryptedUsingAStrongAlgorithm()
        {
            throw new PendingStepException();
        }

        [Then(@"the encrypted password is stored in the database")]
        public void ThenTheEncryptedPasswordIsStoredInTheDatabase()
        {
            throw new PendingStepException();
        }

        [Given(@"an encrypted password in the database")]
        public void GivenAnEncryptedPasswordInTheDatabase()
        {
            throw new PendingStepException();
        }

        [When(@"attempting to decrypt the password")]
        public void WhenAttemptingToDecryptThePassword()
        {
            throw new PendingStepException();
        }

        [Then(@"the decrypted password is not readable")]
        public void ThenTheDecryptedPasswordIsNotReadable()
        {
            throw new PendingStepException();
        }

        [Then(@"the decrypted password does not match the original password")]
        public void ThenTheDecryptedPasswordDoesNotMatchTheOriginalPassword()
        {
            throw new PendingStepException();
        }
    }
}
