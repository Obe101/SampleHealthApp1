using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHealthApp.Pages;
    
    public partial class HelpPage : ContentPage
    {
 
        public HelpPage()
        {
            InitializeComponent();
        /// <summary>
        /// Entry entry = new Entry { Placeholder = "Enter text" };
        /// entry.TextChanged += OnEntryTextChanged;
        /// entry.Completed += OnEntryCompleted;
        /// </summary>

        Editor editor = new Editor { Placeholder = "Enter text", HeightRequest = 250 };
            editor.TextChanged += OnEditorTextChanged;
            editor.Completed += OnEditorCompleted;

    }
        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
            ///string myText = entry.Text;
        }
        void OnEntryCompleted(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
        }
        void OnEditorTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
            string myText = editor.Text;
        }
        void OnEditorCompleted(object sender, EventArgs e)
        {
            string text = ((Editor)sender).Text;
        }

}

