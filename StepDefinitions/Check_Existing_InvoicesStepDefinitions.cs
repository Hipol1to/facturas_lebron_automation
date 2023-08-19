using System;
using TechTalk.SpecFlow;

namespace FacturasLebron.StepDefinitions
{
    [Binding]
    public class Check_Existing_InvoicesStepDefinitions
    {
        [Given(@"existing invoices")]
        public void GivenExistingInvoices()
        {
            throw new PendingStepException();
        }

        [When(@"selecting an invoice")]
        public void WhenSelectingAnInvoice()
        {
            throw new PendingStepException();
        }

        [Then(@"the invoice details are displayed, including client and items")]
        public void ThenTheInvoiceDetailsAreDisplayedIncludingClientAndItems()
        {
            throw new PendingStepException();
        }

        [Given(@"paid and unpaid invoices")]
        public void GivenPaidAndUnpaidInvoices()
        {
            throw new PendingStepException();
        }

        [When(@"checking invoice payment status")]
        public void WhenCheckingInvoicePaymentStatus()
        {
            throw new PendingStepException();
        }

        [Then(@"the payment status for each invoice is accurately displayed")]
        public void ThenThePaymentStatusForEachInvoiceIsAccuratelyDisplayed()
        {
            throw new PendingStepException();
        }
    }
}
