using System;
using System.Windows.Input;
using UIMock;

namespace UIMock
{
	public class OnboardingPageViewModel : BaseViewModel
    {
        private List<string> onboardingList;
        private int position = 0;

        public List<string> OnboardingList
        {
            get => onboardingList;
            set
            {
                if (onboardingList == value) return;
                onboardingList = value;
                OnPropertyChanged(nameof(OnboardingList));
            }
        }

        public int Position
        {
            get => position;
            set
            {
                if (position == value) return;
                position = value;
                OnPropertyChanged(nameof(Position));
            }
        }


        public ICommand ICommandNavToHomePage { get; set; }

        public OnboardingPageViewModel()
		{
            onboardingList = new();
            ICommandNavToHomePage = new Command(() => NavigateToHomePage());
            InitilizeOnboardingList();
        }

        private void NavigateToHomePage()
        {
            App.Current.MainPage = new NavigationPage(new LoginPage());
        }

        private void InitilizeOnboardingList()
        {
            OnboardingList.Add("onboarding1.png");
            OnboardingList.Add("onboarding2.png");
            OnboardingList.Add("onboarding3.png");
            OnboardingList.Add("onboarding4.png");
        }

    }
}