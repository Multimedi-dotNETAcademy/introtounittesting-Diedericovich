using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;


namespace TestNinja.UnitTests
{
    class ReservationTests
    {
        Reservation reservation = new Reservation();
        User _user = new User();        

        [Test]

        public void CanBeCancelled_GivenAdminIsUser_ReturnTrue()
        {
            _user.IsAdmin = true;

            bool result = reservation.CanBeCancelledBy(_user);

            Assert.IsTrue(result);
        }

        [Test]

        public void CanBeCancelled_GivenMadeByUser_ReturnTrue()
        {                       
            reservation.MadeBy = new User();

            bool result = reservation.CanBeCancelledBy(reservation.MadeBy);

            Assert.IsTrue(result);
        }

        [Test]

        public void CanBeCancelled_GivenAnotherUser_ReturnFalse()
        {
            _user.IsAdmin = false;           

            bool result = reservation.CanBeCancelledBy(_user);


            Assert.IsFalse(result);
        }

    }
}
