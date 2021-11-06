using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_tests_autoit
{
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void TestGroupRemove()
        {
           /* if (app.Groups.IsGroupExists() != true)
            {
                GroupData newGroup = new GroupData()
                {
                    Name = "test"
                };
            }*/

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Remove(1);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            oldGroups.Sort();
            newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
