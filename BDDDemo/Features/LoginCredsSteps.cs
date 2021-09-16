using System;
using TechTalk.SpecFlow;

namespace BDDDemo.Features
{
    [Binding]
    public class LoginCredsSteps
    {
        [When(@"User enter username and password")]
        public void WhenUserEnterUsernameAndPassword(Table table)
        {
            foreach(TableRow row in table.Rows)
            {
                foreach(string value in row.Values)
                {
                    Console.WriteLine(value);
                }
            }

        }
    }
}
