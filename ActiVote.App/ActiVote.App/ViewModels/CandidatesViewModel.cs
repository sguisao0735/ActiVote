namespace ActiVote.App.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Common.Models;
    using Common.Services;
    using Xamarin.Forms;

    public class CandidatesViewModel : BaseViewModel
    {
        private readonly ApiService apiService;
        private ObservableCollection<Candidate> candidates;
        public ObservableCollection<Candidate> Candidates
        {
            get { return this.candidates; }
            set { this.SetValue(ref this.candidates, value); }
        }


        public CandidatesViewModel()
        {
            this.apiService = new ApiService();
            this.LoadCandidates();
        }

        private async void LoadCandidates()
        {
            var response = await this.apiService.GetListAsync<Candidate>(
                "https://activote.azurewebsites.net",
                "/api",
                "/Candidates");

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Accept");
                return;
            }

            var myCandidates = (List<Candidate>)response.Result;
            this.Candidates = new ObservableCollection<Candidate>(myCandidates);
        }
    }
}
