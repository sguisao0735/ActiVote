﻿namespace ActiVote.App.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Common.Models;
    using Common.Services;
    using Xamarin.Forms;

    public class EventsViewModel : BaseViewModel
    {
        private readonly ApiService apiService;
        private ObservableCollection<Event> events;
        public ObservableCollection<Event> Events
        {
            get { return this.events; }
            set { this.SetValue(ref this.events, value); }
        }


        public EventsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadEvents();
        }

        private async void LoadEvents()
        {
            var response = await this.apiService.GetListAsync<Event>(
                "https://activote.azurewebsites.net",
                "/api",
                "/Events");

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    response.Message,
                    "Accept");
                return;
            }

            var myEvents = (List<Event>)response.Result;
            this.Events = new ObservableCollection<Event>(myEvents);
        }
    }
}
