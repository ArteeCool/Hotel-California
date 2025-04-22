using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelCalifornia
{
    public partial class clientInfo : Form
    {
        private readonly BookingService _bookingService;
        private readonly GuestService _guestService;
        private readonly string _roomId;
        private readonly DateTime _fromDate;
        private readonly DateTime _toDate;

        public clientInfo(BookingService bookingService, GuestService guestService, string roomId, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            _bookingService = bookingService;
            _guestService = guestService;
            _roomId = roomId;
            _fromDate = fromDate;
            _toDate = toDate;
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_Button_MouseEnter(Object sender, EventArgs e)
        {
            close.ForeColor = Color.Red;
        }

        private void Close_Button_MouseLeave(Object sender, EventArgs e)
        {
            close.ForeColor = Color.Purple;
        }

        private void bookRoom_scheduleNow_BookBtn_Click(object sender, EventArgs e)
        {
            var guest = new Guest(fullName: clientInfo_name.Text,
                gender: clientInfo_gender.Text,
                email: clientInfo_email.Text,
                address: clientInfo_adress.Text,
                contactNumber: clientInfo_number.Text
                );

            if (_guestService == null)
            {
                MessageBox.Show("Guest service is not available.");
                return;
            }

            string guestId = _guestService.FindOrCreateGuest(guest);

            if (_bookingService == null)
            {
                MessageBox.Show("Booking service is not available.");
                return;
            }

            //создание брони
            bool success = _bookingService.BookRoom(roomId: _roomId,
                guestId: guest.Id, //ID из конструктора Guest(остальное через ID подтянется)
                fromDate: _fromDate,
                toDate: _toDate
            );

        }
    }
}
