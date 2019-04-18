namespace ActiVote.App.ViewModels
{
    public class MainViewModel
    {
        private static MainViewModel instace;
        public LoginViewModel Login { get; set; }

        public EventsViewModel Events { get; set; }

        public CandidatesViewModel Candidates { get; set; }
        
        public MainViewModel()
        {
            instace = this;
        }

        public static MainViewModel GetInstance()
        {
            if(instace == null)
            {
                return new MainViewModel();
            }

            return instace;
        }
    }
}
