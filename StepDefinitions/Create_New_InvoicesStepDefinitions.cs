using System;
using TechTalk.SpecFlow;

namespace FacturasLebron.StepDefinitions
{
    [Binding]
    public class Create_New_InvoicesStepDefinitions
    {
        [Given(@"existing products")]
        public void GivenExistingProducts()
        {
            throw new PendingStepException();
        }

        [When(@"creating a new invoice and adding products")]
        public void WhenCreatingANewInvoiceAndAddingProducts()
        {
            throw new PendingStepException();
        }

        [Then(@"the selected products are included in the invoice")]
        public void ThenTheSelectedProductsAreIncludedInTheInvoice()
        {
            throw new PendingStepException();
        }

        [Given(@"existing clients")]
        public void GivenExistingClients()
        {
            throw new PendingStepException();
        }

        [When(@"creating a new invoice and selecting a client")]
        public void WhenCreatingANewInvoiceAndSelectingAClient()
        {
            throw new PendingStepException();
        }

        [Then(@"the client's information is associated with the invoice")]
        public void ThenTheClientsInformationIsAssociatedWithTheInvoice()
        {
            throw new PendingStepException();
        }

        [Given(@"products with prices")]
        public void GivenProductsWithPrices()
        {
            throw new PendingStepException();
        }

        [When(@"adding products to an invoice")]
        public void WhenAddingProductsToAnInvoice()
        {
            throw new PendingStepException();
        }

        [Then(@"the total amount is calculated accurately based on product prices")]
        public void ThenTheTotalAmountIsCalculatedAccuratelyBasedOnProductPrices()
        {
            throw new PendingStepException();
        }
    }
}
