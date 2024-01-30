using System;
namespace UIMock
{
	public class HomePageViewModel : BaseViewModel
	{
		private List<MedicineReminderModel> _reminderList;


		public List<MedicineReminderModel> ReminderList
		{
			get => _reminderList;

			set
			{
				if (_reminderList == value) return;
				_reminderList = value;
				OnPropertyChanged(nameof(ReminderList));
            }
        }

		public HomePageViewModel()
		{
			_reminderList = [];
			InitList();
        }

		private void InitList()
		{
			ReminderList.Add(new MedicineReminderModel()
			{
				Medicine = "Acetaminophen",
				Dose = "10mg",
				 Time = "Before launch 2:00 PM",
			});

            ReminderList.Add(new MedicineReminderModel()
            {
                Medicine = "Naproxen",
                Dose = "10mg",
                Time = "Before launch 2:10 PM",
            });

        }

	}

	public class MedicineReminderModel
	{
		public string Medicine { get; set; } = string.Empty;
        public string Dose { get; set; } = string.Empty;
        public string Time { get; set; } = string.Empty;
    }

}

