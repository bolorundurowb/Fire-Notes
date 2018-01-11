﻿using System;
using firenotes.Models;
using Xamarin.Forms;

namespace firenotes.Views
{
    public partial class NoteDetailsPage : ContentPage
    {
        public bool FavoriteVisible { get; set; }
        public bool UnFavoriteVisible { get; set; }

        public NoteDetailsPage(Note note)
        {
            InitializeComponent();

            // set the page title
            this.Title = "Note Details";

            // set the stack layout background color to create a seamleass look
            if (Device.RuntimePlatform == Device.Android)
            {
                stkContent.BackgroundColor = Color.FromHex("#FAFAFA");
            }

            // set the display data
            this.lblTitle.Text = note.Title;
            this.lblContent.Text = note.Details;
            this.lblCreated.Text = note.Created.ToString("dd/MM/yyy HH:mm:ss");

            // enable and disable buttons as required
            // TODO: actually hide the unnecessary button
            if (note.IsFavorite)
            {
                FavoriteVisible = false;
                UnFavoriteVisible = true;
            }
            else
            {
                FavoriteVisible = true;
                UnFavoriteVisible = false;
            }
        }

        private async void FavoriteNote(object sender, EventArgs e)
        {
            
        }

        private async void UnFavoriteNote(object sender, EventArgs e)
        {
            
        }
    }
}
