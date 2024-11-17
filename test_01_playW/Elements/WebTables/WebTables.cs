using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_01_playW
{
    internal class WebTables
    {
            private readonly ILocator webtableClick;
            private readonly ILocator addnew;
            private readonly ILocator firstname;
            private readonly ILocator lastname;
            private readonly ILocator email;
            private readonly ILocator age;
            private readonly ILocator salary;
            private readonly ILocator department;
            private readonly ILocator Sbtn;
            private readonly ILocator delete_btn;
             
            // edit
            private readonly ILocator edit;


            public WebTables(IPage page)
            {
                webtableClick = page.GetByText("#Web Tables");
                addnew = page.Locator("#addNewRecordButton");
                firstname = page.Locator("#firstName");
                lastname = page.Locator("#lastName");
                email = page.Locator("#userEmail");
                age = page.Locator("#age");
                salary = page.Locator("#salary");
                department = page.Locator("#department");
                Sbtn = page.Locator("#submit");

                // edit
                edit = page.Locator("#edit-record-3 > svg > path");

                // delete
                delete_btn = page.Locator("#delete-record-3 > svg > path");
                
            }
            public async Task WebtablesClicker(string fname, string lname, string eml, string agee, string salarey, string depart, string eLastname)
            {
                await webtableClick.ClearAsync();
                await addnew.ClearAsync();
                await firstname.FillAsync(fname);
                await lastname.FillAsync(lname);
                await email.FillAsync(eml);
                await age.FillAsync(agee);
                await salary.FillAsync(salarey);
                await department.FillAsync(depart);
                await Sbtn.ClickAsync();
                
                // edit hoga yahan se
                await edit.ClickAsync();
                await lastname.FillAsync(eLastname);
                await Sbtn.ClickAsync();

                // delete 
                await delete_btn.ClickAsync();
                
        }


        }
    }


