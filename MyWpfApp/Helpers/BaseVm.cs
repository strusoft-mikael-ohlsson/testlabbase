namespace MyWpfApp.Helpers
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using MyWpfApp.Annotations;

    /// <summary>
    /// The base vm.
    /// </summary>
    public class BaseVm: INotifyPropertyChanged
    {
        /// <summary>
        /// The on closing.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        public virtual void OnClosing(object sender, CancelEventArgs e)
        {
            return;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}