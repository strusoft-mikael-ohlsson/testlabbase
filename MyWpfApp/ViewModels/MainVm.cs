namespace MyWpfApp.ViewModels
{
    using System.Windows.Input;

    using MyWpfApp.Helpers;

    /// <summary>
    /// The main vm.
    /// </summary>
    public class MainVm : BaseVm
    {
        /// <summary>
        /// The message.
        /// </summary>
        private string message;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainVm"/> class.
        /// </summary>
        public MainVm()
        {
            this.Init();
        }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message
        {
            get
            {
                return this.message;
            }
            set
            {
                this.message = value;
                this.OnPropertyChanged();
            }
        }

        /// <summary>
        /// The init.
        /// </summary>
        private void Init()
        {
            this.Message = string.Empty;
            this.ClickCommand=new MyCommand((x)=>
                {
                    this.Message = "Hello!";
                });
        }

        public ICommand ClickCommand { get; set; }
    }
}