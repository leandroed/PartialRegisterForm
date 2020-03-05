using System.ComponentModel;

namespace config.Views.ViewsModel
{
    /// <summary>
    /// Main view model.
    /// </summary>
    public class ViewModelMain : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets or sets region.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Property changed event.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notify when property is changed.
        /// </summary>
        /// <param name="info">Information.</param>
        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
