using Library;
namespace LibraryTests
{
    [TestClass]
    public sealed class BookTests
    {
        [TestMethod]
        public void MemberConstructor_ShouldInitialiseProperties()
        {
            // Arrange

            int memberId = 1;
            string name = "John Doe";
            string address = "123 Main St";
            int phone = 1234567890;

            // Act

            Member member = new Member(memberId, name, address, phone);

            // Assert

            Assert.AreEqual(memberId, member.MemberId);
            Assert.AreEqual(name, member.Name);
            Assert.AreEqual(address, member.Address);
            Assert.AreEqual(phone, member.Phone);
        }
    }
}
