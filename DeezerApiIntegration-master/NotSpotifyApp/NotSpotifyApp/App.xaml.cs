﻿using NotSpotifyApp.Services;
using NotSpotifyApp.Utilities;
using NotSpotifyApp.ViewModels;
using NotSpotifyApp.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotSpotifyApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

              NavigationService.NavigateAsync(new Uri(NavigationConstants.TabbedPageMenu, UriKind.Absolute));
              //NavigationService.NavigateAsync(new Uri(NavigationConstants.AccessPage, UriKind.Absolute));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<OptionsTabbedPage>();
            containerRegistry.RegisterForNavigation<AccessPage,AccessPageViewModel>();
            containerRegistry.RegisterForNavigation<ArtistPage, ArtistPageViewModel>();
            containerRegistry.RegisterForNavigation<ArtistInfoPage, ArtistInfoPageViewModel>();
            containerRegistry.RegisterForNavigation<AlbumPage, AlbumPageViewModel>();
            containerRegistry.RegisterForNavigation<AlbumInfoPage, AlbumInfoPageViewModel>();
            containerRegistry.RegisterForNavigation<GenrePage, GenrePageViewModel>();
            containerRegistry.RegisterForNavigation<SongPlayerPage, SongPlayerPageViewModel>();
            containerRegistry.RegisterForNavigation<TrackPage, TrackPageViewModel>();
            containerRegistry.Register<IDeezerApiService, DeezerApiService>();
        }

    }
}
